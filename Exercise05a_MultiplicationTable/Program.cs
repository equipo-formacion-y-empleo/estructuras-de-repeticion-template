/* ======================================================================
 * Ejercicio 05a - Tabla de multiplicar (NESTED LOOPS)
 * Descripción: Generar tabla de multiplicar usando bucles anidados
 *              para calcular productos de dos rangos de números.
 * ====================================================================== */

/// <summary>
/// Genera una tabla de multiplicar para dos rangos de números.
/// </summary>
/// <param name="rows">Número de filas (multiplicandos).</param>
/// <param name="cols">Número de columnas (multiplicadores).</param>
void GenerateMultiplicationTable(int rows, int cols)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, suma total).
    // 2. Usa bucles anidados para recorrer filas y columnas.
    // 3. Calcula el producto de la fila y columna actual.
    // 4. Muestra el resultado en el formato solicitado.
    // 5. Suma el producto a la suma total.
    // 6. Al final, muestra la suma total.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int rows = 3;
int cols = 4;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    rows = int.Parse(args[0].Trim());
    cols = int.Parse(args[1].Trim());
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
GenerateMultiplicationTable(rows, cols);
