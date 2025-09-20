using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistNotificaciones
{
    internal class SMS: INotificacion
    {
        public void enviar(string msg)
        {
            Console.WriteLine($"Enviando SMS: {msg}");
        }
    }
    
}
