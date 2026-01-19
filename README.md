# 📅 Gestor de Calendarios

> **Tecnologías**: .NET 8 | Blazor WebAssembly | C# | CSS Moderno

Aplicación web interactiva para la gestión de calendarios y eventos, diseñada con un enfoque en la usabilidad y la interoperabilidad mediante estándares de la industria.

---

## 🚀 Características Principales

*   **Visualización Dinámica**: Interfaz de calendario mensual fluida que permite navegar entre fechas y visualizar eventos de forma clara.
*   **Gestión Multi-Calendario**: Sistema que permite crear, editar y organizar múltiples calendarios, cada uno con su propia identidad visual (colores personalizados) y control de visibilidad.
*   **Motor de Eventos Avanzado**:
    *   Soporte para eventos únicos.
    *   Sistema de recurrencia integrado (diaria y semanal).
    *   Categorización automática por calendario.
*   **Personalización Visual (Theming)**: Soporte completo para **Modo Noche** (Dark Mode), implementado mediante variables CSS para una transición suave y adaptada a la preferencia del usuario.
*   **Interoperabilidad iCal**:
    *   **Importación**: Procesamiento de archivos `.ics` para integrar agendas externas.
    *   **Exportación**: Generación de archivos iCalendar compatibles con las principales herramientas del mercado (Google Calendar, Outlook, Apple Calendar).

---

## 🏗️ Arquitectura Técnica

El proyecto sigue una arquitectura desacoplada y modular sobre Blazor WebAssembly:

1.  **Gestión de Estado**: Toda la lógica de negocio y visualización reside en el `CalendarManager.razor`, actuando como el núcleo de la aplicación que coordina los modelos de datos y la interfaz.
2.  **Modelos de Datos Robustos**: Definidos en `CalendarModels.cs`, asegurando una estructura sólida para calendarios, eventos y lógica de coincidencia de fechas.
3.  **Sistema de Estilos Centralizado**: Utiliza un sistema de variables CSS dinámicas en `app.css`, permitiendo un control granular de la estética y facilitando el mantenimiento del tema visual.
4.  **Integración Nativa con JavaScript**: Uso de `IJSRuntime` para funcionalidades específicas de navegador, como la descarga de archivos generados dinámicamente.

---

## 📂 Estructura de Carpetas

```
/
├── Models/
│   └── CalendarModels.cs       # Estructuras de datos y lógica de negocio
├── Pages/
│   └── CalendarManager.razor   # Componente principal de la aplicación
├── Shared/                     # Componentes compartidos y estructura base
├── wwwroot/
│   ├── css/
│   │   └── app.css             # Definición de estilos y variables de tema
│   └── index.html              # Punto de entrada y scripts auxiliares
└── Program.cs                  # Configuración de arranque del cliente
```

---

## 🛠️ Configuración y Despliegue

1.  Asegúrese de tener instalado el **.NET SDK 8.0**.
2.  Clone el repositorio y sitúese en la raíz del proyecto.
3.  Ejecute la aplicación en modo desarrollo:
    ```bash
    dotnet watch
    ```
4.  Acceda localmente a través de `http://localhost:5000` (o el puerto asignado por el sistema).
