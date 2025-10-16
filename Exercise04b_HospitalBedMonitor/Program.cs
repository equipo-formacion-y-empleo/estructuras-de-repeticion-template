/* ======================================================================
 * Ejercicio 04b - Monitoreo de camas hospitalarias (FOREACH)
 * Descripción: Monitorear disponibilidad de camas por servicio y
 *              detectar servicios en estado crítico usando FOREACH.
 * ====================================================================== */

/// <summary>
/// Monitorea disponibilidad de camas y detecta servicios críticos.
/// </summary>
/// <param name="bedsByService">Array con camas disponibles por servicio.</param>
/// <param name="criticalThreshold">Umbral mínimo de camas (estado crítico si es menor).</param>
void MonitorHospitalBeds(int[] bedsByService, int criticalThreshold)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, capacidad total, cantidad de servicios críticos y total de servicios).
    // 2. Usa un bucle foreach para recorrer el array de camas y suma cada valor al total.
    // 3. Si el servicio está por debajo del umbral, muestra una alerta y cuenta el servicio crítico.
    // 4. Al final, muestra la capacidad total y el resumen de servicios críticos.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] bedsByService = [25, 8, 15, 3, 50];
int criticalThreshold = 10;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    bedsByService = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))];
    criticalThreshold = int.Parse(args[1].Trim());
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
MonitorHospitalBeds(bedsByService, criticalThreshold);
