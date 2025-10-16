/* ======================================================================
 * Ejercicio 03c - Calculadora de puntos de engagement (FOR)
 * Descripción: Calcular puntos de engagement de Stream con actividad
 *              de chat y duración de streams usando bucle FOR.
 * ====================================================================== */

/// <summary>
/// Calcula los puntos totales de engagement en Stream.
/// </summary>
/// <param name="chatMessagesPerHour">Array de mensajes de chat por hora en cada stream.</param>
/// <param name="streamDuration">Array de duración en horas de cada stream.</param>
void CalculateStreamRevenue(int[] chatMessagesPerHour, int[] streamDuration)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, total de puntos).
    // 2. Usa un bucle for para recorrer cada stream.
    // 3. Calcula los puntos según la duración y el multiplicador.
    // 4. Muestra la información de cada stream en el formato solicitado.
    // 5. Suma los puntos al total.
    // 6. Al final, muestra el total de puntos.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] chatMessagesPerHour = [15, 20, 18, 25];
int[] streamDuration = [4, 5, 3, 6];

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    chatMessagesPerHour = [.. args[0].Split(',')
        .Select(s => int.Parse(s.Trim()))];
    streamDuration = [.. args[1].Split(',')
        .Select(s => int.Parse(s.Trim()))];
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
CalculateStreamRevenue(chatMessagesPerHour, streamDuration);
