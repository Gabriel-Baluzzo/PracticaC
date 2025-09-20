namespace SistNotificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailNotificacion = new Email();
            emailNotificacion.enviar("Hola, este es un correo de notificación.");
            var smsNotificacion = new SMS();
            smsNotificacion.enviar("Hola, este es un SMS de notificación.");
        }
    }
}
