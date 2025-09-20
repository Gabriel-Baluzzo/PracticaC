namespace ListaTareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creador = new Usuario("Juan");
            var tarea = new Tarea(DateTime.Now.AddDays(1), Prioridad.Alta, "Completar el informe", creador);
            var registrado1 = new Usuario("Ana");
            var registrado2 = new Usuario("Luis");

            tarea.registrarUsuario(registrado1);
            tarea.registrarUsuario(registrado2);
            tarea.mostrarTarea();

            //Aumenta el numero de actualizaciones
            tarea.Descripcion = "Completar el informe y enviarlo por correo";

            tarea.mostrarTarea();
        }
    }
}
