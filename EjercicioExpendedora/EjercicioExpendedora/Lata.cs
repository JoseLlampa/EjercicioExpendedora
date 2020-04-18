using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExpendedora
{
    class Lata
    {
        private string codigo;
        private string nombre;
        private string sabor;
        private double precio;
        private double volumen;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Sabor { get => sabor; set => sabor = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Volumen { get => volumen; set => volumen = value; }

        private double GetPrecioPorLitro()
        {
            return Precio / Volumen;
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo ;
        }
    }
}
