# Exercise05a_MultiplicationTable

## Enunciado

Implementar un generador de tabla de multiplicar que calcula el producto de dos rangos de números usando bucles anidados. Para cada combinación de fila y columna, se calcula y muestra el producto, y al final se muestra la suma total de todos los productos. Este patrón es fundamental para entender cómo los bucles anidados generan combinaciones.

**Comportamiento:**
- Usar un bucle `for` exterior para iterar sobre las filas (multiplicandos).
- Usar un bucle `for` interior para iterar sobre las columnas (multiplicadores).
- Para cada combinación, calcular el producto: `fila × columna`.
- Mostrar cada operación en formato `X x Y = Z`.
- Acumular la suma de todos los productos.
- Mostrar la suma total al final.

## Entrada

Dos argumentos por línea de comandos:
1. `rows` (int): número de filas/multiplicandos (ej: "3" para 1, 2, 3).
2. `cols` (int): número de columnas/multiplicadores (ej: "4" para 1, 2, 3, 4).

## Salida

Para cada combinación:
```
X x Y = Z
```

Al finalizar:
```
Suma total: N
```

## Ejemplos

### Ejemplo 1: Tabla 3x4
**Entrada:** `dotnet run "3" "4"`

**Salida esperada:**
```
1 x 1 = 1
1 x 2 = 2
1 x 3 = 3
1 x 4 = 4
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
3 x 4 = 12
Suma total: 60
```

### Ejemplo 2: Tabla 2x2
**Entrada:** `dotnet run "2" "2"`

**Salida esperada:**
```
1 x 1 = 1
1 x 2 = 2
2 x 1 = 2
2 x 2 = 4
Suma total: 9
```

### Ejemplo 3: Una sola fila
**Entrada:** `dotnet run "1" "5"`

**Salida esperada:**
```
1 x 1 = 1
1 x 2 = 2
1 x 3 = 3
1 x 4 = 4
1 x 5 = 5
Suma total: 15
```

### Ejemplo 4: Una sola columna
**Entrada:** `dotnet run "4" "1"`

**Salida esperada:**
```
1 x 1 = 1
2 x 1 = 2
3 x 1 = 3
4 x 1 = 4
Suma total: 10
```

### Ejemplo 5: Tabla grande
**Entrada:** `dotnet run "5" "5"`

**Salida esperada:**
```
1 x 1 = 1
1 x 2 = 2
1 x 3 = 3
1 x 4 = 4
1 x 5 = 5
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
3 x 4 = 12
3 x 5 = 15
4 x 1 = 4
4 x 2 = 8
4 x 3 = 12
4 x 4 = 16
4 x 5 = 20
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15
5 x 4 = 20
5 x 5 = 25
Suma total: 225
```

## Notas

- Usa bucles anidados: uno para las filas y otro para las columnas.
- Lleva un acumulador para la suma total de los productos.
- Muestra cada operación en el formato `X x Y = Z`.
- Recuerda que los índices empiezan en 1 para filas y columnas.
- Asegúrate de mostrar la suma total al final.
