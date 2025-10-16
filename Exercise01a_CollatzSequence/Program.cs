/* ======================================================================
 * Ejercicio 01a - Secuencia de Collatz (WHILE)
 * Descripción: Generar la secuencia de Collatz (conjetura 3n+1) hasta llegar
 *              al número 1 usando un bucle while.
 * ====================================================================== */

/// <summary>
/// Genera la secuencia de Collatz para un número inicial dado.
/// </summary>
/// <param name="initialNumber">Número inicial para generar la secuencia.</param>
void GenerateCollatzSequence(long initialNumber)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, la secuencia y el contador).
    // 2. Usa un bucle para generar la secuencia de Collatz hasta llegar a 1.
    //    - Si el número es par, divídelo entre 2.
    //    - Si es impar, multiplícalo por 3 y suma 1.
    //    - Agrega cada valor a la secuencia.
    // 3. Muestra la longitud y la secuencia en el formato solicitado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
long initialNumber = 5;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 1)
{
    initialNumber = long.Parse(args[0]);
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
GenerateCollatzSequence(initialNumber);
