namespace tp8
{
    public class Tarea
    {
        public int Id { get; private set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }

        public Tarea (int id, string desc, int dur)
        {
            Id = id;
            Descripcion = desc;
            Duracion = dur;
        }
    }
}