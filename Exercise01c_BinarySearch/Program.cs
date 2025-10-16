/* ======================================================================
 * Ejercicio 01c - Búsqueda Binaria (WHILE)
 * Descripción: Implementar el algoritmo de búsqueda binaria para encontrar
 *              un elemento en un array ordenado usando un bucle while.
 * ====================================================================== */

/// <summary>
/// Busca un elemento en un array ordenado usando búsqueda binaria.
/// </summary>
/// <param name="sortedArray">Array ordenado de enteros donde buscar.</param>
/// <param name="target">Valor a buscar en el array.</param>
void BinarySearch(int[] sortedArray, int target)
{
    // TODO 🧩 Sigue estos pasos para implementar la función:
    // 1. Prepara las variables necesarias (por ejemplo, límites izquierdo y derecho).
    // 2. Usa un bucle para buscar el valor objetivo:
    //    - Calcula el índice medio.
    //    - Si el valor medio es igual al objetivo, muestra el índice y termina.
    //    - Si es menor, ajusta el límite izquierdo; si es mayor, ajusta el derecho.
    // 3. Si no se encuentra, muestra el mensaje de no encontrado.
    // (Elimina este comentario y la excepción al terminar)
    throw new NotImplementedException();
}

// 🧪 Datos de prueba - cámbialos para probar tu código
int[] sortedArray = [1, 3, 5, 7, 9, 11, 13, 15];
int target = 7;

// ⚙️ Lee argumentos desde la terminal (no modificar esta sección)
if (args.Length >= 2)
{
    sortedArray = [.. args[0].Split(',').Select(s => int.Parse(s.Trim()))];
    target = int.Parse(args[1].Trim());
}

// ▶️ Ejecuta la función con los datos configurados (no modificar)
BinarySearch(sortedArray, target);
