using System;
using System.Collections.Generic;
using System.Text;

namespace P02._EntendiendoUML
{
    public class Tarea //La Calse debe ser publica para poder ser modificado desde cualquier lugar del programa.
    {
        //Atrivutos privado; son asi para mostrar el encapsulamiento

        private int id;
        private string titulo;
        private DateTime fechain;
        private DateTime fechafin;
        private string descripcion;

        //Atrivuto publicos: get toma el valor que ingrersas , el st lo establecer desde la variable privado
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public DateTime FechaIn
        {
            get { return fechain; }
            set { fechain = DateTime.Now; }
        }
        public DateTime FechaFin
        {
            get { return fechafin; }
            set { fechafin = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        List<Tarea> tareas = new List<Tarea>();
        /*Debe tener el nivel de acceso: publico, 
         * tipo de retorno : void 
         *  Nombre : Agrefar empleado
         *  parametro(Opcional)*/
        public void ListarTareas(List<Tarea> tareas)
        {
            foreach (var tarea in tareas)
            {//Aqui se hizo una concatenacion de el id de la tarea junto con titulo, descripcion y fecha de entrada para
                //poder imprimirlo de esa manera
                Console.WriteLine(tarea.Id + " /" + tarea.Titulo + " /" + tarea.Descripcion + "/ " + tarea.FechaIn);

            }
            Console.ReadKey();
        }

        public Tarea ModificarTarea(Tarea tarea)
        {
            Console.WriteLine("Tarea");
            tarea.titulo = Console.ReadLine();
            Console.WriteLine("Descripcion");
            tarea.descripcion = Console.ReadLine();

            return tarea;

        }

        public void EliminarTarea(Tarea tarea)
        {
            Console.WriteLine("Ingrese Id de tarea a Borrar:");
            Console.WriteLine(tarea.Id + " /" + tarea.Titulo + " /" + tarea.Descripcion + "/ " + tarea.FechaIn);
            
            Console.ReadKey();
        }


    }
}
