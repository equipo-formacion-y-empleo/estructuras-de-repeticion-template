/* ======================================================================
 * Ejercicio 05c - Detección de conflictos de horario (NESTED LOOPS)
 * Descripción: Detectar conflictos entre citas en calendario comparando
 *              rangos de tiempo usando bucles anidados.
 * ====================================================================== */

/// <summary>
/// Detecta conflictos entre citas en un calendario.
/// </summary>
/// <param name="startTimes">Array de horas de inicio (formato 24h: 0-23).</param>
/// <param name="durations">Array de duraciones en horas.</param>
void DetectScheduleConflicts(int[] startTimes, int[] durations)
{
    // 🧩 PASOS PARA IMPLEMENTAR:
    // 1. Prepara las variables necesarias (por ejemplo, letras para citas y contador de conflictos).
    // 2. Usa bucles anidados para comparar cada cita con las demás (sin duplicados).
    // 3. Calcula el horario de fin de cada cita.
    // 4. Detecta si hay solapamiento entre dos citas usando la condición de conflicto.
    // 5. Si hay conflicto, calcula el rango de horas del conflicto y muestra el mensaje en el formato solicitado.
    // 6. Lleva un contador de conflictos y muéstralo al final.
    // TODO: Implementa la lógica siguiendo los pasos anteriores.
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] startTimes = [9, 12, 13, 14];
int[] durations = [2, 1, 2, 1];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    startTimes = [.. args[0].Split(',').Select(s => int.Parse(s.Trim()))];
    durations = [.. args[1].Split(',').Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos de prueba o argumentos de la terminal (no modificar)
DetectScheduleConflicts(startTimes, durations);