# Exercise04a_SalesCommission

## Enunciado

Calcular el total de comisiones de ventas. Cada venta genera una comisión del 5%. Usar `foreach` para iterar sobre el array de ventas.

**Comportamiento:**
- Usar un bucle `foreach` para recorrer todas las ventas.
- Calcular el 5% de cada venta y sumar al total de comisiones.
- Mostrar el total de comisiones al final.

## Entrada

Un argumento por línea de comandos:
1. `sales` (string): lista separada por comas de valores de ventas.

## Salida

```
Comisión total: [total]
```

## Ejemplos

### Ejemplo 1
**Entrada:** `1000,1500,2000,2500,3000`  
**Salida:**
```
Comisión total: 500
```

### Ejemplo 2
**Entrada:** `500,750,1250`  
**Salida:**
```
Comisión total: 125
```

### Ejemplo 3
**Entrada:** `10000`  
**Salida:**
```
Comisión total: 500
```

## Notas

- Usa un bucle **FOREACH** para iterar sobre las ventas.
- La comisión es siempre el 5% de cada venta.
- Formato de salida: "Comisión total: " seguido del importe.
- No modifiques el array original.
- Todas las ventas y comisiones se manejan como números enteros.
