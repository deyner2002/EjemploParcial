using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Subsidiado : Afiliado
    {
        public Subsidiado(string nombre, int identificacion, char sexo, int edad, char regimen, int diasAfiliacion) : base(nombre, identificacion, sexo, edad, regimen, diasAfiliacion)
        {
        }

        public override double CalcularLiquidacion(int diasAfiliacion, int edad,char sexo)
        {
            double liquidacion = 0;
            if (edad < 1)
            {
                liquidacion = diasAfiliacion * 2000 * 2;
            }
            else
            {
                if (edad <= 15)
                {
                    liquidacion = diasAfiliacion * 2000 *0.8;
                }
                else
                {
                    if (edad <= 18)
                    {
                        if (sexo == 'F')
                        {
                            liquidacion = diasAfiliacion * 2000 * 0.3;
                        }
                        else
                        {
                            liquidacion = diasAfiliacion * 2000 * 0.2;
                        }
                        
                    }
                    else
                    {
                        if (edad <= 44)
                        {
                            liquidacion = diasAfiliacion * 2000 * 1;
                        }
                        else
                        {
                            if (edad <= 69)
                            {
                                liquidacion = diasAfiliacion * 2000 * 2.5;
                            }
                            else
                            {
                                liquidacion = diasAfiliacion * 2000 * 3;
                            }
                        }
                    }
                }
            }
            return liquidacion;
        
        }
    }
}
