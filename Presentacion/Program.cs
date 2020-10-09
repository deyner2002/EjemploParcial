using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Logica;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int opc;
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
            } while (opc != 0);
        }

        static void RegistrarInformacionLiquidacion()
        {
            int diasAfiliacion, identificacion, edad, regimen,numero;
            String nombre;
            char sexo;

            Console.WriteLine("Numero de liquidacion: "); numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Identificación: "); identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombre: "); nombre = Console.ReadLine();
            Console.WriteLine("Edad: "); edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Sexo: "); sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Dias afiliacion: "); diasAfiliacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Regimen: ");
            do
            {
                Console.WriteLine("1. subsidiado");
                Console.WriteLine("2. contributivo");
                regimen = int.Parse(Console.ReadLine());
            } while ((regimen != 1) && (regimen != 2));
            if (regimen == 1 )
            {
                Afiliado afiliado = new Subsidiado(numero,nombre, identificacion, sexo, edad, 'S', diasAfiliacion);
                afiliado.LiquidacionMensual = afiliado.CalcularLiquidacion(diasAfiliacion, edad, sexo);
                AfiliadoService afiliadoService = new AfiliadoService();
                 Console.WriteLine(afiliadoService.Guardar(afiliado));
                

            }
            else
            {
                Afiliado afiliado = new Contributivo(numero,nombre, identificacion, sexo, edad, 'C', diasAfiliacion);
                afiliado.LiquidacionMensual=afiliado.CalcularLiquidacion(diasAfiliacion, edad, sexo);
                AfiliadoService afiliadoService = new AfiliadoService();
                Console.WriteLine(afiliadoService.Guardar(afiliado));
             }



        }

        static void ConsultarLista()
        {
            AfiliadoService afiliadoService = new AfiliadoService();
            LiquidacionConsultaResponse consultaResponse = afiliadoService.Consultar();
            if (consultaResponse.Error)
            {
                Console.WriteLine(consultaResponse.Message);

            }
            else
            {
                foreach (var item in consultaResponse.Afiliados)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            Console.ReadKey();
        }

        static void Eliminar()
        {
            int numeroLiquidacion;
            Console.WriteLine("Escriba el numero de liquidacion: "); numeroLiquidacion = int.Parse(Console.ReadLine());
            AfiliadoService afiliadoService = new AfiliadoService();
            try
            {
                Console.WriteLine(afiliadoService.Eliminar(numeroLiquidacion));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            
        }

        static void Modificar()
        {

        }
    }
}
