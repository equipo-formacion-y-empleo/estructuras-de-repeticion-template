# Exercise03c_StreamRevenue

## Enunciado

Implementar una calculadora de puntos de engagement para una plataforma de streaming que procesa los puntos ganados en múltiples sesiones de streaming considerando el número de interacciones (mensajes de chat) y la duración de cada stream. El bucle `for` permite iterar sobre un número conocido de streams.

**Comportamiento:**
- Usar un bucle `for` para procesar cada sesión de streaming.
- Para cada stream, calcular puntos basados en mensajes de chat por hora × duración.
- Si la duración excede 4 horas, aplicar multiplicador de 1.5× para las horas adicionales.
- Mostrar información detallada de cada stream.
- Calcular y mostrar los puntos totales de engagement de todas las sesiones.

**Cálculo de multiplicador por stream largo:**
- Horas regulares: primeras 4 horas con multiplicador estándar (1×)
- Horas extendidas: horas por encima de 4 con multiplicador de 1.5×

## Entrada

Dos argumentos por línea de comandos:
1. `chatMessagesPerHour` (string): mensajes de chat por hora en cada stream separados por comas (ej: "15,20,18,25").
2. `streamDuration` (string): duración en horas de cada stream separadas por comas (ej: "4,5,3,6").

Ambos arrays deben tener la misma longitud.

## Salida

Para cada stream:
```
Stream [N]: [puntos]
```

Al finalizar:
```
Puntos totales: [total]
```

## Ejemplos

### Ejemplo 1 - Streams con y sin multiplicador por duración
**Entrada:** `15,20,18,25 4,5,3,6`  
**Salida:**
```
Stream 1: 60
Stream 2: 110
Stream 3: 54
Stream 4: 175
Puntos totales: 399
```

### Ejemplo 2 - Todos streams cortos (sin multiplicador extra)
**Entrada:** `12,15 4,3`  
**Salida:**
```
Stream 1: 48
Stream 2: 45
Puntos totales: 93
```

### Ejemplo 3 - Todos streams largos (con multiplicador)
**Entrada:** `20,25 6,8`  
**Salida:**
```
Stream 1: 140
Stream 2: 250
Puntos totales: 390
```

## Notas

- Verifica que ambos arrays tengan la misma longitud antes de procesar.
- Aplica el multiplicador de 1.5× solo a las horas que excedan 4 en cada stream.
- Lleva un acumulador para sumar los puntos totales.
- Muestra la información de cada stream en el formato solicitado.
