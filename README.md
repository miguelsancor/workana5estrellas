# workana5estrellas

# Consola de Gestión de Tareas en .NET

## Descripción de la Aplicación
La aplicación de **Consola de Gestión de Tareas** es una herramienta simple que permite gestionar una lista de tareas de manera interactiva. A través de una interfaz de consola, el usuario puede agregar nuevas tareas, listar las tareas existentes, marcarlas como completadas y eliminarlas cuando ya no sean necesarias.

## Requerimientos del Sistema
- Sistema operativo: Windows, macOS, o Linux.
- Tener instalado .NET Core o .NET Framework.
- Editor o IDE recomendado: Visual Studio Community.
- Archivo de tareas: `tasks.txt` (creado automáticamente por la aplicación en el mismo directorio).

## Cómo Iniciar la Aplicación
1. **Ejecutar la Aplicación**: 
   - Abre el proyecto en **Visual Studio**.
   - Presiona el botón de **Iniciar** o usa el atajo de teclado **F5** para ejecutar la aplicación.
   - Verás aparecer el menú principal en la consola.

## Funcionalidades Principales

### 1. Agregar Tarea
   - Selecciona la opción **1** en el menú principal.
   - La aplicación te pedirá que ingreses el título de la nueva tarea.
   - Después de escribir el título, la tarea se agregará a la lista de tareas con un estado **"Pendiente"**.

   **Ejemplo**:

### 2. Listar Tareas
- Selecciona la opción **2** en el menú principal.
- La aplicación mostrará todas las tareas en la lista, cada una con su ID, título y estado (Pendiente o Completada).

**Ejemplo de salida**:

### 3. Marcar Tarea como Completada
- Selecciona la opción **3** en el menú principal.
- La aplicación te pedirá que ingreses el **ID** de la tarea que deseas marcar como completada.
- Una vez marcado, el estado de la tarea cambiará a **"Completada"**.

**Ejemplo**:

### 4. Eliminar Tarea
- Selecciona la opción **4** en el menú principal.
- La aplicación te pedirá que ingreses el **ID** de la tarea que deseas eliminar.
- La tarea seleccionada se eliminará de la lista.

**Ejemplo**:

### 5. Salir
- Selecciona la opción **5** en el menú principal.
- La aplicación guardará automáticamente todas las tareas en el archivo `tasks.txt` para su posterior recuperación.
- La aplicación se cerrará.

## Almacenamiento de Tareas
- Las tareas se almacenan en un archivo de texto (`tasks.txt`) que se encuentra en el mismo directorio donde se ejecuta la aplicación.
- Este archivo es generado automáticamente cuando la aplicación guarda las tareas. Si ya existe, la aplicación lo cargará al iniciar para que las tareas previamente almacenadas estén disponibles.

## Manejo de Errores
- Si se ingresa una opción no válida en el menú, la aplicación te mostrará un mensaje indicando que la opción es incorrecta.
- Si intentas marcar como completada o eliminar una tarea con un **ID** que no existe, la aplicación te notificará que no se encontró la tarea.

## Recomendaciones de Uso
1. **Mantener el archivo `tasks.txt`**: No elimines o modifiques manualmente el archivo `tasks.txt` a menos que estés seguro de lo que haces, ya que este archivo contiene las tareas almacenadas por la aplicación.
2. **Utiliza correctamente los ID de las tareas**: Los **ID** son únicos para cada tarea, así que asegúrate de utilizar el ID correcto al marcar o eliminar tareas.

## Preguntas Frecuentes (FAQ)

1. **¿Qué pasa si cierro la aplicación sin usar la opción "Salir"?**
- Si cierras la aplicación sin seleccionar la opción **Salir**, las tareas no se guardarán en el archivo y se perderán.

2. **¿Puedo modificar el archivo `tasks.txt` manualmente?**
- Puedes hacerlo, pero no se recomienda, ya que podría causar errores en la aplicación si el formato del archivo no es correcto.

3. **¿Qué sucede si marco una tarea incorrectamente como completada?**
- Simplemente puedes eliminar la tarea y agregarla nuevamente.
