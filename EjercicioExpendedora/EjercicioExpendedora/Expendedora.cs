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

        public Expendedora(string proveedor, int capacidad, double dinero, bool encendida)
        {
            this.latas = new List<Lata>();
            this.proveedor = proveedor;
            this.capacidad = capacidad;
            this.dinero = dinero;
            this.encendida = encendida;
        }

        public void AgregarLata(Lata latas)
        {
            //FALTA validacion de los codigos de lata posibles {C01, C02, SP1, SP2, FA1, FA2}

            this.latas.Add(latas);
        }

        public Lata ExtraerLata(string c, double d)
        {
            Lata lata = this.latas.SingleOrDefault(x => x.Codigo == c);//Guardo en memoria una lata con codigo igual al ingresado, es decir, c 

            if (lata != null)
            {
                this.latas.Remove(lata);
                
                //FALTA codigo para que la maquina expendedora acumule el dinero
                
                return lata;//PREGUNTA: porque debe retornar un objeto lata?

            }
            else
            {
                throw new Exception("No hay stock para su pedido");
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
