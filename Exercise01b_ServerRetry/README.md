# Exercise01b_ServerRetry

## Enunciado

Simular reintentos de conexión a un servidor con espera exponencial (exponential backoff). En cada intento fallido, el tiempo de espera se duplica antes del siguiente intento.

**Comportamiento:**
- Usar un bucle `while` para intentar conectar hasta el máximo de intentos.
- Si el intento actual coincide con el intento de éxito, mostrar mensaje de éxito.
- Si falla, mostrar el intento y el tiempo de espera, luego duplicar el tiempo para el próximo intento.
- Si se agotan todos los intentos sin éxito, mostrar mensaje de fallo total.

## Entrada

Tres argumentos por línea de comandos:
1. `successAttempt` (int): en qué número de intento se logra conectar (0 = nunca).
2. `maxAttempts` (int): número máximo de intentos permitidos.
3. `initialDelay` (int): tiempo de espera inicial en milisegundos.

## Salida

Por cada intento fallido:
```
Intento [N] fallido. Esperando [delay]ms...
```

Si tiene éxito:
```
Conexión exitosa en el intento [N]
```

Si falla todos los intentos:
```
Conexión fallida después de [maxAttempts] intentos
```
(El texto debe decir "intento" si es 1, "intentos" si es más de 1)

## Ejemplos

### Ejemplo 1
**Entrada:** `3 5 1000`  
**Salida:**
```
Intento 1 fallido. Esperando 1000ms...
Intento 2 fallido. Esperando 2000ms...
Conexión exitosa en el intento 3
```

### Ejemplo 2
**Entrada:** `2 3 200`  
**Salida:**
```
Intento 1 fallido. Esperando 200ms...
Conexión exitosa en el intento 2
```

### Ejemplo 3
**Entrada:** `0 3 100`  
**Salida:**
```
Intento 1 fallido. Esperando 100ms...
Intento 2 fallido. Esperando 200ms...
Intento 3 fallido. Esperando 400ms...
Conexión fallida después de 3 intentos
```

### Ejemplo 4
**Entrada:** `6 5 500`  
**Salida:**
```
Intento 1 fallido. Esperando 500ms...
Intento 2 fallido. Esperando 1000ms...
Intento 3 fallido. Esperando 2000ms...
Intento 4 fallido. Esperando 4000ms...
Intento 5 fallido. Esperando 8000ms...
Conexión fallida después de 5 intentos
```

## Notas

- Usa un bucle **WHILE** para gestionar los reintentos.
- El tiempo de espera se duplica en cada intento fallido (1000, 2000, 4000, 8000...).
- Si `successAttempt` es 0, significa que nunca tendrá éxito.
- Controla el número de intentos para no exceder el máximo.
