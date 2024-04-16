###CLASE 1

<h1>Instalación de Apache y Configuración de LAMP en Linux</h1>
Instalación de Apache
Para instalar Apache en Linux y configurar un entorno LAMP (Linux, Apache, MySQL, y PHP/Perl/Python), sigue estos pasos:

<h2>1. Instalación de Apache</h2>
En distribuciones basadas en Debian (como Ubuntu):

```
bash
sudo apt update
sudo apt install apache2
```

En distribuciones basadas en Red Hat (como CentOS o Fedora):

```bash
sudo yum update
sudo yum install httpd
```
<h2>2. Verificar el Estado de Apache</h2>
Después de la instalación, verifica que Apache esté en ejecución:
```
bash
sudo systemctl status apache2   # En sistemas basados en Debian
sudo systemctl status httpd     # En sistemas basados en Red Hat
```
<h2>3. Configuración de la Capa de Datos MySQL</h2>
Instalación de MySQL
Instala el servidor MySQL en tu sistema:

```
bash
sudo apt install mysql-server    # En sistemas basados en Debian
sudo yum install mysql-server    # En sistemas basados en Red Hat
```
Iniciar y Habilitar MySQL
Inicia el servicio MySQL y habilita su inicio automático:

```
bash
sudo systemctl start mysql
sudo systemctl enable mysql
```
<h2>4. Conectar Apache a MySQL (usando PHP como ejemplo)</h2>
Para conectar tu aplicación web (HTML, CSS, JavaScript) a MySQL a través de Apache, puedes usar PHP como puente. Instala PHP y el módulo de MySQL para PHP:

```
bash
sudo apt install php libapache2-mod-php php-mysql    # En sistemas basados en Debian
sudo yum install php php-mysql                        # En sistemas basados en Red Hat
```
<h2>5. Reiniciar Apache</h2>
Después de instalar PHP, reinicia Apache para que los cambios surtan efecto:
```
bash
sudo systemctl restart apache2   # En sistemas basados en Debian
sudo systemctl restart httpd     # En sistemas basados en Red Hat
```
Configuración Completa de LAMP
Una vez completados estos pasos, tendrás un entorno LAMP totalmente funcional en tu sistema Linux, listo para desarrollar aplicaciones web utilizando HTML, CSS, JavaScript, y conectándote a una base de datos MySQL mediante PHP (o Perl/Python si prefieres).

Recuerda adaptar los comandos según la distribución específica de Linux que estés utilizando. Este es un ejemplo generalizado que debería funcionar en la mayoría de las distribuciones basadas en Debian o Red Hat.


###CLASE 2

Claro, aquí está la información organizada en una tabla en formato markdown:

| **Por Tareas**         | **Característica**                                       | **Ejemplos**                                       |
|------------------------|----------------------------------------------------------|----------------------------------------------------|
| **SO - Monotareas**    | Permite ejecutar una sola tarea a la vez.                | MS-DOS, CP/M, SOS (Sophisticated Operating System), RT-11, TOPS-10 |
| **SO - Multitareas**   | Permite la ejecución simultánea de múltiples tareas.     | Windows, macOS, Linux, Unix, Android               |

<hr>

| **Por Usuarios**       | **Característica**                                       | **Ejemplos**                                       |
|------------------------|----------------------------------------------------------|----------------------------------------------------|
| **SO - Monousuarios**  | Diseñado para un solo usuario.                           | MS-DOS, Windows 3.1, Macintosh System Software, Classic Mac OS, Palm OS |
| **SO - Multiusuarios**  | Permite múltiples usuarios simultáneamente.              | Unix, Linux, Windows Server, macOS Server, AIX      |

<hr>

| **Por Hardware**       | **Característica**                                       | **Ejemplos**                                       |
|------------------------|----------------------------------------------------------|----------------------------------------------------|
| **Mainframe**          | Potente y diseñado para manejar grandes cantidades de datos. | IBM z/OS, Unisys MCP, Fujitsu BS2000, Hitachi VOS3, NEC ACOS |
| **Servidor**           | Proporciona servicios a otras computadoras en la red.    | Windows Server, Linux (como servidor), Apache HTTP Server, Nginx, Microsoft Exchange Server |
| **Supercomputadora**   | Alto rendimiento para cálculos científicos intensivos.   | IBM Summit, Fujitsu Fugaku, Cray XC40, HP Apollo, Tianhe-2 |
| **SO de Tiempo Real**  | Responde a entradas dentro de un límite de tiempo definido. | VxWorks, QNX, FreeRTOS, RTLinux, Windows Embedded Compact |
| **SO de Computador Personal** | Diseñado para uso en computadoras personales.         | Windows, macOS, Linux (distros de escritorio), Chrome OS, Ubuntu |
| **SO Embedded**        | Integrado en dispositivos específicos (incorporado).    | Android, iOS, Windows Embedded, Embedded Linux, VxWorks |
| **SO de Tarjeta**      | Sistema operativo implementado en tarjetas embebidas.   | Arduino OS, MicroPython, Mbed OS, FreeRTOS (para microcontroladores), Contiki |

Esta tabla presenta una estructura clara y organizada para comprender los diferentes tipos de sistemas operativos según sus características y ejemplos asociados.

### Procesos
En la gestión de procesos, el comando comúnmente utilizado para ver la lista de procesos en sistemas tipo Unix/Linux es `ps -eaf`:
- `ps`: Muestra información sobre los procesos en ejecución.
- `-e`: Muestra información sobre todos los procesos.
- `-a`: Muestra los procesos de todos los usuarios.
- `-f`: Muestra información detallada de cada proceso.

Por ejemplo:
```bash
ps -eaf
```
Este comando muestra una lista detallada de todos los procesos en ejecución en el sistema.

### Archivos
En la manipulación de archivos, algunos comandos útiles incluyen:
- `cp`: Copia archivos o directorios.
- `mv`: Mueve (cambia el nombre de) archivos o directorios.
- `rm`: Elimina (borra) archivos o directorios.

Por ejemplo:
```bash
cp archivo.txt carpeta/
mv archivo.txt nuevo_nombre.txt
rm archivo.txt
```
Estos comandos son utilizados para realizar operaciones básicas de copiado, movimiento y eliminación de archivos en el sistema de archivos.

### Espacio de Direcciones
Para monitorear el espacio de direcciones y la memoria en el sistema, puedes utilizar comandos como:
- `top`: Muestra una lista dinámica de los procesos en ejecución y la utilización de recursos del sistema.
- `free -m`: Muestra la cantidad de memoria RAM disponible en el sistema en megabytes.

Por ejemplo:
```bash
top
free -m
```
Estos comandos son útiles para verificar el uso de CPU, memoria y otros recursos del sistema.

### Protección
Para administrar permisos y protección de archivos en sistemas Unix/Linux, se utilizan comandos como:
- `chmod`: Cambia los permisos de acceso a archivos o directorios.
- `chown`: Cambia el propietario y/o grupo de archivos o directorios.
- `rwx`: Nos permite saber si el archivo se puede Leer (read), Escribir (write), Ejecutar (Execute)
Por ejemplo:
```bash
chmod 755 archivo.sh
chown usuario1 archivo.txt
```
Estos comandos son utilizados para controlar quién puede acceder, modificar o ejecutar archivos y directorios en el sistema.

### Shell
En cuanto a las interfaces de shell (intérpretes de comandos), algunos ejemplos comunes son:
- `sh`: Shell estándar (Bourne shell).
- `csh`: C shell.
- `ksh`: Korn shell.
- `bash`: Bourne Again shell (shell más comúnmente utilizado en sistemas Unix/Linux).

Por ejemplo:
```bash
sh script.sh
csh
ksh
bash
```
Estos son diferentes tipos de shells que proporcionan entornos interactivos para ejecutar comandos y scripts en el sistema operativo.

Espero que esta explicación en formato markdown te haya sido útil para comprender mejor estos conceptos y comandos relacionados con los sistemas operativos Unix/Linux.

