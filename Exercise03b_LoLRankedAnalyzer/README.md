# Exercise03b_LoLRankedAnalyzer

## Enunciado

Implementar un analizador de partidas clasificatorias de **League of Legends** que simula el sistema real de **League Points (LP)**. El jugador comienza en 0 LP y gana o pierde LP según el resultado de cada partida. El sistema calcula el LP final, el promedio de cambio de LP por partida, y genera estadísticas sobre victorias y derrotas. El bucle `FOR` con índice permite mostrar el número de partida de forma secuencial.

**Comportamiento:**
- Usar un bucle `for` con índice para procesar cada cambio de LP.
- Para cada partida, mostrar su número, cambio de LP (con signo +/-), y LP acumulado.
- Calcular el LP final y el promedio de cambio por partida (usando división).
- Contar victorias (LP positivo) y derrotas (LP negativo).
- Determinar si el jugador promovió (≥100 LP), se mantuvo, o descendió (<0 LP).

## Entrada

Un argumento por línea de comandos:
1. `lpChanges` (string): lista de cambios de LP por partida separados por comas, con signo + o - (ej: "+18,-15,+20,-12,+17").

## Salida

Líneas de salida:
1. Para cada partida: `Partida X: [+/-]Y LP (Total: Z LP)`
2. `LP final: Z`
3. `Promedio de cambio: [+/-]P LP por partida`
4. `Victorias: V, Derrotas: D`
5. `Resultado: [Promoción a siguiente división / Se mantiene en división / Descendió de división]`

## Ejemplos

### Ejemplo 1

**Entrada:** `dotnet run "+18,-15,+20,-12,+17`

**Salida esperada:**
```
Partida 1: +18 LP (Total: 18 LP)
Partida 2: -15 LP (Total: 3 LP)
Partida 3: +20 LP (Total: 23 LP)
Partida 4: -12 LP (Total: 11 LP)
Partida 5: +17 LP (Total: 28 LP)
LP final: 28
Promedio de cambio: +5 LP por partida
Victorias: 3, Derrotas: 2
Resultado: Se mantiene en división
```

### Ejemplo 2

**Entrada:** `dotnet run "+22,+20,+25,+18,+20"`

**Salida esperada:**
```
Partida 1: +22 LP (Total: 22 LP)
Partida 2: +20 LP (Total: 42 LP)
Partida 3: +25 LP (Total: 67 LP)
Partida 4: +18 LP (Total: 85 LP)
Partida 5: +20 LP (Total: 105 LP)
LP final: 105
Promedio de cambio: +21 LP por partida
Victorias: 5, Derrotas: 0
Resultado: Promoción a siguiente división
```

### Ejemplo 3

**Entrada:** `dotnet run "-18,-15,-20,-12"`

**Salida esperada:**
```
Partida 1: -18 LP (Total: -18 LP)
Partida 2: -15 LP (Total: -33 LP)
Partida 3: -20 LP (Total: -53 LP)
Partida 4: -12 LP (Total: -65 LP)
LP final: -65
Promedio de cambio: -16 LP por partida
Victorias: 0, Derrotas: 4
Resultado: Descendió de división
```

### Ejemplo 4
**Entrada:** `dotnet run "+20,-15,+18,-12,+15,-10"`

**Salida esperada:**
```
Partida 1: +20 LP (Total: 20 LP)
Partida 2: -15 LP (Total: 5 LP)
Partida 3: +18 LP (Total: 23 LP)
Partida 4: -12 LP (Total: 11 LP)
Partida 5: +15 LP (Total: 26 LP)
Partida 6: -10 LP (Total: 16 LP)
LP final: 16
Promedio de cambio: +2 LP por partida
Victorias: 3, Derrotas: 3
Resultado: Se mantiene en división
```

## Notas

- Lleva un acumulador para el LP total y contadores para victorias y derrotas.
- El bucle `for` con índice te permite mostrar el número de partida correctamente.
- Recuerda calcular el promedio usando la cantidad total de partidas.
- Asegúrate de mostrar el resultado final según el LP obtenido.
