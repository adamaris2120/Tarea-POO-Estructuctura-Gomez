using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO_Estructuctura_Gomez.Clases
{
    public class Persona
    {

        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }


        public void Leer ()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("ingresa tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu numero telefonico");
            Telefono = Console.ReadLine();
            Console.WriteLine("Ingresa tu correo");
            Correo = Console.ReadLine();
            Imprimir();
        }
        public void Imprimir()
        {
            Console.WriteLine("tus datos son \n");
            Console.WriteLine(this.Nombre);
            Console.WriteLine(this.Telefono);
            Console.WriteLine(this.Correo);
            Console.WriteLine("presiona cualquier tecla para salir");
            Console.ReadKey();
            Console.Clear();
        }
    }

}
