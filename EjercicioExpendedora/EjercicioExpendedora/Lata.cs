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
            return "Codigo: " + Codigo;
        }

        public Lata(string codigo, double precio, double volumen)
        {
            this.codigo = codigo;
            this.precio = precio;
            this.volumen = volumen;

            switch (codigo)
            {
                case "CO1":
                    this.nombre = "Coca Cola Regular";
                    this.sabor = "Cola";
                    break;
                case "C02":
                    this.nombre = "Coca Cola Zero";
                    this.sabor = "Cola";
                    break;
                case "SP1":
                    this.nombre = "Sprite Regular";
                    this.sabor = "Lima Limon";
                    break;
                case "SP2":
                    this.nombre = "Sprite Zero";
                    this.sabor = "Lima Limon";
                    break;
                case "FA1":
                    this.nombre = "Fanta Regular";
                    this.sabor = "Cola";
                    break;
                case "FA2":
                    this.nombre = "Fanta Zero";
                    this.sabor = "Lima Limon";
                    break;

            }

        }
    }
}
