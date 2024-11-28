using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public static class ClienteUtil

    {

        public static List<Cliente> Clientes = new List<Cliente>();

        public static void Crear()

        {

            Console.Write("Ingrese el DNI del cliente: ");

            if (!int.TryParse(Console.ReadLine(), out int dni))

            {

                Console.WriteLine("DNI inválido. Intente nuevamente.");

                return;

            }



            Console.Write("Ingrese el nombre del cliente: ");

            string nombre = Console.ReadLine();
        }
    }
}



            

  
