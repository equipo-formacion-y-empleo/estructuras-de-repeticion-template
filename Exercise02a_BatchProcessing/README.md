# Exercise02a_BatchProcessing

## Enunciado

Implementar un sistema de procesamiento por lotes (batch processing) que procesa una serie de lotes con tamaños variables. Este patrón simula escenarios reales donde se procesan datos en grupos sucesivos. El bucle do-while garantiza que se procese al menos un lote.

**Comportamiento:**
- Usar un bucle `do-while` para procesar lotes sucesivos.
- Cada lote puede tener diferente tamaño (array `batchSizes`).
- Procesar al menos un lote (característica clave del do-while).
- Para cada lote, mostrar el número de lote y cantidad de items.
- Acumular el total de items procesados.
- Terminar cuando se hayan procesado todos los lotes.

## Entrada

Un argumento por línea de comandos:
1. `batchSizes` (string): tamaños de cada lote separados por comas (ej: "100,200,150").

**Nota:** El número de lotes se determina automáticamente por la longitud del array usando `batchSizes.Length`.

## Salida

Para cada lote procesado:
```
Procesando lote [N]: [tamaño] items
```

Al finalizar:
```
Procesamiento completado. Total: [N] items
```

## Ejemplos

### Ejemplo 1 - Tres lotes con tamaños variables
**Entrada:** `100,200,150`  
**Salida:**
```
Procesando lote 1: 100 items
Procesando lote 2: 200 items
Procesando lote 3: 150 items
Procesamiento completado. Total: 450 items
```

### Ejemplo 2 - Un solo lote
**Entrada:** `100`  
**Salida:**
```
Procesando lote 1: 100 items
Procesamiento completado. Total: 100 items
```

### Ejemplo 3 - Dos lotes grandes
**Entrada:** `100,200`  
**Salida:**
```
Procesando lote 1: 100 items
Procesando lote 2: 200 items
Procesamiento completado. Total: 300 items
```

## Notas

- El bucle `do-while` garantiza que se procese al menos un lote, incluso si solo hay uno.
- Lleva un acumulador para sumar el total de items procesados.
- Recuerda mostrar el número de lote empezando en 1.
- Asegúrate de manejar correctamente el caso de un solo lote.
