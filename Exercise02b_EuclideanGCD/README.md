# Exercise02b_EuclideanGCD

## Enunciado

Implementa el [Algoritmo de Euclides](https://es.wikipedia.org/wiki/Algoritmo_de_Euclides) para calcular el [MCD (Máximo Común Divisor)](https://es.wikipedia.org/wiki/M%C3%A1ximo_com%C3%BAn_divisor) de dos números usando un bucle `DO-WHILE`. Este algoritmo matemático clásico usa divisiones sucesivas y es la base de muchos sistemas criptográficos.

## Comportamiento

El programa debe:
1. Recibir dos números enteros positivos `a` y `b`
2. Aplicar el algoritmo de Euclides
    1. Mientras `b` no sea 0:
        1. Calcular el resto de `a` dividido por `b`
        2. Asignar `b` a `a` y el resto a `b`
3. Retornar el MCD
4. Mostrar el resultado

## Entrada

El programa recibe 2 argumentos por línea de comandos:
- **Arg 1:** Número entero positivo
- **Arg 2:** Número entero positivo

## Salida

```
Máximo Común Divisor
```

## Ejemplos

### Ejemplo 1: MCD de 48 y 18
```bash
dotnet run -- 48 18
```
**Salida:**
```
6
```

### Ejemplo 2: MCD de 100 y 35
```bash
dotnet run -- 100 35
```
**Salida:**
```
5
```

### Ejemplo 3: Números primos entre sí
```bash
dotnet run -- 17 13
```
**Salida:**
```
1
```

### Ejemplo 4: Un número múltiplo del otro
```bash
dotnet run -- 36 12
```
**Salida:**
```
12
```

### Ejemplo 5: Números grandes
```bash
dotnet run -- 1071 462
```
**Salida:**
```
21
```

## Notas

- El algoritmo de Euclides es uno de los algoritmos más antiguos (300 a.C.)
- Si `b=0` inicialmente, el MCD es simplemente `a`
- El orden de los argumentos no afecta el resultado
- Dos números son "primos entre sí" si su MCD es 1
- Este algoritmo es fundamental en criptografía RSA
- El número de iteraciones depende de la relación entre los números
