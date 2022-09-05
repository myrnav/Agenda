using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgenda
{
    public class Agenda //tiene que ser publica sino no se puede instanciar
    {
        //constructor

        public Agenda(String nombre, String tipo, int maxContacto)
        {
            _nombre = nombre;
            _tipo = tipo;
            _maxContacto = maxContacto;
            contacto = new List<Contacto>();
        }

        //Atributos
        private string _nombre;
        private string _tipo;
        private int _maxContacto;
        private List<Contacto> contacto;

        

        //propiedades

        public string Nombre
        {
            get { return _nombre; }
        }
        public string Tipo
        {
            get { return _tipo; }
        }
        public int maximoContacto
        {
            get { return _maxContacto; }
        }


        public void AñadirContacto()
        {
            string nombreNuevo;
            string apellidoNuevo;
            string telefonoNuevo;
            string direccionNuevo;
            bool flag;
            string condicion;

            Contacto c = new Contacto();

            do {

                Console.WriteLine("Nombre del Contacto:");
                nombreNuevo = Console.ReadLine();
                c.Nombre = nombreNuevo;

                Console.WriteLine("Apellido del Contacto:");
                apellidoNuevo = Console.ReadLine();
                c.Apellido = apellidoNuevo;

                Console.WriteLine("Telefono del Contacto:");
                telefonoNuevo = Console.ReadLine();
                c.Telefono = telefonoNuevo;

                Console.WriteLine("Direccion del Contacto:");
                direccionNuevo = Console.ReadLine();
                c.Direccion = direccionNuevo;

                contacto.Add(c);

                do
                {
                    Console.WriteLine("Desea ingresar otro? (S/N)");
                    condicion = Console.ReadLine();
                    flag = ValidarCondicion(condicion);

                } while (flag == false);

            } while (condicion == "S");

        }

        private bool ValidarCondicion(string condicion)
        {
            bool flag = true;

            if (condicion != "S" && condicion != "N")
            {
                Console.WriteLine("Usted ingreso un dato invalido.");
                flag = false;
            }

            return flag;
        }


        public void ListarContactos()
        {

            foreach (Contacto c in contacto)
            {
                Console.WriteLine("Nombre : " + c.Nombre);
                Console.WriteLine("Apellido : " + c.Apellido);
                Console.WriteLine("Telefono : " + c.Telefono);
                Console.WriteLine("Direccion : " + c.Direccion);        

            }       
        }

        public Contacto BuscarNombre(string nombre)
        {
            return contacto.Find(a => a.Nombre == nombre);
        }

        public void BuscarContactoPorNombre()
        {
            string nombre;

            Console.WriteLine("Ingrese el nombre del contacto: ");
            nombre = Console.ReadLine();

            Contacto contacto = BuscarNombre(nombre);
            if (contacto == null)
            {
                Console.WriteLine("El nombre ingresado no existe.");
            }
            else
            {
                Console.WriteLine("Se encontro el nombre ingresado, sus datos son:", System.Environment.NewLine,
                    contacto.Nombre," ",contacto.Apellido);
            }
        }


    }
}
