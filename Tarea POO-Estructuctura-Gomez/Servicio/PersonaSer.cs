using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_POO_Estructuctura_Gomez.Clases;

namespace Tarea_POO_Estructuctura_Gomez.Servicio
{
    public class PersonaSer
    {
        public Persona Agregar()
        {
            try
            {
                Persona persona2 = new Persona()
                {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("ingresa tu nombre");
                Nombre = Console.ReadLine();
                Console.WriteLine("ingresa tu numero telefonico");
                Telefono = Console.ReadLine();
                Console.WriteLine("Ingresa tu correo");
                Correo = Console.ReadLine();
                Imprimir();
                };

            return persona2;
            }
            catch
            {
                throw;
            }
        }
    }
}

