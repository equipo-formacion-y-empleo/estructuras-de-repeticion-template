# Plantilla de ejercicios: Estructuras de repetición en C#

Repositorio de ejercicios para practicar las construcciones de repetición (bucles) en C#.

Cada ejercicio es pequeño, independiente y pensado para practicar una idea concreta (while, do-while, for, foreach, bucles anidados).

## Objetivos para el estudiante

- Entender y aplicar el bucle `while` para iteraciones con condición previa.
- Practicar el bucle `do-while` garantizando al menos una ejecución.
- Usar bucles `for` cuando el número de iteraciones es conocido o controlado.
- Aplicar `foreach` para iterar sobre colecciones de forma legible y segura.
- Implementar bucles anidados para trabajar con estructuras multi-dimensionales.
- Resolver problemas complejos combinando diferentes tipos de bucles.

## Requisitos

- .NET 7+ SDK (o compatible). Projects in this workspace currently target `net7.0`.
- PowerShell 7+ para ejecutar los scripts de prueba.

## Cómo ejecutar un ejercicio

1. Navega a la carpeta del ejercicio:
```powershell
Set-Location Exercise01a_CollatzSequence
```

2. Ejecuta el proyecto con argumentos (si los hay):
```powershell
dotnet run -- [argumentos]
```

Por ejemplo:
```powershell
# Ejecutar con el valor por defecto
dotnet run

# Ejecutar con argumentos personalizados
dotnet run -- 10
```

## Cómo ejecutar las pruebas locales

En PowerShell (desde la raíz del repositorio):

```powershell
# Ejecuta todos los ejercicios y muestra detalle
./Test-Exercises.ps1

# Ejecuta un ejercicio concreto (ejemplo)
./Test-Exercises.ps1 Exercise01a_CollatzSequence
```

## Autocorrección (autograding)

- En GitHub se ejecuta `.github/workflows/autograding.yml` de manera automática.
- Localmente, `Test-Exercises.ps1` reproduce la misma validación.

## Estructura del repositorio

- `ExerciseXX_*`: carpeta por ejercicio con `*.csproj`, `Program.cs` (código) y `README.md` (enunciado en español).
- `test-data.json`: argumentos y salidas esperadas usadas por el script de prueba.
- `Test-Exercises.ps1`: ejecuta y valida todos los ejercicios.
- `Test-Exercises-Parallel.ps1`: versión paralela del script de prueba (más rápida).

## Instrucciones generales para los ejercicios (contrato)

1. Lee el `README.md` dentro de la carpeta del ejercicio para el enunciado y ejemplos de entrada/salida.
2. Implementa únicamente la(s) función(es) solicitada(s).
3. Nombres de variables/funciones en inglés; comentarios y textos impresos en español.

Errores esperados y casos límite a cubrir (recomendado):

- Valores nulos o vacíos en las entradas (si procede) — valida según el enunciado.
- Números negativos, cero y positivos (cuando aplique).
- Valores en los límites de rangos.
- Colecciones vacías o con un solo elemento.

## Lista de ejercicios por concepto

### Sección 1: Ejercicios WHILE (condición al inicio, iteraciones desconocidas)
- `Exercise01a_CollatzSequence` — Generar secuencia de Collatz hasta llegar a 1.
- `Exercise01b_ServerRetry` — Intentar conexión al servidor con reintentos exponenciales.
- `Exercise01c_BinarySearch` — Búsqueda binaria en array ordenado.

### Sección 2: Ejercicios DO-WHILE (al menos una ejecución, condición al final)
- `Exercise02a_BatchProcessing` — Procesar lotes de datos garantizando al menos un lote ejecutado.
- `Exercise02b_EuclideanGCD` — Algoritmo euclidiano para calcular máximo común divisor.
- `Exercise02c_PasswordAuthentication` — Sistema de autenticación con límite de intentos.

### Sección 3: Ejercicios FOR (iteraciones conocidas, con contador)
- `Exercise03a_MonthlyReports` — Generar reportes mensuales para un año completo.
- `Exercise03b_LoLRankedAnalyzer` — Simular sistema de League Points con ganancias/pérdidas, calcular promedio y determinar promoción/descenso.
- `Exercise03c_StreamRevenue` — Calcular puntos de engagement en plataforma de streaming con multiplicador por duración.

### Sección 4: Ejercicios FOREACH (iteración sobre colecciones)
- `Exercise04a_SalesCommission` — Calcular comisiones totales de un array de ventas.
- `Exercise04b_HospitalBedMonitor` — Monitorear disponibilidad de camas hospitalarias por servicio.
- `Exercise04c_ServerLatencyAnalyzer` — Analizar latencias de red y clasificar calidad de conexiones.

### Sección 5: Ejercicios NESTED LOOPS (bucles anidados, estructuras multi-dimensionales)
- `Exercise05a_MultiplicationTable` — Generar tabla de multiplicar con sumas totales.
- `Exercise05b_TeslaManufacturingCosts` — Calcular costos de producción de modelos Tesla en Gigafactories.
- `Exercise05c_ScheduleConflict` — Detectar conflictos entre citas en calendario.

## Notas sobre el proyecto

Este repositorio contiene **15 ejercicios principales** organizados en 5 secciones que cubren los conceptos fundamentales de estructuras de repetición en C#:

- **Sección 1 (WHILE)**: 3 ejercicios - Bucles con condición previa e iteraciones desconocidas
- **Sección 2 (DO-WHILE)**: 3 ejercicios - Bucles con al menos una ejecución garantizada
- **Sección 3 (FOR)**: 3 ejercicios - Bucles con contador e iteraciones conocidas
- **Sección 4 (FOREACH)**: 3 ejercicios - Iteración sobre colecciones
- **Sección 5 (NESTED)**: 3 ejercicios - Bucles anidados para estructuras bidimensionales

Adicionalmente, el repositorio contiene ejercicios opcionales avanzados (Exercise06a-Exercise06t) para estudiantes que deseen practicar conceptos más complejos. Estos ejercicios opcionales no son parte del currículo principal y no se incluyen en las pruebas automáticas básicas.

## Consejos para resolver los ejercicios

- Lee cuidadosamente el enunciado y los ejemplos.
- Identifica qué tipo de bucle es más apropiado para el problema.
- Asegúrate de que tu bucle tenga una condición de salida clara.
- Prueba con los casos de ejemplo antes de enviar.
- Ten en cuenta los casos límite (arrays vacíos, valores extremos, etc.).
- Usa nombres de variables descriptivos.
- Comenta tu código cuando la lógica no sea obvia.

## Diferencias entre tipos de bucles

| Tipo | Cuándo usar | Condición | Garantía |
|------|-------------|-----------|----------|
| `while` | Iteraciones desconocidas | Al inicio | Puede no ejecutarse |
| `do-while` | Al menos una ejecución necesaria | Al final | Se ejecuta mínimo 1 vez |
| `for` | Contador conocido/controlado | Al inicio | Control preciso de iteraciones |
| `foreach` | Iterar colecciones | Implícita | Recorre todos los elementos |
| Anidados | Datos bidimensionales | Múltiples | Mayor complejidad |
