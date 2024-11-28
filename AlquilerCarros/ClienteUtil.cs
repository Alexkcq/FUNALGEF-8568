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

            Console.Write("Ingrese el pago máximo del cliente: ");

            if (!double.TryParse(Console.ReadLine(), out double pagoMaximo))

            {

                Console.WriteLine("Pago máximo inválido. Intente nuevamente.");

                return;

            }

            Cliente nuevoCliente = new Cliente(dni, nombre, pagoMaximo);

            Clientes.Add(nuevoCliente);



            Console.WriteLine("¡Cliente agregado exitosamente!");

        }

        public static void Listar()

        {

            if (Clientes.Count == 0)

            {

                Console.WriteLine("No hay clientes registrados.");

                return;

            }
            Console.WriteLine("Listado de clientes:");

            foreach (var cliente in Clientes)

            {

                Console.WriteLine(cliente);

            }

        }

        public static void Eliminar()

        {

            Console.Write("Ingrese el DNI del cliente a eliminar: ");

            if (!int.TryParse(Console.ReadLine(), out int dni))

            {

                Console.WriteLine("DNI inválido. Intente nuevamente.");

                return;

            }



            Cliente clienteAEliminar = Clientes.Find(c => c.Dni == dni);



            if (clienteAEliminar != null)

            {

                Clientes.Remove(clienteAEliminar);

                Console.WriteLine("¡Cliente eliminado exitosamente!");

            }

            else

            {

                Console.WriteLine("No se encontró un cliente con el DNI ingresado.");

            }

        }

    }
}

        

