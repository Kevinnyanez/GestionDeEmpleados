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

  * `GestionDeEmpleadosProductos.Models`
  * `GestionDeEmpleadosProductos.Controllers`
  * `GestionDeEmpleadosProductosDatabase`
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
* Puede registrar, modificar o eliminar empleados.
* Ve el listado de empleados.

### Empleado (Trabajador)

* Accede a la gestión de productos.
* Puede registrar, modificar o eliminar productos.
* Ve el listado de productos.

---

## 🔗 Conexión a Base de Datos

La conexión se encuentra definida en `DatabaseHelper.cs` dentro del proyecto `GestionDeEmpleadosProductosDatabase`.

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

---

## 🎓 Funcionalidades implementadas

* Login con validación por tipo de usuario
* Interfaz centralizada con paneles de navegación
* Múltiples UserControls para modularidad
* DataGridView dinámico según rol
* Separación de lógica y acceso a datos en proyectos independientes

---

## 🔍 Pendientes / mejoras sugeridas

* Validación de datos al ingresar (formatos, campos vacíos)
* Confirmación al eliminar registros
* Agregado de historial o bitácora de acciones (opcional)
* Exportación de datos (Excel / PDF) \[opcional extra]

---

## 🏠 Autores

* Proyecto desarrollado por estudiantes en contexto de práctica profesional / parcial integrador.
* Benjamín Veyries, Kevin Yañez, Lázaro Abecia, Mariano Young.

---

## 📃 Licencia

Este proyecto es de uso educativo. Libre para ser reutilizado y mejorado con fines de aprendizaje.
