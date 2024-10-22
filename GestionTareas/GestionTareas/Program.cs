using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Tarea> tareas = new List<Tarea>();
    static string filePath = "tasks.txt";

    static void Main(string[] args)
    {
        CargarTareasDeArchivo();
        MostrarMenu();
    }

    static void MostrarMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Gestión de Tareas");
            Console.WriteLine("1. Agregar Tarea");
            Console.WriteLine("2. Listar Tareas");
            Console.WriteLine("3. Marcar Tarea como Completada");
            Console.WriteLine("4. Eliminar Tarea");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarTarea();
                    break;
                case "2":
                    ListarTareas();
                    break;
                case "3":
                    MarcarTareaCompletada();
                    break;
                case "4":
                    EliminarTarea();
                    break;
                case "5":
                    GuardarTareasEnArchivo();
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Ingrese el título de la tarea: ");
        string titulo = Console.ReadLine();
        int id = tareas.Count > 0 ? tareas[tareas.Count - 1].Id + 1 : 1;
        Tarea nuevaTarea = new Tarea(id, titulo);
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada correctamente.");
        Console.ReadKey();
    }

    static void ListarTareas()
    {
        Console.WriteLine("Lista de Tareas:");
        foreach (var tarea in tareas)
        {
            Console.WriteLine(tarea);
        }
        Console.ReadKey();
    }

    static void MarcarTareaCompletada()
    {
        ListarTareas();
        Console.Write("Ingrese el ID de la tarea a marcar como completada: ");
        int id = int.Parse(Console.ReadLine());

        Tarea tarea = tareas.Find(t => t.Id == id);
        if (tarea != null)
        {
            tarea.Completada = true;
            Console.WriteLine("Tarea marcada como completada.");
        }
        else
        {
            Console.WriteLine("Tarea no encontrada.");
        }
        Console.ReadKey();
    }

    static void EliminarTarea()
    {
        ListarTareas();
        Console.Write("Ingrese el ID de la tarea a eliminar: ");
        int id = int.Parse(Console.ReadLine());

        Tarea tarea = tareas.Find(t => t.Id == id);
        if (tarea != null)
        {
            tareas.Remove(tarea);
            Console.WriteLine("Tarea eliminada.");
        }
        else
        {
            Console.WriteLine("Tarea no encontrada.");
        }
        Console.ReadKey();
    }

    static void GuardarTareasEnArchivo()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var tarea in tareas)
            {
                writer.WriteLine($"{tarea.Id},{tarea.Titulo},{tarea.Completada}");
            }
        }
        Console.WriteLine("Tareas guardadas en archivo.");
    }

    static void CargarTareasDeArchivo()
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');
                    int id = int.Parse(datos[0]);
                    string titulo = datos[1];
                    bool completada = bool.Parse(datos[2]);
                    Tarea tarea = new Tarea(id, titulo) { Completada = completada };
                    tareas.Add(tarea);
                }
            }
        }
    }
}
