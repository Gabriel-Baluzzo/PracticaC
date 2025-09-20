using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 5: Diseñe los objetos para una lista de tareas que tengan fecha de realización, fecha de creación, cantidad de veces que fue actualizada, 
//	prioridad y descripción. También debe contar con un desplegable para notificar a otros usuarios registrados de mi tarea. 
//	La cantidad de caracteres de la descripción no puede superar los 200 caracteres.
//La fecha de realización no puede ser elegida en el pasado. La cantidad de veces que fue actualizada no puede modificarse y empieza en cero.
//Diseñar tanto el modelo para la creación de tareas como para su visualización tanto del usuario que crea la tarea como los usuarios que 
//	serán notificados.

namespace ListaTareas
{
	internal class Tarea
	{
		public Usuario Creador { get; private set; }
        public DateTime FechaCreacion { get; private set; }
		private DateTime fechaRealizacion;
		public DateTime FechaRealizacion
		{
			get { return fechaRealizacion; }
			set
			{
				if (value < DateTime.Now)
				{
					throw new ArgumentException("La fecha de realización no puede ser en el pasado.");
				}
				fechaRealizacion = value;
			}
		}
		public int CantidadActualizaciones { get; private set; }
		private Prioridad prioridad;

		public Prioridad Prioridad
		{
			get { return prioridad; }
			set { if (prioridad != value) {
					prioridad = value;
					CantidadActualizaciones++;
                } }
		}

		private string descripcion;
		public string Descripcion
		{
			get { return descripcion; }
			set
			{
				if (value.Length > 200)
				{
					throw new ArgumentException("La descripción no puede superar los 200 caracteres.");
				} else if (descripcion != value) {
                    descripcion = value;
                    CantidadActualizaciones++;
                }
            }
		}
		public List<Usuario> UsuariosRegistrados { get; } = new List<Usuario>();
		public Tarea(DateTime fechaRealizacion, Prioridad prioridad, string descripcion, Usuario creador)
		{
			FechaCreacion = DateTime.Now;
			this.fechaRealizacion = fechaRealizacion;
			this.prioridad = prioridad;
			this.descripcion = descripcion;
			Creador = creador;
        }

		public void registrarUsuario(Usuario usuario)
		{	
			if (!UsuariosRegistrados.Contains(usuario))
			{
				UsuariosRegistrados.Add(usuario);
            }
        }

		public void mostrarTarea()
		{
			Console.WriteLine($"Tarea creada por: {Creador.Nombre}");
			Console.WriteLine($"Fecha de creación: {FechaCreacion}");
			Console.WriteLine($"Fecha de realización: {FechaRealizacion}");
			Console.WriteLine($"Cantidad de actualizaciones: {CantidadActualizaciones}");
			Console.WriteLine($"Prioridad: {Prioridad}");
			Console.WriteLine($"Descripción: {Descripcion}");
			Console.WriteLine("Usuarios notificados:");
			foreach (var usuario in UsuariosRegistrados)
			{
				Console.WriteLine($"- {usuario.Nombre}");
            }
        }

    }
}
