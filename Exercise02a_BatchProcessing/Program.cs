/* ======================================================================
 * Ejercicio 02a - Procesamiento por lotes (DO-WHILE)
 * Descripción: Procesar lotes de registros de tamaño fijo hasta que no haya
 *              más datos disponibles. Garantiza al menos un lote procesado.
 * ====================================================================== */

/// <summary>
/// Procesa lotes de datos con tamaños variables.
/// </summary>
/// <param name="batchSizes">Array con el tamaño de cada lote.</param>
void ProcessBatches(int[] batchSizes)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, acumulador y contador de lotes).
    // 2. Usa un bucle para procesar todos los lotes del array batchSizes.
    // 3. Para cada lote, muestra el número de lote y la cantidad de items.
    // 4. Suma los items al acumulador total.
    // 5. Al finalizar, muestra el total de items procesados en el formato solicitado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] batchSizes = [100, 200, 150];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 1)
{
    batchSizes = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))
        ];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
ProcessBatches(batchSizes);
