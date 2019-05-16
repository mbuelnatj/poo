using System;
using System.Collections.Generic;
using System.Text;

namespace P02._EntendiendoUML
{
    public class Empleado  //La Calse debe ser publica para poder ser modificado desde cualquier lugar del programa.
    {
        //Atrivutos privado; son asi para mostrar el encapsulamiento
        private int id;
        private string nombrecompleto;
        private string email;
        private string telefono;
        private string area;
        private string puesto;
        private DateTime fecha_ingreso;

        //Atrivuto publicos: get toma el valor que ingrersas , el st lo establecer desde la variable privado
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombrecompleto
        {
            get { return nombrecompleto; }
            set { nombrecompleto = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public DateTime Fecha_Puesto
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
        /*Debe tener el nivel de acceso: publico, 
         * tipo de retorno : void 
         *  Nombre : Agrefar empleado
         *  parametro(Opcional)
         */


        public void AgregarEmpleado(Empleado empleado)
        {

        }

        public void MostrarEmpleado(Empleado empleado)
        {

        }
        /* Metodo que retorna un arreglo
          se tiene que crear un arreglo adentro
          del areglo para retornar el valor
          */

        public Empleado[] ListaEmpleados()
        {
            Empleado[] empleados = new Empleado[2];


            return empleados;  /*retorna el arreglo*/

        }

    }
}
