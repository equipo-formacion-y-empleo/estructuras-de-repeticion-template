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

Por cada servicio en estado crítico, mostrar una línea:
`ALERTA: Servicio N en estado crítico con X camas (< umbral)`

Al final, mostrar:
1. `Capacidad total del hospital: X camas` - Total de camas disponibles
2. `Servicios en estado crítico: Y de Z (P%)` - Cantidad y porcentaje de servicios críticos

## Ejemplos


### Ejemplo 1
**Entrada:** `dotnet run "25,8,15,3,50" "10"`

**Salida esperada:**
```
ALERTA: Servicio 2 en estado crítico con 8 camas (< 10)
ALERTA: Servicio 4 en estado crítico con 3 camas (< 10)
Capacidad total del hospital: 101 camas
Servicios en estado crítico: 2 de 5 (40%)
```


### Ejemplo 2
**Entrada:** `dotnet run "20,30,25,40" "10"`

**Salida esperada:**
```
Capacidad total del hospital: 115 camas
Servicios en estado crítico: 0 de 4 (0%)
```


### Ejemplo 3
**Entrada:** `dotnet run "2,5,3,8" "10"`

**Salida esperada:**
```
ALERTA: Servicio 1 en estado crítico con 2 camas (< 10)
ALERTA: Servicio 2 en estado crítico con 5 camas (< 10)
ALERTA: Servicio 3 en estado crítico con 3 camas (< 10)
ALERTA: Servicio 4 en estado crítico con 8 camas (< 10)
Capacidad total del hospital: 18 camas
Servicios en estado crítico: 4 de 4 (100%)
```


### Ejemplo 4
**Entrada:** `dotnet run "15" "10"`

**Salida esperada:**
```
Capacidad total del hospital: 15 camas
Servicios en estado crítico: 0 de 1 (0%)
```

### Ejemplo 5
**Entrada:** `dotnet run "15" "10"`

**Salida esperada:**
```
Capacidad total del hospital: 15 camas
Servicios en estado crítico: 0
```


### Ejemplo 5
**Entrada:** `dotnet run "10,20,30,40,50" "25"`

**Salida esperada:**
```
ALERTA: Servicio 1 en estado crítico con 10 camas (< 25)
ALERTA: Servicio 2 en estado crítico con 20 camas (< 25)
Capacidad total del hospital: 150 camas
Servicios en estado crítico: 2 de 5 (40%)
```


## Notas

- El bucle `foreach` te permite recorrer cada servicio fácilmente.
- Lleva un acumulador para la suma total de camas y un contador para los servicios críticos.
- Compara cada valor con el umbral para determinar si es crítico y muestra una alerta por cada uno.
- Al final, muestra estadísticas claras sobre la capacidad y los servicios críticos.
- Asegúrate de mostrar los resultados en el formato solicitado.
