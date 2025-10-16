/* ======================================================================
 * Ejercicio 03b - Analizador de partidas de LoL (FOR)
 * Descripción: Simular el sistema real de League Points con ganancias
 *              y pérdidas, calculando LP final y promedio usando división.
 * ====================================================================== */

/// <summary>
/// Analiza partidas de League of Legends con cambios de LP (+/-).
/// Calcula LP final, promedio de cambio, y determina promoción/descenso.
/// </summary>
/// <param name="lpChanges">Array de cambios de LP por partida (positivos y negativos).</param>
void AnalyzeRankedMatches(int[] lpChanges)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, LP acumulado, suma total, victorias y derrotas).
    // 2. Usa un bucle for para recorrer el array de cambios de LP.
    // 3. Acumula el LP, cuenta victorias/derrotas y muestra el resultado de cada partida.
    // 4. Calcula el promedio de cambio de LP.
    // 5. Determina el resultado de la sesión (promoción, descenso o se mantiene).
    // 6. Muestra el resumen final en el formato solicitado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] lpChanges = [+18, -15, +20, -12, +17];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 1)
{
    lpChanges = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
AnalyzeRankedMatches(lpChanges);
