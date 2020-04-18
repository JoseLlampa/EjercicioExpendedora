using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExpendedora
{
    class Expendedora
    {
        private List<Lata> latas;
        private string proveedor;
        private int capacidad;
        private double dinero;
        private bool encendida;

        public List<Lata> Latas { get => latas; set => latas = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public bool Encendida { get => encendida; set => encendida = value; }

        public Expendedora(bool estado)
        {
            this.latas = new List<Lata>();
            this.encendida = estado;
        }

        public void AgregarLata(Lata latas)
        {

        }

        public Lata ExtraerLata(string c, double d)
        {
            Lata lata = this.latas.SingleOrDefault(x => x.Codigo == c);

            if (lata != null)
            {
                this.latas.Remove(lata);
                //codigo "acumular dinero
                return lata;
            }
            else
            {
                throw new Exception("No hay stock en esa lata");
            }
                }

        public string GetBalance()
        {
            return this.dinero.ToString();
        }

        public int GetCapacidadRestante()
        {
            return this.capacidad;
        }

        public void EncenderMaquina()
        {

        }

        public bool EstaEncendida()
        {
            return this.encendida;
        }

    }
}
