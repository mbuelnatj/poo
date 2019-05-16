using System;
using System.Collections.Generic;
using System.Text;

namespace P02._EntendiendoUML
{
    public class Area //La Calse debe ser publica para poder ser modificado desde cualquier lugar del programa.
    {
        //Atrivutos privado; son asi para mostrar el encapsulamiento

        private int id;
        private string nombre;
        private string descripcion;

        //Atrivuto publicos: get toma el valor que ingrersas , el st lo establecer desde la variable privado
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        /*Debe tener el nivel de acceso: publico, 
         * tipo de retorno : void 
         *  Nombre : Agrefar empleado
         *  parametro(Opcional)
         */

        public void AgregarArea(Area area)
        {

        }

        public void ListaArea()
        {

        }

        public void DetallesDeArea(Area area)
        {

        }
    }
}
