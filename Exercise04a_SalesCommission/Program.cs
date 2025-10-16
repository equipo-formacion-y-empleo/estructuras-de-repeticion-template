/* ======================================================================
 * Ejercicio 04a - Comisiones de ventas (FOREACH)
 * Descripción: Calcular comisiones totales a partir de un array de ventas
 *              usando foreach para iterar la colección.
 * ====================================================================== */

/// <summary>
/// Calcula la comisión total (5%) de un array de ventas.
/// </summary>
/// <param name="sales">Array con valores de ventas.</param>
void CalculateCommission(int[] sales)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, total de ventas).
    // 2. Usa un bucle foreach para recorrer el array de ventas y suma cada venta al total.
    // 3. Calcula la comisión total (5% de las ventas, puedes usar totalSales / 20).
    // 4. Muestra el resultado en el formato solicitado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] sales = [1000, 1500, 2000, 2500, 3000];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 1)
{
    sales = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
CalculateCommission(sales);
