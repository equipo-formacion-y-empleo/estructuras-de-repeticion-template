/* ======================================================================
 * Ejercicio 05b - Matriz de costos de producción Tesla (NESTED LOOPS)
 * Descripción: Calcular costos de fabricación de modelos Tesla en
 *              múltiples Gigafactories usando bucles anidados.
 * ====================================================================== */

/// <summary>
/// Calcula matriz de costos de producción para modelos y Gigafactories.
/// </summary>
/// <param name="factoryBaseCosts">Array de costos base por Gigafactory (miles $).</param>
/// <param name="modelAssemblyTimes">Array de tiempos de ensamblaje por modelo (horas).</param>
void CalculateTeslaManufacturingCosts(int[] factoryBaseCosts, int[] modelAssemblyTimes)
{
    // 🧩 PASOS PARA IMPLEMENTAR:
    // 1. Prepara las variables necesarias (por ejemplo, costo total).
    // 2. Usa bucles anidados para recorrer modelos y gigafábricas.
    // 3. Muestra el modelo y su tiempo de ensamblaje.
    // 4. Calcula el costo de producción para cada combinación.
    // 5. Muestra el costo de producción de cada gigafábrica.
    // 6. Suma el costo al total.
    // 7. Al finalizar, muestra el costo total de producción.
    // TODO: Implementa la lógica siguiendo los pasos anteriores.
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] factoryBaseCosts = [5, 7, 6];
int[] modelAssemblyTimes = [3, 1];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    factoryBaseCosts = [.. args[0].Split(',').Select(s => int.Parse(s.Trim()))];
    modelAssemblyTimes = [.. args[1].Split(',').Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
CalculateTeslaManufacturingCosts(factoryBaseCosts, modelAssemblyTimes);
