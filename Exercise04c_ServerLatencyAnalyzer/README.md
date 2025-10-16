# Exercise04c_ServerLatencyAnalyzer

## Enunciado

Implementar un analizador de latencia de servidores que procesa una lista de tiempos de respuesta de red en milisegundos (ms), clasifica cada latencia según rangos de calidad, y genera estadísticas sobre la distribución de conexiones excelentes, aceptables y lentas. El bucle `FOREACH` permite iterar sobre cada medición de forma clara y directa.

**Clasificación de latencia:**
- **Excelente**: < 10ms (conexión local/óptima)
- **Aceptable**: 10ms - 25ms (conexión normal)
- **Lenta**: > 25ms (conexión degradada)

**Comportamiento:**
- Usar un bucle `foreach` para procesar cada latencia.
- Clasificar la latencia según los rangos definidos.
- Mostrar cada latencia con su clasificación.
- Contar latencias por categoría.
- Mostrar resumen estadístico final.

## Entrada

Un argumento por línea de comandos:
1. `latencies` (string): lista de latencias en ms separadas por comas (ej: "5,15,30,0,20").

## Salida

Para cada latencia:
```
Xms - Clasificación
```

Al finalizar:
```
Resumen: A excelentes, B aceptables, C lentas
```

## Ejemplos

### Ejemplo 1 - Latencias variadas
**Entrada:** `dotnet run "5,15,30,0,20"`

**Salida esperada:**
```
5ms - Excelente
15ms - Aceptable
30ms - Lenta
0ms - Excelente
20ms - Aceptable
Resumen: 2 excelentes, 2 aceptables, 1 lentas
```

### Ejemplo 2
**Entrada:** `dotnet run "0,5,5,8"`

**Salida esperada:**
```
0ms - Excelente
5ms - Excelente
5ms - Excelente
8ms - Excelente
Resumen: 4 excelentes, 0 aceptables, 0 lentas
-5ms - Excelente
8ms - Excelente
Resumen: 4 excelentes, 0 aceptables, 0 lentas
```

### Ejemplo 3 - Todas las latencias lentas
**Entrada:** `dotnet run "26,30,35,40"`

**Salida esperada:**
```
26ms - Lenta
30ms - Lenta
35ms - Lenta
40ms - Lenta
Resumen: 0 excelentes, 0 aceptables, 4 lentas
```

### Ejemplo 4 - Una sola latencia
**Entrada:** `dotnet run "20"`

**Salida esperada:**
```
20ms - Aceptable
Resumen: 0 excelentes, 1 aceptables, 0 lentas
```

### Ejemplo 5 - Latencias en los límites exactos
**Entrada:** `dotnet run "10,25"`

**Salida esperada:**
```
10ms - Aceptable
25ms - Aceptable
Resumen: 0 excelentes, 2 aceptables, 0 lentas
```

### Ejemplo 6 - Latencias mixtas
**Entrada:** `dotnet run "9,10,25,26"`

**Salida esperada:** 
```
9ms - Excelente
10ms - Aceptable
25ms - Aceptable
26ms - Lenta
Resumen: 1 excelentes, 2 aceptables, 1 lentas
```

## Notas

- Utiliza condicionales para clasificar cada latencia según los rangos dados.
- Lleva contadores para cada tipo de clasificación (excelente, aceptable, lenta).
- Muestra el resumen final en el formato solicitado.