public class Tarea
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Completada { get; set; }

    public Tarea(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        Completada = false;
    }

    public override string ToString()
    {
        string estado = Completada ? "Completada" : "Pendiente";
        return $"[{Id}] {Titulo} - {estado}";
    }
}

