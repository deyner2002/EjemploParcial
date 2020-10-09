using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Contributivo : Afiliado
    {
        public Contributivo(string nombre, int identificacion, char sexo, int edad, char regimen, int diasAfiliacion) : base(nombre, identificacion, sexo, edad, regimen, diasAfiliacion)
        {

        }

        public override double CalcularLiquidacion(int diasAfiliacion, int edad,char sexo)
        {
            double liquidacion=0;
            if (edad < 1)
            {
                liquidacion = diasAfiliacion * 2400 * 2.5;
            }
            else
            {
                if (edad <= 15)
                {
                    liquidacion = diasAfiliacion * 2400 * 0.9;
                }
                else
                {
                    if (edad <= 18)
                    {
                        liquidacion = diasAfiliacion * 2400 * 0.3;
                    }
                    else
                    {
                        if (edad <= 44)
                        {
                            liquidacion = diasAfiliacion * 2400 * 1.5;
                        }
                        else
                        {
                            if (edad <= 69)
                            {
                                liquidacion = diasAfiliacion * 2400 * 3;
                            }
                            else
                            {
                                liquidacion = diasAfiliacion * 2400 * 3.5;
                            }
                        }
                    }
                }
            }
            return liquidacion;
        }
    }
}
