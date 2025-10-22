# Exercise04b_HospitalBedMonitor

## Enunciado

Implementar un sistema de monitoreo de disponibilidad de camas hospitalarias que procesa una lista de camas disponibles por servicio, detecta servicios con capacidad crítica según un umbral definido, y genera un informe con el total de camas disponibles y la cantidad de servicios en estado crítico. El bucle `FOREACH` permite iterar sobre la colección de manera clara y simple.

**Comportamiento:**
- Usar un bucle `foreach` para procesar cada servicio.
- Sumar todas las camas disponibles para calcular capacidad total.
- Contar cuántos servicios están por debajo del umbral (crítico).
- Mostrar la capacidad total y la cantidad de servicios críticos.

## Entrada

Dos argumentos por línea de comandos:
1. `bedsByService` (string): lista de camas disponibles por servicio separadas por comas (ej: "25,8,15,3,50").
2. `criticalThreshold` (int): umbral mínimo de camas por servicio (ej: 10).

## Salida

Dos líneas de salida:
1. `Capacidad total del hospital: X camas` - Total de camas disponibles
2. `Servicios en estado crítico: Y` - Cantidad de servicios con camas < umbral

## Ejemplo de uso

```bash
dotnet run "25,8,15,3,50" "10"
```

**Salida esperada:**
```
Capacidad total del hospital: 101 camas
Servicios en estado crítico: 2
```

## Casos de prueba adicionales

### Caso 2: Todos los servicios con capacidad suficiente
```bash
dotnet run "20,30,25,40" "10"
```

**Salida esperada:**
```
Capacidad total del hospital: 115 camas
Servicios en estado crítico: 0
```

*Interpretación: Hospital con buena disponibilidad, sin alertas*

### Caso 3: Todos los servicios en estado crítico
```bash
dotnet run "2,5,3,8" "10"
```

**Salida esperada:**
```
Capacidad total del hospital: 18 camas
Servicios en estado crítico: 4
```

*Interpretación: Hospital saturado, necesita redistribución o activar plan de contingencia*

### Caso 4: Un solo servicio
```bash
dotnet run "15" "10"
```

**Salida esperada:**
```
Capacidad total del hospital: 15 camas
Servicios en estado crítico: 0
```

### Caso 5: Umbral alto (hospital especializado)
```bash
dotnet run "10,20,30,40,50" "25"
```

**Salida esperada:**
```
Capacidad total del hospital: 150 camas
Servicios en estado crítico: 2
```
