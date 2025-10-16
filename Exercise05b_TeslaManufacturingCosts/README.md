# Exercise05b_TeslaManufacturingCosts

## Enunciado

Implementar un calculador de matriz de costos de producción de **Tesla** que calcula el costo de fabricar múltiples modelos de vehículos en múltiples Gigafactorias. Los bucles anidados permiten generar todas las combinaciones de modelo × fábrica.

**Comportamiento:**
- Usar bucles **anidados** para generar la matriz de costos.
- Bucle exterior: iterar sobre modelos de vehículos.
- Bucle interior: iterar sobre Gigafactorias para cada modelo.
- Calcular costo de producción: `costo base fábrica + (tiempo ensamblaje × 2.0)`
- Mostrar información organizada por modelo.
- Calcular y mostrar el costo total de fabricar todos los modelos en todas las fábricas.

**Fórmula de costo:**
```
Costo de producción = baseRate[fábrica] + (assemblyTime × 2.0)
```

## Entrada

Dos argumentos por línea de comandos:
1. `factoryBaseCosts` (string): costos base por Gigafactoría separados por comas (ej: "5,7,6" miles $).
2. `modelAssemblyTimes` (string): tiempos de ensamblaje por modelo en horas separados por comas (ej: "3,1" horas).

Los modelos se etiquetan como "Modelo 1", "Modelo 2", etc. Las fábricas se etiquetan como "Gigafactoría 1", "Gigafactoría 2", etc.

## Salida

Para cada modelo:
```
Modelo [N] ([tiempo]h):
  Gigafactoría [M]: $[costo]k
  ...
```

Al finalizar:
```
Costo total de producción: $[total]k
```

## Ejemplos

### Ejemplo 1 - Dos modelos en tres Gigafactorias
**Entrada:** `5,7,6 3,1`  
**Salida:**
```
Modelo 1 (3h):
  Gigafactoría 1: $11k
  Gigafactoría 2: $13k
  Gigafactoría 3: $12k
Modelo 2 (1h):
  Gigafactoría 1: $7k
  Gigafactoría 2: $9k
  Gigafactoría 3: $8k
Costo total de producción: $60k
```

### Ejemplo 2 - Un modelo en dos fábricas
**Entrada:** `10,15 5`  
**Salida:**
```
Modelo 1 (5h):
  Gigafactoría 1: $20k
  Gigafactoría 2: $25k
Costo total de producción: $45k
```

### Ejemplo 3 - Tres modelos en tres fábricas
**Entrada:** `5,10,15 2,3,1`  
**Salida:**
```
Modelo 1 (2h):
  Gigafactoría 1: $9k
  Gigafactoría 2: $14k
  Gigafactoría 3: $19k
Modelo 2 (3h):
  Gigafactoría 1: $11k
  Gigafactoría 2: $16k
  Gigafactoría 3: $21k
Modelo 3 (1h):
  Gigafactoría 1: $7k
  Gigafactoría 2: $12k
  Gigafactoría 3: $17k
Costo total de producción: $126k
```

## Notas

- Utiliza bucles anidados para recorrer modelos y fábricas.
- Aplica la fórmula de costo correctamente para cada combinación.
- Lleva un acumulador para el costo total.
- Muestra los resultados en el formato solicitado, usando etiquetas para modelos y fábricas.
