# Exercise01a_CollatzSequence

## Enunciado

Implementa el algoritmo de la [Conjetura de Collatz](https://es.wikipedia.org/wiki/Conjetura_de_Collatz) usando un bucle `WHILE`. Esta es una conjetura matemática famosa que afirma que cualquier número positivo eventualmente llegará a 1 siguiendo estas reglas:
- Si el número es par, se divide entre 2.
- Si el número es impar, se multiplica por 3 y se le suma 1.

## Comportamiento

El programa debe:
1. Recibir un número entero positivo `n`
2. Generar la secuencia de Collatz aplicando las reglas
3. Continuar hasta que `n` sea 1
4. Mostrar la secuencia completa y su longitud

**Nota matemática:** Aunque se ha verificado para números extremadamente grandes, la conjetura aún no ha sido demostrada matemáticamente para todos los números.

## Entrada

El programa recibe 1 argumento por línea de comandos:
- **Arg 1:** Número entero positivo inicial

## Salida

```
Número inicial: <n>
Longitud de secuencia: <count>
Secuencia: n₁,n₂,n₃,...,1
```

## Ejemplos

### Ejemplo 1: Secuencia simple (n=5)
```bash
dotnet run -- 5
```
**Salida:**
```
Número inicial: 5
Longitud de secuencia: 6
Secuencia: 5,16,8,4,2,1
```

### Ejemplo 2: Secuencia más larga (n=27)
```bash
dotnet run -- 27
```
**Salida:**
```
Número inicial: 27
Longitud de secuencia: 112
Secuencia: 27,82,41,124,62,31,94,47,142,71,214,107,322,161,484,242,121,364,182,91,274,137,412,206,103,310,155,466,233,700,350,175,526,263,790,395,1186,593,1780,890,445,1336,668,334,167,502,251,754,377,1132,566,283,850,425,1276,638,319,958,479,1438,719,2158,1079,3238,1619,4858,2429,7288,3644,1822,911,2734,1367,4102,2051,6154,3077,9232,4616,2308,1154,577,1732,866,433,1300,650,325,976,488,244,122,61,184,92,46,23,70,35,106,53,160,80,40,20,10,5,16,8,4,2,1
```

### Ejemplo 3: Número pequeño (n=1)
```bash
dotnet run -- 1
```
**Salida:**
```
Número inicial: 1
Longitud de secuencia: 1
Secuencia: 1
```

### Ejemplo 4: Potencia de 2 (n=16)
```bash
dotnet run -- 16
```
**Salida:**
```
Número inicial: 16
Longitud de secuencia: 5
Secuencia: 16,8,4,2,1
```

## Notas

- Usar `long` en lugar de `int` para evitar overflow con números grandes
- La secuencia de 27 genera números que superan 9000 antes de descender
- Las potencias de 2 tienen las secuencias más cortas (solo divisiones por 2)
- El número con la secuencia más larga conocida menor que 100 es el 97 (119 pasos)
- ⚠️ La condición del WHILE es indeterminada (no se puede predecir cuántas iteraciones)
- Este ejercicio demuestra un uso de WHILE donde no conocemos de antemano el número de iteraciones
- Algunos números generan secuencias sorprendentemente largas antes de llegar a 1
