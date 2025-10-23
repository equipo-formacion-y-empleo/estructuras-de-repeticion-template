# Exercise01c_BinarySearch

## Enunciado

Implementa el algoritmo de [búsqueda binaria](https://es.wikipedia.org/wiki/B%C3%BAsqueda_binaria) usando un bucle `WHILE`. La búsqueda binaria es un algoritmo eficiente para encontrar un elemento en un array ordenado, dividiendo repetidamente el espacio de búsqueda a la mitad.

## Comportamiento

El programa debe:
1. Recibir un array de enteros **ordenados** y un valor objetivo
2. Implementar búsqueda binaria con bucle WHILE
    1. Inicializar límites izquierdo y derecho
    2. Mientras el límite izquierdo sea menor o igual que el derecho:
    3. Calcular el índice medio
    4. Comparar el valor medio con el objetivo
    5. Ajustar los límites según la comparación
       1. Si el valor medio es menor que el objetivo, mover el límite izquierdo
       2. Si el valor medio es mayor que el objetivo, mover el límite derecho
    6. Si se encuentra el elemento, retornar su índice
    7. Si no se encuentra, retornar -1
3. Retornar el índice del elemento si se encuentra, o -1 si no existe
4. Usar división del espacio: comparar con el elemento medio y ajustar límites

## Entrada

El programa recibe 2 argumentos por línea de comandos:
- **Arg 1:** Array de enteros ordenados (separados por comas)
- **Arg 2:** Valor entero a buscar

## Salida


Si el elemento se encuentra:
```
Encontrado en índice <index>
```

Si no se encuentra:
```
No encontrado
```

## Ejemplos

### Ejemplo 1: Elemento encontrado
```bash
dotnet run -- "2,5,8,12,16,23,38,45,56,67,78" 23
```
**Salida:**
```
Encontrado en índice 5
```

### Ejemplo 2: Elemento no encontrado
```bash
dotnet run -- "1,3,5,7,9,11,13,15" 10
```
**Salida:**
```
No encontrado
```

### Ejemplo 3: Elemento en el inicio
```bash
dotnet run -- "10,20,30,40,50" 10
```
**Salida:**
```
Encontrado en índice 0
```

### Ejemplo 4: Elemento al final
```bash
dotnet run -- "5,10,15,20,25,30" 30
```
**Salida:**
```
Encontrado en índice 5
```

## Notas

- El índice devuelto debe ser el de la posición real en el array (empezando en 0).
- Si el valor no se encuentra, imprime exactamente "No encontrado".
- Usa un bucle `while` para implementar la búsqueda binaria, actualizando los límites izquierdo y derecho en cada iteración.
- Asegúrate de manejar correctamente los casos donde el array tiene un solo elemento o el valor no está presente.
