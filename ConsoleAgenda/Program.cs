using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //creo la instancia
           
            Agenda agenda = new Agenda("Veronica", "Electrónica", 5);
            Contacto c = new Contacto();

            agenda.AñadirContacto();
           
            //Contacto c2 = new Contacto("Pepe", "Luz", "1511002233", "Cucha Cucha 234");
            //Contacto c3 = new Contacto("Paz", "Soriano", "1511002233", "Cucha Cucha 123");
            //agenda.ListarContactos();
            agenda.BuscarContactoPorNombre(); //No me esta devolviendo el 
           

            Console.ReadKey();
        }
    }
}
