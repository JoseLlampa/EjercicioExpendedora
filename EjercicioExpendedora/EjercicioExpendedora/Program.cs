using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            string pantalla = "CO1 - Coca Cola Regular \nCO2 - Coca Cola Zero \nSP1 - Sprite Regular \nSP2 - Sprite Zero \nFA1 - Fanta Regular \nFA2 - Fanta Zero";

            string menu = "1) Ingresar Lata \n2) Extraer Lata \n3) Obtener Balance \n4) Mostrar Stock \nX) Salir";

            Expendedora expend = new Expendedora("Coca-Cola",3,0,true);

            do
            {
                Console.WriteLine(pantalla);
                Console.WriteLine();
                Console.WriteLine(menu);

                string opcionSeleccionada = Console.ReadLine();

                switch (opcionSeleccionada)
                {
                    case "1":
                        Program.IngresarLata(expend);
                        break;

                    case "2":
                        Program.ExtraerLata(expend);
                        break;

                    case "3":
                        Program.ObtenerBalance(expend);
                        break;

                    case "4":
                        //Program.MostrarStock(expend);
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            } while (expend.Encendida);

            Console.ReadKey();
        }

        private static void IngresarLata (Expendedora expendedora)
        {
            Console.Write("Ingrese el codigo");
            string c=Console.ReadLine();

            Console.Write("Ingrese el precio");
            double p=double.Parse(Console.ReadLine());

            Console.Write("Ingrese volumen");
            double v= double.Parse(Console.ReadLine());

            Lata lat= new Lata(c, p, v);

            expendedora.AgregarLata(lat);

            Console.WriteLine("Lata ingresada");
        }

        private static void ExtraerLata(Expendedora expendedora)
        {
            try
            {
                Console.WriteLine("Ingrese el codigo: ");
                string c = Console.ReadLine();
                Console.WriteLine("Ingrese el dinero: ");
                double d = double.Parse(Console.ReadLine());

                expendedora.ExtraerLata(c, d);

                Console.WriteLine("Retire su pedido");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ObtenerBalance(Expendedora expendedora)
        {

        }

        /*private static void MostrarStock(Expendedora expendedora)
        {
            foreach (Lata item in expendedora.Latas)
            {
                string ficha = string.Format("{0} - {1} $ {2}", item.Nombre, item.Sabor, ToString());
                Console.WriteLine(ficha);
            }
        }*/

    }

}
