/* ======================================================================
 * Ejercicio 03a - Reportes mensuales (FOR)
 * Descripción: Generar reportes mensuales para un año completo usando
 *              un bucle for con contador conocido.
 * ====================================================================== */

/// <summary>
/// Genera reportes mensuales para un año.
/// </summary>
/// <param name="monthlyData">Array con datos de 12 meses.</param>
void GenerateMonthlyReports(int[] monthlyData)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, nombres de meses y total acumulado).
    // 2. Usa un bucle for para recorrer los 12 meses.
    // 3. Muestra el reporte de cada mes en el formato solicitado.
    // 4. Suma cada valor mensual al total acumulado.
    // 5. Al final, muestra el total acumulado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] monthlyData = [1200, 1500, 1300, 1400, 1600, 1550, 1700, 1650, 1800, 1750, 1900, 2000];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 1)
{
    monthlyData = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
GenerateMonthlyReports(monthlyData);
