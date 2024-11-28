using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{

    using System;

    using System.Collections.Generic;



    public static class CarroUtil

    {



        public static List<Carro> Carros = new List<Carro>();



        public static void Crear()

        {

            Console.Write("Ingrese la placa del carro: ");

            string placa = Console.ReadLine();



            Console.Write("Ingrese la marca del carro: ");

            string marca = Console.ReadLine();



            Console.Write("Ingrese el precio de alquiler del carro: ");

            if (!double.TryParse(Console.ReadLine(), out double precioAlquiler))

            {

                Console.WriteLine("Precio inválido. Intente nuevamente.");

                return;

            }



            Carro nuevoCarro = new Carro(placa, marca, precioAlquiler);

            Carros.Add(nuevoCarro);



            Console.WriteLine("¡Carro agregado exitosamente!");

        }



        public static void Listar()

        {

            if (Carros.Count == 0)

            {

                Console.WriteLine("No hay carros registrados.");

                return;

            }



            Console.WriteLine("Listado de carros:");

            foreach (var carro in Carros)

            {

                Console.WriteLine(carro);

            }

        }
        public static void Eliminar()

        {

            Console.Write("Ingrese la placa del carro a eliminar: ");

            string placa = Console.ReadLine();



            Carro carroAEliminar = Carros.Find(c => c.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));



            if (carroAEliminar != null)

            {

                Carros.Remove(carroAEliminar);

                Console.WriteLine("¡Carro eliminado exitosamente!");

            }

            else

            {

                Console.WriteLine("No se encontró un carro con la placa ingresada.");

            }

        }

    }
}
