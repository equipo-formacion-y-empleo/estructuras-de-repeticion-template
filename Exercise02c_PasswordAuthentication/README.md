# Exercise02c_PasswordAuthentication

Implementar un sistema de autenticación con contraseña que permite múltiples intentos antes de bloquear el acceso. Este patrón es común en sistemas de seguridad donde se debe verificar las credenciales al menos una vez y continuar hasta autenticar exitosamente o agotar los intentos permitidos. El bucle do-while garantiza que se intente la autenticación al menos una vez.

**Comportamiento:**
- Usar un bucle `do-while` para procesar intentos de autenticación.
- Verificar cada intento contra la contraseña correcta.
- Mostrar el número de intento actual y el resultado.
- Si falla, mostrar intentos restantes (excepto en el último intento).
- Detener cuando: (1) la contraseña es correcta, (2) se agotan los intentos, o (3) no hay más intentos en el array.
- Si se agotan los intentos sin éxito, bloquear la cuenta.

## Entrada

Tres argumentos por línea de comandos:
1. `correctPassword` (string): contraseña correcta del sistema (ej: "SecurePass123").
2. `attempts` (string): intentos de contraseña separados por comas (ej: "password,Pass123,SecurePass123").
3. `maxAttempts` (int): número máximo de intentos permitidos (ej: "3").

## Salida

Para cada intento:
```
Intento [N]: Contraseña incorrecta. [X] intentos restantes
```
O (último intento incorrecto, sin mostrar restantes):
```
Intento [N]: Contraseña incorrecta
```

Si se correcta:
```
Intento [N]: Contraseña correcta
Acceso concedido
```

Si se agotan los intentos:
```
Cuenta bloqueada por exceder intentos máximos
```

## Ejemplos

### Ejemplo 1 - Autenticación exitosa en tercer intento
**Entrada:** `SecurePass123 password,Pass123,SecurePass123 3`  
**Salida:**
```
Intento 1: Contraseña incorrecta. 2 intentos restantes
Intento 2: Contraseña incorrecta. 1 intentos restantes
Intento 3: Contraseña correcta
Acceso concedido
```

### Ejemplo 2 - Cuenta bloqueada
**Entrada:** `Admin2024 admin,admin123,password123 3`  
**Salida:**
```
Intento 1: Contraseña incorrecta. 2 intentos restantes
Intento 2: Contraseña incorrecta. 1 intentos restantes
Intento 3: Contraseña incorrecta
Cuenta bloqueada por exceder intentos máximos
```

### Ejemplo 3 - Autenticación inmediata
**Entrada:** `MyPass admin,MyPass,other 5`  
**Salida:**
```
Intento 1: Contraseña incorrecta. 4 intentos restantes
Intento 2: Contraseña correcta
Acceso concedido
```

### Ejemplo 4 - Cinco intentos, éxito en el quinto
**Entrada:** `Secret999 a,b,c,d,Secret999 5`  
**Salida:**
```
Intento 1: Contraseña incorrecta. 4 intentos restantes
Intento 2: Contraseña incorrecta. 3 intentos restantes
Intento 3: Contraseña incorrecta. 2 intentos restantes
Intento 4: Contraseña incorrecta. 1 intentos restantes
Intento 5: Contraseña correcta
Acceso concedido
```

## Notas

- El bucle `do-while` permite al menos un intento de autenticación.
- Lleva la cuenta de los intentos restantes y muestra el mensaje adecuado.
- Recuerda comparar cada intento con la contraseña correcta usando igualdad de strings.
- Asegúrate de manejar correctamente el caso en que se agotan los intentos.
