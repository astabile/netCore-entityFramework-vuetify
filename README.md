# Acerca del proyecto
La empresa X solicita una aplicación web para registrar solicitudes de permisos, para llevar a cabo esta tarea se requiere cumplir con los siguientes pasos:
* Crear una tabla con el nombre Permisos.
* Crear una tabla con el nombre TipoPermiso.
* Establecer relacion entre Permisos y TipoPermiso.
* Crear una aplicacion web en visual studio, puede ser webform o mvc o asp.net core. 
* Utilizar EntityFramework.
* Puedes llenar la tabla tipo permiso con los datos que crear ejemplo (enfermedad, diligencias, etc etc).
* Puedes usar jquery o cualquier framework javascript que conozca si es necesario.
* Los campos que no permiten nulo deben ser validados.
* Solo tendras que hacer la operacion de insertar en la table Permiso y eliminar permiso.
* Usar buenas practicas.

# Herramientas utilizadas
* Git bash (consola de desarrollo)
* Node.js (gestión de paquetes a traves de npm)
* Sourcetree (sincronización de repositorio de Git)
* Visual Studio Core (desarrollo de proyecto frontend en vue)
* Visual Studio 2019 (desarrollo de proyecto backend en C#, netCore y Entity Framework)
* Postman (prueba de endpoints de la aplicación)

# Lista de endpoints
* GET: api/TipoPermisos/Listar
* GET: api/TipoPermisos/Mostrar/id
* GET: api/Permisos/Listar
* POST: api/Permisos/Crear
* DELETE: api/Permisos/Eliminar/id

# 1 Base de datos
Utilizar SQL Express y crear la base de datos. Utilizar el script **/scripts.sql** (creación de base de datos, tablas y populado).

# 2 Código
Clonar el proyecto y acceder al repositorio:
```
git clone https://github.com/astabile/netCore-entityFramework-vuetify.git netCoreEntityFrameworkVuetify
cd netCoreEntityFrameworkVuetify
```

# 3 Aplicación
Correr la aplicación con IIS en Visual Studio.
