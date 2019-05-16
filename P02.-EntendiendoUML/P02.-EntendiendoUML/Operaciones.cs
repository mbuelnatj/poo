using System;
using System.Collections.Generic;
using System.Text;

namespace P02._EntendiendoUML
{/* esta clase solo se ocupa para hacer las operaciones entre las diferentes clases,
    no tiene relevancia para la aplicacion*/

   public class Operaciones
    {
        //Aqui se creo una lista con nombre de "tareas" 
        //Y se hizo un metodo que agregara la tarea a la lista
        List<Tarea> tareas = new List<Tarea>();
        public void AgregarTareas(Tarea tarea)
        {
            tareas.Add(tarea);
        }

        public void Menu()

        {
            Console.Clear();
            Console.WriteLine("Bienvenido a mi lista de tareas");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1.-Agregar tareas");
            Console.WriteLine("2.-Listar tarea");
            Console.WriteLine("3.-Modificar tarea");
            Console.WriteLine("4.-Eliminar tarea");
            int opcion = Convert.ToInt16(Console.ReadLine());
            Tarea tarea = new Tarea();
            switch (opcion) //Menu para seleccionar un caso
            {
                case 1:
                    /*tarea.AgregarTarea(tarea);*/ //Nos envia a agregar tarea de la Clase "Tarea"
                    CapturarTareas();
                    //Se puso al final de cada case el menu para que te lo mostrara al terminar el metodo asignado
                    //Y haci del case 1 al 4
                    Menu();
                    break;
                case 2:
                    tarea.ListarTareas(tareas); //Nos envia a un listado de las tareas agregadas
                    Menu();
                    break;
                case 3:
                    ModificarTarea();
                    Menu();
                    break;
                case 4:
                    tarea.EliminarTarea(tarea);
                    Menu();
                    break;

                default:
                    Console.WriteLine("");

                    break;
            }


        }//No tocar

        private void CapturarTareas()
        {
            Tarea tarea = new Tarea();
            Console.WriteLine("Agregar codigo de tarea");
            tarea.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese  titulo: ");
            tarea.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese descripcion");
            tarea.Descripcion = Console.ReadLine();
            //Aqui se modifico el tipo de dato que entrara en FechaIn
            tarea.FechaIn = DateTime.Now;
            //Aqui se agrego la llamada de un metodo de esta misma clase
            AgregarTareas(tarea);




        }
        //Se creo un nuevo metodo para modificar la tarea de tipo privado
        private void ModificarTarea()
        {
            //Aqui se hace un foreach (O ciclo para lsitas) que alverga el id de la tarea y el titulo de la tarea
            foreach (var tarea in tareas)
            {
                //Aqui se imprime id tarea y titulo de tarea 
                Console.WriteLine($"Id: {tarea.Id}\t" +
                    $"Titulo:{tarea.Titulo}");

            }
            //Aqui se elijira el id de la tarea para poderla modificar
            Console.WriteLine("Elija una tarea");
            int numeroTarea = Convert.ToInt32(Console.ReadLine());
            //Aqui se instancia el objeto "tar"
            Tarea tar = new Tarea();
            Tarea tareaModificada = new Tarea();

            foreach (var tarea in tareas)
            {//Aqui se hace un if y se compara id tarea y numero de tarea para ver si son iguales 
                //Y si lo son se modificara la tarea
                if (tarea.Id == numeroTarea)
                {
                   tareaModificada = tar.ModificarTarea(tarea);
                }
            }
            var index = tareas.FindIndex(item=>item.Id==numeroTarea);
            tareas[index] = tareaModificada;


        }

    }
}
