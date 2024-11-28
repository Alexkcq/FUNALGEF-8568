using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlquilerCarros
{
    public class Alquiler

    {

        // Propiedades

        public int Numero { get; set; }

        public Carro CarroAlquilado { get; set; }

        public Cliente Contratante { get; set; }

        public double Precio { get; set; }



        // Constructor opcional

        public Alquiler(int numero, Carro carroAlquilado, Cliente contratante, double precio)

        {

            Numero = numero;

            CarroAlquilado = carroAlquilado;

            Contratante = contratante;

            Precio = precio;

        }

        public override string ToString()

        {

            return $"Número: {Numero}, Carro: [{CarroAlquilado}], Contratante: [{Contratante}], Precio: {Precio:C}";

        }

    }
}