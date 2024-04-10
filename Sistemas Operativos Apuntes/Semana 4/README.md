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

### Por Tareas

**SO - Monotareas**
- *Característica*: Permite ejecutar una sola tarea a la vez.
- *Ejemplos*:
  - MS-DOS
  - CP/M
  - SOS (Sophisticated Operating System)
  - RT-11
  - TOPS-10

**SO - Multitareas**
- *Característica*: Permite la ejecución simultánea de múltiples tareas.
- *Ejemplos*:
  - Windows
  - macOS
  - Linux
  - Unix
  - Android

### Por Usuarios

**SO - Monousuarios**
- *Característica*: Diseñado para un solo usuario.
- *Ejemplos*:
  - MS-DOS
  - Windows 3.1
  - Macintosh System Software
  - Classic Mac OS
  - Palm OS

**SO - Multiusuarios**
- *Característica*: Permite múltiples usuarios simultáneamente.
- *Ejemplos*:
  - Unix
  - Linux
  - Windows Server
  - macOS Server
  - AIX

### Por Hardware

**Mainframe**
- *Característica*: Potente y diseñado para manejar grandes cantidades de datos.
- *Ejemplos*:
  - IBM z/OS
  - Unisys MCP
  - Fujitsu BS2000
  - Hitachi VOS3
  - NEC ACOS

**Servidor**
- *Característica*: Proporciona servicios a otras computadoras en la red.
- *Ejemplos*:
  - Windows Server
  - Linux (como servidor)
  - Apache HTTP Server
  - Nginx
  - Microsoft Exchange Server

**Supercomputadora**
- *Característica*: Alto rendimiento para cálculos científicos intensivos.
- *Ejemplos*:
  - IBM Summit
  - Fujitsu Fugaku
  - Cray XC40
  - HP Apollo
  - Tianhe-2

**SO de Tiempo Real**
- *Característica*: Responde a entradas dentro de un límite de tiempo definido.
- *Ejemplos*:
  - VxWorks
  - QNX
  - FreeRTOS
  - RTLinux
  - Windows Embedded Compact

**SO de Computador Personal**
- *Característica*: Diseñado para uso en computadoras personales.
- *Ejemplos*:
  - Windows
  - macOS
  - Linux (distros de escritorio)
  - Chrome OS
  - Ubuntu

**SO Embedded**
- *Característica*: Integrado en dispositivos específicos (incorporado).
- *Ejemplos*:
  - Android
  - iOS
  - Windows Embedded
  - Embedded Linux
  - VxWorks

**SO de Tarjeta**
- *Característica*: Sistema operativo implementado en tarjetas embebidas.
- *Ejemplos*:
  - Arduino OS
  - MicroPython
  - Mbed OS
  - FreeRTOS (para microcontroladores)
  - Contiki

Este formato markdown debería verse correctamente en GitHub, facilitando la lectura y comprensión de la información sobre los diferentes tipos de sistemas operativos y sus ejemplos asociados.
