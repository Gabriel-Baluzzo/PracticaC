using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistNotificaciones
{
    internal interface INotificacion
    {
        void enviar(string msg);
    }
}
