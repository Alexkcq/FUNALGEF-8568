using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public static class AlquilerUtil

    {
        public static List<Alquiler> Alquileres = new List<Alquiler>();
        public static void Crear(List<Carro> carros, List<Cliente> clientes)

        {
            Console.WriteLine("Seleccione un cliente:");

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientes[i]}");
            }
            Console.Write("Ingrese el número del cliente: ");
            int clienteIndex = int.Parse(Console.ReadLine()) - 1;

            if (clienteIndex < 0 || clienteIndex >= clientes.Count)
            {
                Console.WriteLine("Cliente no válido.");
                return;
            }

            Cliente clienteSeleccionado = clientes[clienteIndex];
            Console.WriteLine("Seleccione un carro:");

            for (int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {carros[i]}");
            }
            Console.Write("Ingrese el número del carro: ");
            int carroIndex = int.Parse(Console.ReadLine()) - 1;

            if (carroIndex < 0 || carroIndex >= carros.Count)
            {
                Console.WriteLine("Carro no válido.");
                return;
            }
            Carro carroSeleccionado = carros[carroIndex];

            Console.Write("Ingrese el precio del alquiler: ");
            double precio = double.Parse(Console.ReadLine());

            Alquiler nuevoAlquiler = new Alquiler(Alquileres.Count + 1, carroSeleccionado, clienteSeleccionado, precio);
            Alquileres.Add(nuevoAlquiler);
            Console.WriteLine("¡Alquiler creado exitosamente!");

        }

        public static void Listar()
        {
            if (Alquileres.Count == 0)
            {
                Console.WriteLine("No hay alquileres registrados.");
                return;
            }

            Console.WriteLine("Listado de Alquileres:");

            foreach (var alquiler in Alquileres)
            {
                Console.WriteLine(alquiler);
            }
        }
        public static void CarrosAAlquilar(List<Carro> carros, List<Cliente> clientes)
        {
            Console.WriteLine("Seleccione un cliente:");

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clientes[i]}");
            }
            Console.Write("Ingrese el número del cliente: ");
            int clienteIndex = int.Parse(Console.ReadLine()) - 1;

            if (clienteIndex < 0 || clienteIndex >= clientes.Count)
            {
                Console.WriteLine("Cliente no válido.");
                return;
            }
            Cliente clienteSeleccionado = clientes[clienteIndex];
            Console.WriteLine($"Carros disponibles para el cliente {clienteSeleccionado.Nombre}:");

            foreach (var carro in carros)
            {
                if (carro.PrecioAlquiler <= clienteSeleccionado.PagoMaximo)
                {
                    Console.WriteLine(carro);
                }
            }

        }

    }
}