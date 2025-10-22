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

El programa imprime la secuencia, un valor por línea, y finaliza con una línea adicional que indica la longitud:

```
<n1>
<n2>
...
<1>
Longitud: <L>
```

## Ejemplos

### Ejemplo 1: Secuencia simple (n=5)
```
dotnet run -- 5
```

**Salida:**

```
5
16
8
4
2
1
Longitud: 6
```

### Ejemplo 2: Secuencia más larga (n=27)
```
dotnet run -- 100
```

**Salida:**

```
100
50
25
76
38
19
58
29
88
44
22
11
34
17
52
26
13
40
20
10
5
16
8
4
2
1
Longitud: 26
```

### Ejemplo 3: Número pequeño (n=1)
```bash
dotnet run -- 1
```
**Salida:**
```
1
Longitud: 1
```

### Ejemplo 4: Potencia de 2 (n=16)
```bash
dotnet run -- 16
```
**Salida:**
```
16
8
4
2
1
Longitud: 5
```

## Notas

- Usar `long` en lugar de `int` para evitar overflow con números grandes
- La secuencia de 27 genera números que superan 9000 antes de descender
- Las potencias de 2 tienen las secuencias más cortas (solo divisiones por 2)
- El número con la secuencia más larga conocida menor que 100 es el 97 (119 pasos)
- ⚠️ La condición del WHILE es indeterminada (no se puede predecir cuántas iteraciones)
- Este ejercicio demuestra un uso de WHILE donde no conocemos de antemano el número de iteraciones
- Algunos números generan secuencias sorprendentemente largas antes de llegar a 1
