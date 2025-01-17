**Importante para restablecer las depndencias ejecutar:**
- Restore-Package (Desde la consola de administrador de paquetes)
- dotnet restore (O desde cmd. Cualquiera de las dos es válida.)

# Gestión de Consultas Médicas - Proyecto WinForms

Este proyecto es un sistema para gestionar consultas médicas utilizando un enfoque de arquitectura en tres capas (**CapaDatos**, **CapaLogica**, y **CapaPresentación**) y una base de datos SQLite.

## Miembros del equipo
- **Matías Prieto:** Desarrollo inicial del proyecto.
- **Augusto Terrera:** Colaboración en la finalización del proyecto.

## Estructura del proyecto

### Capas del proyecto
1. **CapaDatos:**
   - Contiene los modelos de datos, el contexto de la base de datos (`AppDbContext`), la fábrica del contexto (`AppDbFactory`), y el repositorio genérico.
2. **CapaLogica:**
   - Encargada de implementar la lógica del negocio. Incluye servicios e interfaces para conectar los datos con la capa de presentación.
3. **CapaPresentación:**
   - Interfaz de usuario desarrollada con **Windows Forms (WinForms)** para interactuar con el sistema.

---

## Responsabilidades iniciales

### **Matías Prieto**
#### Trabajo realizado:
- Configuración inicial del proyecto.
- Desarrollo de la **CapaDatos**:
  - Creación de modelos.
  - Implementación de `AppDbContext` y `AppDbFactory`.
  - Configuración del repositorio genérico en la carpeta `Repositories`.
- Creación de las carpetas:
  - `Models`
  - `Interfaces`
  - `Repositories`
- Configuración básica de la **CapaLogica**:
  - Creación de carpetas `Interfaces` y `Services`.

### **Augusto Terrera**
#### Tareas asignadas:
Tu rol será implementar y completar las siguientes tareas pendientes para el proyecto.

---

## Plan de trabajo
El objetivo es finalizar el proyecto en **un mes como máximo**. A continuación, se detallan las tareas divididas por semanas y responsables:

### Semana 1: Finalizar la lógica de negocio
**Responsables: Matías Prieto y Augusto Terrera**
- **Matías Prieto:**
  - Documentar las validaciones necesarias para cada modelo.
  - Diseñar un esquema base de tests unitarios para los servicios de la **CapaLogica**.
- **Augusto Terrera:**
  - Implementar las interfaces de la **CapaLogica**:
    - Crear servicios específicos para cada modelo (por ejemplo, `PacienteService`, `ConsultaService`, etc.).
    - Utilizar el repositorio genérico para realizar las operaciones CRUD necesarias.
- Ambos:
  - Revisar en conjunto el diseño de los servicios para garantizar coherencia y funcionalidad.

---

### Semana 2: Inicio de la CapaPresentación
**Responsables: Matías Prieto y Augusto Terrera**
- **Matías Prieto:**
  - Diseñar la estructura del menú principal (Dashboard) y definir los accesos a los módulos.
  - Configurar las conexiones iniciales con los servicios desde los formularios de WinForms.
- **Augusto Terrera:**
  - Implementar la pantalla de gestión de **Pacientes**:
    - Crear un formulario para agregar, editar y eliminar pacientes.
    - Listar pacientes en un `DataGridView`.
    - Conectar esta pantalla con los servicios de la **CapaLogica**.
- Ambos:
  - Probar la funcionalidad del módulo de pacientes y documentar errores o mejoras necesarias.

---

### Semana 3: Funcionalidades adicionales
**Responsables: Matías Prieto y Augusto Terrera**
- **Matías Prieto:**
  - Implementar la pantalla de gestión de **Diagnósticos**:
    - Registrar diagnósticos asociados a consultas.
    - Mostrar un listado de diagnósticos con fechas y descripciones.
  - Diseñar la estructura básica de reportes (por ejemplo, generación de PDF).
- **Augusto Terrera:**
  - Implementar la pantalla de gestión de **Consultas**:
    - Crear un formulario para registrar consultas asociadas a pacientes.
    - Mostrar el historial de consultas por paciente en un `DataGridView`.
- Ambos:
  - Validar todas las operaciones de las pantallas y servicios implementados.

---

### Semana 4: Finalización y pruebas
**Responsables: Matías Prieto y Augusto Terrera**
- **Matías Prieto:**
  - Realizar pruebas del sistema completo.
  - Documentar errores o inconsistencias y corregirlas.
  - Mejorar el diseño visual de las pantallas.
- **Augusto Terrera:**
  - Crear las pantallas de **Tratamientos**, **Pagos**, y el **Historial Clínico**.
  - Asegurar la conexión de estas pantallas con la lógica de negocio y la base de datos.
- Ambos:
  - Probar exhaustivamente todo el sistema.
  - Preparar una presentación final del proyecto con todas las funcionalidades implementadas.

---

## Extras opcionales (si hay tiempo)
- Implementar un sistema de autenticación (Login).
- Crear reportes en PDF con el historial clínico completo de un paciente.
- Agregar un modo oscuro a la interfaz.

---

## Entrega final
El sistema debe estar completamente funcional y probado al finalizar el mes. El resultado será un proyecto modular y escalable, ideal para gestionar consultas médicas en pequeñas clínicas.

**¡A meterle pila que no hay tiempo para boludear! 💪**
