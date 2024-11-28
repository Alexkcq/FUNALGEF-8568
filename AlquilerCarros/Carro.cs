using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerCarros
{
    public class Carro

    {
        public string Placa { get; set; }

        public string Marca { get; set; }

        public double PrecioAlquiler { get; set; }


        public Carro(string placa, string marca, double precioAlquiler)

        {

            Placa = placa;

            Marca = marca;

            PrecioAlquiler = precioAlquiler;

        }


        public override string ToString()

        {

            return $"Placa: {Placa}, Marca: {Marca}, Precio de Alquiler: {PrecioAlquiler:C}";

        }

    }
}
