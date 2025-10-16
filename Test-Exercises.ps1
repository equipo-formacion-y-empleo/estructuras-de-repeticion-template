param(
    [string]$ExerciseName = "",
    # Allow passing a custom test-data JSON file (relative to script root or absolute). If empty, defaults to test-data.json
    [string]$TestDataPath = "",
    # If provided (>0), only run the specified test-case index (1-based) for each exercise being executed
    [int]$CaseIndex = 0,
    [switch]$Verbose = $false
)

[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
[System.Threading.Thread]::CurrentThread.CurrentCulture = [System.Globalization.CultureInfo]::new("es-ES")
[System.Threading.Thread]::CurrentThread.CurrentUICulture = [System.Globalization.CultureInfo]::new("es-ES")

$testDataPath = if ($TestDataPath) { $TestDataPath } else { Join-Path $PSScriptRoot "test-data.json" }

# If the provided path is relative, try resolving it against the script root
if (-not (Test-Path $testDataPath)) {
    $alt = Join-Path $PSScriptRoot $testDataPath
    if (Test-Path $alt) { $testDataPath = $alt } else { Write-Error "Test data file not found: $testDataPath"; exit 1 }
}

$testData = Get-Content $testDataPath -Raw | ConvertFrom-Json
$testCasesWithArgs = @{}
foreach ($exercise in $testData.testCases.PSObject.Properties) {
    $testCasesWithArgs[$exercise.Name] = $exercise.Value
}

function Write-Success($message) { Write-Host $message -ForegroundColor Green }
function Write-Error($message)   { Write-Host $message -ForegroundColor Red }
function Write-Info($message)    { Write-Host $message -ForegroundColor Cyan }

function Compare-OutputWithFlexibleDecimals {
    param([string]$Expected,[string]$Actual)
    if ($Actual.Trim() -eq $Expected.Trim()) { return $true }
    $expectedNorm = $Expected.Replace(',', '.').Replace('.', ',')
    $actualNorm   = $Actual.Replace(',', '.').Replace('.', ',')
    if ($Actual.Trim() -eq $expectedNorm.Trim()) { return $true }
    if ($actualNorm.Trim() -eq $Expected.Trim()) { return $true }
    return $false
}

function Test-Exercise {
    param(
        [string]$ExercisePath,
        [string[]]$Arguments = @(),
        [string[]]$ExpectedOutputs = @(),
        [string]$ExerciseName
    )

    $csprojFiles = Get-ChildItem -Path $ExercisePath -Filter *.csproj -Recurse
    if ($csprojFiles.Count -eq 0) { Write-Error "No .csproj file found in $ExercisePath"; return $false }
    $csprojFile = $csprojFiles[0]

    if ($Arguments.Count -gt 0) { $output = & dotnet run --project $csprojFile -- @Arguments 2>&1 }
    else { $output = & dotnet run --project $csprojFile 2>&1 }

    if ($LASTEXITCODE -ne 0) { Write-Error "Runtime error in $ExerciseName"; if ($Verbose) { Write-Host $output -ForegroundColor Red }; return $false }

    $success = $true
    $outputLines = ($output -split "`r?`n" | Where-Object { $_.Trim() -ne "" })
    
    # Handle empty expected output
    if ([string]::IsNullOrEmpty($ExpectedOutputs)) {
        if ($outputLines.Count -gt 0) {
            Write-Error "Expected no output, but got output in ${ExerciseName}"
            Write-Host "Actual output lines:" -ForegroundColor Yellow
            foreach ($line in $outputLines) { Write-Host "  '$line'" -ForegroundColor Gray }
            $success = $false
        }
    }
    # Handle non-empty expected output
    elseif ($ExpectedOutputs.Count -gt 0) {
        foreach ($expected in $ExpectedOutputs) {
            $found = $false
            foreach ($line in $outputLines) {
                if (Compare-OutputWithFlexibleDecimals $expected $line) { $found = $true; break }
            }
            if (-not $found) {
                Write-Error "Expected output not found in ${ExerciseName}: '$expected'"
                Write-Host "Actual output lines:" -ForegroundColor Yellow
                foreach ($line in $outputLines) { Write-Host "  '$line'" -ForegroundColor Gray }
                $success = $false
            }
        }
    }

    if ($success) { Write-Success "$ExerciseName passed all tests!" }
    return $success
}

$total = 0; $passed = 0

$exercisesToRun = if ($ExerciseName) { @($ExerciseName) } else { $testData.exercises }
foreach ($exercise in $exercisesToRun) {
    $sets = $testCasesWithArgs[$exercise]
    # If the user requested a specific case index (1-based), try to pick only that set.
    if ($CaseIndex -gt 0) {
        if ($null -eq $sets) {
            Write-Error "No test cases configured for $exercise (cannot apply CaseIndex)"; $sets = @()
        }
        elseif ($sets.Count -ge $CaseIndex) {
            # Select single set as an array with one element
            $sets = @($sets[$CaseIndex - 1])
        }
        else {
            Write-Error "CaseIndex $CaseIndex out of range for $exercise (only $($sets.Count) sets)"; $sets = @()
        }
    }
    $setIndex = 1
    foreach ($set in $sets) {
        $total++
        $description = if ($set.description) { " - $($set.description)" } else { "" }
        Write-Info "Testing $exercise (args set $setIndex)$description..."
        if (Test-Exercise -ExercisePath (Join-Path $PSScriptRoot $exercise) -Arguments $set.arguments -ExpectedOutputs $set.expectedOutputs -ExerciseName "$exercise (args set $setIndex)") {
            $passed++
            if ($Verbose) { Write-Host "Output:"; Write-Host (($set.expectedOutputs -join ' ') + "`n---") }
        }
        Write-Host ""
        $setIndex++
    }
}

Write-Host "=== Test Summary ==="
Write-Host "Total tests: $total"
Write-Host "Passed: $passed"
if ($passed -eq $total) { Write-Host "All tests passed! 🎉" -ForegroundColor Green }
else { Write-Host "Some tests failed." -ForegroundColor Red; exit 1 }
