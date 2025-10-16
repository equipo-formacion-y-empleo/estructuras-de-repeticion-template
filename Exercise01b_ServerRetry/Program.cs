/* ======================================================================
 * Ejercicio 01b - Reintento de conexión al servidor (WHILE)
 * Descripción: Intentar conectarse a un servidor con backoff exponencial
 *              hasta alcanzar el máximo de intentos o lograr conexión.
 * ====================================================================== */

/// <summary>
/// Intenta conectar a un servidor con espera exponencial entre reintentos.
/// </summary>
/// <param name="successAttempt">En qué intento se logra la conexión (0 = nunca).</param>
/// <param name="maxAttempts">Máximo número de intentos permitidos.</param>
/// <param name="initialDelay">Tiempo de espera inicial en milisegundos.</param>
void RetryConnection(int successAttempt, int maxAttempts, int initialDelay)
{   
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, contador de intentos y tiempo de espera).
    // 2. Usa un bucle para intentar conectar hasta el máximo de intentos.
    // 3. Si el intento es exitoso, muestra el mensaje de éxito y termina.
    // 4. Si falla, muestra el mensaje de fallo y duplica el tiempo de espera antes del siguiente intento.
    // 5. Si se agotan los intentos, muestra el mensaje de fallo total con la cantidad de intentos.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int successAttempt = 3;
int maxAttempts = 5;
int initialDelay = 1000;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 3)
{
    successAttempt = int.Parse(args[0]);
    maxAttempts = int.Parse(args[1]);
    initialDelay = int.Parse(args[2]);
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
RetryConnection(successAttempt, maxAttempts, initialDelay);
