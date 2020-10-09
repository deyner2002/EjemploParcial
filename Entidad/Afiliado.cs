using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class  Afiliado
    {
        int numero=1;
        public Afiliado(string nombre, int identificacion, char sexo, int edad, char regimen, int diasAfiliacion)
        {
            Nombre = nombre;
            this.identificacion = identificacion;
            Sexo = sexo;
            Edad = edad;
            Regimen = regimen;
            DiasAfiliacion = diasAfiliacion;
           Numero = numero;
            numero++;
        }

        public int Numero { get; set; }
        public string Nombre { get; set; }
        public int identificacion { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public char Regimen { get; set; }
        public int DiasAfiliacion { get; set; }
        public double LiquidacionMensual { get; set; }

        public abstract double CalcularLiquidacion(int diasAfiliacion,int edad,char sexo);
    }
}
