/* ======================================================================
 * Ejercicio 02c - Autenticación con contraseña (DO-WHILE)
 * Descripción: Sistema de autenticación que verifica contraseñas con intentos
 *              limitados. Debe intentar al menos una vez antes de bloquearse.
 * ====================================================================== */

/// <summary>
/// Autentica un usuario verificando contraseñas con intentos limitados.
/// </summary>
/// <param name="correctPassword">Contraseña correcta del sistema.</param>
/// <param name="attempts">Array de intentos de contraseña del usuario.</param>
/// <param name="maxAttempts">Número máximo de intentos permitidos.</param>
void AuthenticateUser(string correctPassword, string[] attempts, int maxAttempts)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Usa un bucle do-while para procesar los intentos de autenticación hasta acertar o agotar los intentos.
    // 2. En cada intento, compara la contraseña ingresada con la correcta.
    // 3. Si es correcta, imprime el mensaje de éxito y termina.
    // 4. Si es incorrecta, imprime el mensaje correspondiente y los intentos restantes (si aplica).
    // 5. Si se agotan los intentos sin éxito, imprime el mensaje de cuenta bloqueada.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
string correctPassword = "SecurePass123";
string[] attempts = ["password", "Pass123", "SecurePass123"];
int maxAttempts = 3;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 3)
{
    correctPassword = args[0];
    attempts = [.. args[1].Split(',').Select(s => s.Trim())];
    maxAttempts = int.Parse(args[2]);
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
AuthenticateUser(correctPassword, attempts, maxAttempts);
