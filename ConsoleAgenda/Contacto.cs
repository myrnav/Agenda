using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgenda
{
    public class Contacto //tiene que ser publica sino no se puede instanciar
    {
        //Constructores: inicializa la instancia
        //puede tener todos los parametros
        //los valores que tienen que tener los parametros
       /* public Contacto(String nombre, String apellido, String telefono, String direccion) 
        {
            _nombre= nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;

        }*/
        
        //Atributos de clase
        private String _nombre;
        private String _apellido;
        private String _telefono;
        private String _direccion;
        private int _llamadas;

        //propiedades
        public string Nombre //Read and Write
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido //Read and Write
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Telefono //Read and Write
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Direccion //Read and Write
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int Llamadas //readonly
        {
            get { return _llamadas; }
        }

        //Metodos
        public int Edad() 
        {
            //implemetacion
            return 0;
        }


    }
}
