# Exercise05b_ScheduleConflict

## Enunciado

Implementar un detector de conflictos de horario que identifica solapamientos entre citas en un calendario. Los bucles anidados permiten comparar cada cita con todas las demás para detectar conflictos.

**Comportamiento:**
- Usar bucles **anidados** para comparar pares de citas.
- Bucle exterior: iterar sobre cada cita.
- Bucle interior: comparar con citas posteriores de la lista para evitar duplicados.
- Detectar solapamiento si dos rangos de tiempo se intersectan.
- Mostrar los conflictos detectados, indicando el rango horario del conflicto y las horas de las citas involucradas.
- Contar el total de conflictos.

**Lógica de detección de conflictos:**
Dos citas tienen conflicto si sus rangos de tiempo se solapan:
```
Cita A: [startA, endA]  donde endA = startA + durationA
Cita B: [startB, endB]  donde endB = startB + durationB

Hay conflicto si: (startA < endB) AND (startB < endA)
```

## Entrada

Dos argumentos por línea de comandos:
1. `startTimes` (string): horas de inicio en formato 24h separadas por comas (ej: "9,12,13,14").
2. `durations` (string): duraciones en horas separadas por comas (ej: "2,1,2,1").

Los dos arrays deben tener la misma longitud. Las citas se etiquetan automáticamente como "Cita A", "Cita B", etc.

## Salida


Para cada conflicto:
```
CONFLICTO: [hora_inicio_conflicto]:00 - [hora_fin_conflicto]:00 | Cita [letra1] ([hora_inicio1]:00 - [hora_fin1]:00) y Cita [letra2] ([hora_inicio2]:00 - [hora_fin2]:00)
```

Al finalizar:
```
Total de conflictos detectados: [N]
```

## Ejemplos


### Ejemplo 1 - Con conflictos
**Entrada:** `9,12,13,14 2,1,2,1`  
**Salida:**
```
CONFLICTO: 14:00 - 15:00 | Cita C (13:00 - 15:00) y Cita D (14:00 - 15:00)
Total de conflictos detectados: 1
```


### Ejemplo 2 - Sin conflictos
**Entrada:** `9,11,13 2,2,2`  
**Salida:**
```
Total de conflictos detectados: 0
```


### Ejemplo 3 - Múltiples conflictos
**Entrada:** `10,10,11,12 2,3,2,1`  
**Salida:**
```
CONFLICTO: 10:00 - 12:00 | Cita A (10:00 - 12:00) y Cita B (10:00 - 13:00)
CONFLICTO: 11:00 - 12:00 | Cita A (10:00 - 12:00) y Cita C (11:00 - 13:00)
CONFLICTO: 11:00 - 13:00 | Cita B (10:00 - 13:00) y Cita C (11:00 - 13:00)
CONFLICTO: 12:00 - 13:00 | Cita B (10:00 - 13:00) y Cita D (12:00 - 13:00)
CONFLICTO: 12:00 - 13:00 | Cita C (11:00 - 13:00) y Cita D (12:00 - 13:00)
Total de conflictos detectados: 5
```

## Notas

- La fórmula de solapamiento `(start1 < end2) AND (start2 < end1)` es un algoritmo clásico de detección de intervalos superpuestos.
- El número total de comparaciones es: `n × (n-1) / 2`
- Utiliza bucles anidados para comparar cada cita con las demás y detectar solapamientos.
- Calcula el horario de fin de cada cita sumando la duración a la hora de inicio.
- Usa letras (A, B, C, ...) para etiquetar las citas en el orden de entrada.
- Lleva un contador para el total de conflictos detectados y muestra el resultado en el formato solicitado.
