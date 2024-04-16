\### Paso 1: Configurar la Máquina Virtual de Aplicación (Cliente)

1\. \*\*Instalar Apache y PHP\*\*:

\- En tu máquina virtual de aplicación (la que actuará como cliente), asegúrate de tener instalado Apache y PHP.

\- Utiliza el gestor de paquetes de tu distribución (como \`apt\` en Ubuntu) para instalar estos componentes.

2\. \*\*Habilitar extensiones PHP\*\*:

\- Asegúrate de que la extensión \`mysqli\` esté habilitada en PHP para permitir la conexión a MySQL.

\- Puedes habilitar esta extensión descomentando la línea \`extension=mysqli\` en el archivo de configuración \`php.ini\` y reiniciando Apache.

\### Paso 2: Permitir Conexiones Remotas a MySQL (Servidor)

1\. \*\*Configurar MySQL para conexiones remotas\*\*:

\- En la máquina virtual que aloja la base de datos MySQL (el servidor), asegúrate de que MySQL esté configurado para aceptar conexiones remotas.

\- Editar el archivo de configuración de MySQL (\`/etc/mysql/mysql.conf.d/mysqld.cnf\` en Ubuntu) y asegurarse de que la opción \`bind-address\` esté configurada para escuchar en la dirección IP del servidor (\`0.0.0.0\` para todas las direcciones).

2\. \*\*Crear un usuario remoto en MySQL\*\*:

\- Accede a MySQL desde la línea de comandos (\`mysql -u root -p\`) en el servidor.

\- Crea un nuevo usuario y otórgale privilegios adecuados para acceder desde la dirección IP de tu máquina virtual de aplicación:

\`\`\`sql

CREATE USER 'tu_usuario'@'ip_de_tu_cliente' IDENTIFIED BY 'tu_contraseña';

GRANT ALL PRIVILEGES ON tu_base_de_datos.\* TO 'tu_usuario'@'ip_de_tu_cliente';

FLUSH PRIVILEGES;

\`\`\`

\### Paso 3: Conexión desde PHP a MySQL (Cliente)

1\. \*\*Crear el script PHP\*\*:

\- Crea un archivo PHP en tu máquina virtual de aplicación para conectar y realizar consultas a la base de datos remota.

\- Utiliza la función \`mysqli_connect\` de PHP para establecer la conexión remota a MySQL:

\`\`\`php

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

$sql = 'SELECT \* FROM tabla_ejemplo';

$result = $conn->query($sql);

// Procesar los resultados

if ($result->num_rows > 0) {

while ($row = $result->fetch_assoc()) {

echo 'ID: ' . $row\['id'\] . ' - Nombre: ' . $row\['nombre'\] . '&lt;br&gt;';

}

} else {

echo 'No se encontraron resultados.';

}

// Cerrar la conexión

$conn->close();

?>

\`\`\`

2\. \*\*Ejecutar el script\*\*:

\- Coloca este archivo PHP en el directorio adecuado de tu servidor web Apache (\`/var/www/html/\` en Ubuntu).

\- Accede al script desde un navegador en tu máquina virtual de aplicación para ejecutarlo y ver los resultados de la consulta a la base de datos remota.

Siguiendo estos pasos, podrás conectar tu aplicación PHP en una máquina virtual a una base de datos MySQL que se encuentra en otra máquina virtual distinta. Asegúrate de configurar correctamente la red y las reglas de firewall para permitir la comunicación entre las dos máquinas virtuales.
