### Paso 1: Configurar la Máquina Virtual de Aplicación (Cliente)

1. **Instalar Apache y PHP**:
   - En tu máquina virtual de aplicación (la que actuará como cliente), asegúrate de tener instalado Apache y PHP.
   - Utiliza el gestor de paquetes de tu distribución (como `apt` en Ubuntu) para instalar estos componentes.

2. **Habilitar extensiones PHP**:
   - Asegúrate de que la extensión `mysqli` esté habilitada en PHP para permitir la conexión a MySQL.
   - Puedes habilitar esta extensión descomentando la línea `extension=mysqli` en el archivo de configuración `php.ini` y reiniciando Apache.

### Paso 2: Permitir Conexiones Remotas a MySQL (Servidor)

1. **Configurar MySQL para conexiones remotas**:
   - En la máquina virtual que aloja la base de datos MySQL (el servidor), asegúrate de que MySQL esté configurado para aceptar conexiones remotas.
   - Editar el archivo de configuración de MySQL (`/etc/mysql/mysql.conf.d/mysqld.cnf` en Ubuntu) y asegurarse de que la opción `bind-address` esté configurada para escuchar en la dirección IP del servidor (`0.0.0.0` para todas las direcciones).

2. **Crear un usuario remoto en MySQL**:
   - Accede a MySQL desde la línea de comandos (`mysql -u root -p`) en el servidor.
   - Crea un nuevo usuario y otórgale privilegios adecuados para acceder desde la dirección IP de tu máquina virtual de aplicación:
   - 
     ```sql
     CREATE USER 'tu_usuario'@'ip_de_tu_cliente' IDENTIFIED BY 'tu_contraseña';
     GRANT ALL PRIVILEGES ON tu_base_de_datos.* TO 'tu_usuario'@'ip_de_tu_cliente';
     FLUSH PRIVILEGES;
     ```

### Paso 3: Conexión desde PHP a MySQL (Cliente)

1. **Crear el script PHP**:
   - Crea un archivo PHP en tu máquina virtual de aplicación para conectar y realizar consultas a la base de datos remota.
   - Utiliza la función `mysqli_connect` de PHP para establecer la conexión remota a MySQL:
   - 
     ```php
     <?php
     $servername = 'ip_de_tu_servidor_mysql';
     $username = 'tu_usuario';
     $password = 'tu_contraseña';
     $database = 'tu_base_de_datos';

     // Establecer la conexión
     $conn = new mysqli($servername, $username, $password, $database);

     // Verificar la conexión
     if ($conn->connect_error) {
         die('Error de conexión: ' . $conn->connect_error);
     }

     // Ejemplo de consulta SQL
     $sql = 'SELECT * FROM tabla_ejemplo';
     $result = $conn->query($sql);

     // Procesar los resultados
     if ($result->num_rows > 0) {
         while ($row = $result->fetch_assoc()) {
             echo 'ID: ' . $row['id'] . ' - Nombre: ' . $row['nombre'] . '<br>';
         }
     } else {
         echo 'No se encontraron resultados.';
     }

     // Cerrar la conexión
     $conn->close();
     ?>
     ```

2. **Ejecutar el script**:
   - Coloca este archivo PHP en el directorio adecuado de tu servidor web Apache (`/var/www/html/` en Ubuntu).
   - Accede al script desde un navegador en tu máquina virtual de aplicación para ejecutarlo y ver los resultados de la consulta a la base de datos remota.

Siguiendo estos pasos, podrás conectar tu aplicación PHP en una máquina virtual a una base de datos MySQL que se encuentra en otra máquina virtual distinta. Asegúrate de configurar correctamente la red y las reglas de firewall para permitir la comunicación entre las dos máquinas virtuales.




Vamos a revisar cada línea de tu sesión para entender lo que hiciste y por qué puedes estar experimentando problemas:

1. ```bash
   pwd
   ```

   Este comando muestra el directorio actual en el que te encuentras. En tu caso, estás en el directorio `/var/www/html`.

2. ```bash
   ls -lhrt
   ```

   Este comando lista los archivos y directorios en el directorio actual (`/var/www/html`) de forma detallada, ordenados por la fecha y hora de modificación en orden ascendente (de más antiguo a más reciente).

   - `-rw-r--r-- 1 root root 11K Apr 16 01:33 index.html.orig`: Este archivo (`index.html.orig`) es propiedad del usuario `root` y del grupo `root`, con permisos de lectura y escritura para el propietario (`root`) y solo lectura para el grupo y otros usuarios.
   - `-rw-r--r-- 1 root root  10 Apr 16 01:38 index.html`: Este archivo (`index.html`) también es propiedad del usuario `root` y del grupo `root`, con permisos de lectura y escritura para el propietario (`root`) y solo lectura para el grupo y otros usuarios.

3. ```bash
   sudo chmod 777 index.html
   ```

   Aquí estás intentando cambiar los permisos del archivo `index.html` para que sea completamente accesible (lectura, escritura y ejecución) por todos los usuarios. El modo `777` significa que todos los permisos (lectura, escritura y ejecución) están habilitados para el propietario, el grupo y otros usuarios.

4. ```bash
   sudo echo "Hola" > index.html
   ```

   En esta línea, estás intentando utilizar `sudo` para ejecutar el comando `echo "Hola"` y redirigir la salida (`>`) al archivo `index.html`. Sin embargo, es probable que esta parte del comando falle debido a un problema común con el uso de `sudo` y redirección en la línea de comandos.

   El problema radica en cómo se interpreta el comando por la shell:
   - La redirección (`> index.html`) se realiza antes de que `sudo` tome efecto.
   - Por lo tanto, la redirección es ejecutada por tu usuario actual, no por `sudo`.

### Solución

Para redirigir la salida correctamente al archivo `index.html` con privilegios de `sudo`, puedes usar uno de los siguientes métodos que te mencioné previamente:

#### Método 1: Usar `sudo tee`

```bash
echo "Hola" | sudo tee index.html
```

Explicación:
- `echo "Hola"`: Imprime el texto en la salida estándar.
- `|`: Canaliza la salida del comando anterior como entrada para el siguiente comando.
- `sudo tee index.html`: `tee` lee desde la entrada estándar y escribe en el archivo especificado (`index.html`) con permisos de superusuario (`sudo`).

#### Método 2: Ejecutar todo el comando con `sudo bash -c`

```bash
sudo bash -c 'echo "Hola" > index.html'
```

Explicación:
- `sudo bash -c '...'`: Ejecuta el comando (`echo "Hola" > index.html`) como una cadena de comandos dentro de una nueva instancia de shell con privilegios de superusuario.

Usa cualquiera de estos métodos para escribir en `index.html` con los permisos adecuados. Esto debería resolver el problema que estás experimentando al intentar escribir en un archivo con `sudo`.
