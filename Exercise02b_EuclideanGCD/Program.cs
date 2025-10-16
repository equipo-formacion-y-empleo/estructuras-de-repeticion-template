/* ======================================================================
 * Ejercicio 02b - Algoritmo de Euclides (DO-WHILE)
 * Descripción: Calcular el Máximo Común Divisor (MCD) de dos números usando
 *              el algoritmo de Euclides con un bucle do-while.
 * ====================================================================== */

/// <summary>
/// Calcula el MCD de dos números usando el algoritmo de Euclides.
/// </summary>
/// <param name="numberA">Primer número positivo.</param>
/// <param name="numberB">Segundo número positivo.</param>
void EuclideanGCD(int numberA, int numberB)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Usa un bucle do-while para aplicar el algoritmo de Euclides:
    //    - Mientras b no sea 0, calcula el resto de a % b, luego asigna b a a y el resto a b.
    // 3. Cuando b sea 0, muestra el valor de a (el MCD).
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int numberA = 48;
int numberB = 18;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    numberA = int.Parse(args[0]);
    numberB = int.Parse(args[1]);
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
EuclideanGCD(numberA, numberB);
