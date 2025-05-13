# Gestión de Empleados y Productos

Este sistema de escritorio permite la gestión de empleados y productos en un entorno de clínica, comercio u organización con roles diferenciados para administradores y trabajadores.

Desarrollado en C# con Windows Forms y SQL Server como base de datos, sigue una arquitectura modular basada en bibliotecas de clases separadas para modelos, controladores, y acceso a datos.

---

## 📅 Versión actual

* ABM de empleados (alta, baja, modificación)
* ABM de productos (alta, baja, modificación)
* Roles diferenciados (admin y empleado)
* Login seguro y validado
* Visualización en DataGridView
* Uso de filtros por nombre o categoría

---

## 🚀 Tecnologías y herramientas

* **Lenguaje:** C# (.NET Framework)
* **Interfaz:** Windows Forms
* **Base de datos:** SQL Server
* **Diseño modular:**

  * `GestionDeEmpleadosProductos.Models` (Modelos de las tablas de SQLserver)
  * `GestionDeEmpleadosProductos.Controllers` (Lógica)
  * `GestionDeEmpleadosProductosDatabase` (Conexión de base de datos)
  * `WindowsFormsApp1` (Interfaz)

---

## 📂 Estructura de carpetas

```
GestionDeEmpleadosProductos.app
|-- GestionDeEmpleadosProductos.Controllers
|-- GestionDeEmpleadosProductos.Models
|-- GestionDeEmpleadosProductosDatabase
|-- WindowsFormsApp1
    |-- Views
        |-- Forms
            |-- FormLogin.cs
            |-- FormPrincipal.cs
        |-- UserControls
            |-- RegistroDeEmpleados.cs
            |-- EditarEmpleado.cs
            |-- EliminarEmpleado.cs
            |-- Empleado.cs
            |-- CrearProductos.cs
            |-- EditarProducto.cs
            |-- EliminarProducto.cs
```

---

## 🔑 Roles y permisos

### Administrador

* Accede a la gestión de empleados.
Mediante Usuario = Matias , Contraseña = 2025
* Puede registrar, modificar o eliminar empleados.
* Ve el listado de empleados.

### Empleado (Trabajador)

* Accede a la gestión de productos.
Mediante el gmail y contraseña que el administrador registro al empleado
* Puede registrar, modificar o eliminar productos.
* Ve el listado de productos.

---

## 🔗 Conexión a Base de Datos
1) Ejecutar los querys que se encuentran en la carpeta del proyecto llamada "Base de datos"
2) Buscar el codigo que se encarga de la conexión de la base de datos.
   La conexión se encuentra definida en `DatabaseHelper.cs` dentro del proyecto `GestionDeEmpleadosProductosDatabase`.
3) Solo debe cambiarse el nombre de la base de datos
   public static string ConnectionString = "Server=[Nombre De Tu Server usado en SQLserver];Database=Gestion_De_Empleados;Integrated Security=True;";

**Tablas principales:**

* Admins
* Empleados
* Productos
* Categorias (relación 1 a muchos con Productos)
* SubCategorias (relación 1 a muchos con Categorias)

---

## ✅ Requisitos para ejecutar

* Visual Studio 2022 o superior
* SQL Server Express o superior
* .NET Framework instalado
* Nuggets "System.Data.SqlClient" 

---

## 🎓 Funcionalidades implementadas

* Login con validación por tipo de usuario
* Interfaz centralizada con paneles de navegación
* Múltiples UserControls para modularidad
* DataGridView dinámico según rol
* Separación de lógica y acceso a datos en proyectos independientes

---

## 🏠 Autores

* Proyecto desarrollado por estudiantes de la Universidad Tecnológica Nacional en contexto de parcial de la materia "Programación II"
* Benjamín Veyries, Kevin Yañez, Lázaro Abecia, Mariano Young.

---

## 📃 Licencia

Este proyecto es de uso educativo. Libre para ser reutilizado y mejorado con fines de aprendizaje.
