# Exercise03a_MonthlyReports

## Enunciado

Generar reportes mensuales de ventas para un año completo. Usar un bucle `for` para iterar exactamente 12 veces (una por cada mes).

**Comportamiento:**
- Usar un bucle `for`.
- Para cada iteración, generar un reporte con el nombre del mes y unidades vendidas.
- Al finalizar los 12 meses, mostrar el total acumulado.

## Entrada

Un argumento por línea de comandos:
1. `monthlyData` (string): lista separada por comas con 12 valores (unidades por mes).

## Salida

Por cada mes:
```
Reporte [NombreMes]: [unidades] unidades
```

Al final:
```
Total: [total] unidades
```

## Ejemplos

### Ejemplo 1
**Entrada:** `1200,1500,1300,1400,1600,1550,1700,1650,1800,1750,1900,2000`  
**Salida:**
```
Reporte Enero: 1200 unidades
Reporte Febrero: 1500 unidades
Reporte Marzo: 1300 unidades
Reporte Abril: 1400 unidades
Reporte Mayo: 1600 unidades
Reporte Junio: 1550 unidades
Reporte Julio: 1700 unidades
Reporte Agosto: 1650 unidades
Reporte Septiembre: 1800 unidades
Reporte Octubre: 1750 unidades
Reporte Noviembre: 1900 unidades
Reporte Diciembre: 2000 unidades
Total: 19350 unidades
```

### Ejemplo 2
**Entrada:** `1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000,1000`  
**Salida:**
```
Reporte Enero: 1000 unidades
Reporte Febrero: 1000 unidades
Reporte Marzo: 1000 unidades
Reporte Abril: 1000 unidades
Reporte Mayo: 1000 unidades
Reporte Junio: 1000 unidades
Reporte Julio: 1000 unidades
Reporte Agosto: 1000 unidades
Reporte Septiembre: 1000 unidades
Reporte Octubre: 1000 unidades
Reporte Noviembre: 1000 unidades
Reporte Diciembre: 1000 unidades
Total: 12000 unidades
```

## Notas

- Utiliza un array con los nombres de los meses para mostrar el reporte correctamente.
- Lleva un acumulador para sumar el total de unidades vendidas.
- El bucle `for` debe iterar exactamente 12 veces, una por cada mes.
- Asegúrate de que la entrada tenga 12 valores, uno por cada mes.
