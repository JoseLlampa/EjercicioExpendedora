using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            string pantalla = "CO1 - Coca Cola Regular \nCO2 - Coca Cola Zero \nSP1 - Sprite Regular \nSP2 - Sprite Zero \nFA1 - Fanta Regular \nFA2 - Fanta Zero";

            string menu = "1) Extraer Lata \n2)Ingresar Lata \n3) Obtener Balance \n4) Mostrar Stock \nX) Salir";

            Expendedora bebidas = new Expendedora(true);

            Console.WriteLine(pantalla);

            if (bebidas.Encendida)
            {
                Console.WriteLine(menu);

                string opcionSeleccionada = Console.ReadLine();

                
                switch (opcionSeleccionada)
                {
                    case "1":
                        Program.ExtraerLata(bebidas);
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
                     
            } 

            Console.ReadKey();
        }

        private static void IngresarLata (Expendedora expendedora)
        {
           
        }

        private static void ExtraerLata(Expendedora expendedora)
        {
            Console.WriteLine("Ingrese el codigo: ");
            string c = Console.ReadLine();
            Console.WriteLine("Ingrese el dinero: ");
            double d = double.Parse(Console.ReadLine());

            expendedora.ExtraerLata(c,d);
        }

        private static void ObtenerBalance(Expendedora expendedora)
        {

        }

        private static void MostrarStock(Expendedora expendedora)
        {

        }

    }

}
