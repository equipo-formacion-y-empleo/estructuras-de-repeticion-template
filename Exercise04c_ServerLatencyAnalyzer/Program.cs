/* ======================================================================
 * Ejercicio 04c - Analizador de latencia de red (FOREACH)
 * Descripción: Analizar latencias de red (ms) y clasificar la calidad
 *              de las conexiones usando bucle FOREACH.
 * ====================================================================== */

/// <summary>
/// Analiza latencias de red (ms) y las clasifica por calidad.
/// </summary>
/// <param name="latencies">Array de latencias en milisegundos (ms).</param>
void AnalyzeServerLatency(int[] latencies)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, contadores para cada tipo de clasificación).
    // 2. Usa un bucle foreach para recorrer el array de latencias y clasifica cada valor según los rangos dados.
    // 3. Muestra cada latencia con su clasificación.
    // 4. Al final, muestra el resumen de conteos en el formato solicitado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] latencies = [5, 15, 30, 0, 20];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 1)
{
    latencies = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
AnalyzeServerLatency(latencies);
