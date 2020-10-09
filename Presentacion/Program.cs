using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Afiliado afiliado = new Contributivo("deyner", 1003380104, 'M', 15, 'C', 31);
            Console.WriteLine(afiliado.CalcularLiquidacion(31, 15, 'M'));

            Afiliado afiliada = new Subsidiado("Anya", 105678789, 'F', 30, 'S', 31);
            Console.WriteLine(afiliada.CalcularLiquidacion(31, 30, 'F'));

            Console.ReadKey();

            /*int opc;
            do
            {
                Console.WriteLine("1. Registrar información para liquidar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Modificar");
                 Console.WriteLine("0. Terminar");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0: Console.WriteLine("Terminado"); break;
                    case 1: RegistrarInformacionLiquidacion(); break;
                    case 2: ConsultarLista(); break;
                    case 3: Eliminar(); break;
                    case 4: Modificar(); break;
                    default: Console.WriteLine("Opcion no valida"); break;
                }
            } while (opc != 0);*/
        }

        static void RegistrarInformacionLiquidacion()
        {

        }

        static void ConsultarLista()
        {

        }

        static void Eliminar()
        {

        }

        static void Modificar()
        {

        }
    }
}
