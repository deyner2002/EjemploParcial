using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public abstract class  Afiliado
    {
        
        public Afiliado(int numero,string nombre, int identificacion, char sexo, int edad, char regimen, int diasAfiliacion)
        {
            Nombre = nombre;
            this.Identificacion = identificacion;
            Sexo = sexo;
            Edad = edad;
            Regimen = regimen;
            DiasAfiliacion = diasAfiliacion;
            Numero = numero;
         }

        public Afiliado()
        {

        }

        public int Numero { get; set; }
        public string Nombre { get; set; }
        public int Identificacion { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public char Regimen { get; set; }
        public int DiasAfiliacion { get; set; }
        public double LiquidacionMensual { get; set; }

        public abstract double CalcularLiquidacion(int diasAfiliacion,int edad,char sexo);

        public string DameDatosFormatoArchivo()
        {
            return Numero + ";" + Identificacion + ";" + Nombre + ";" + Edad + ";" + Sexo + ";" + Regimen+";"+DiasAfiliacion+";"+LiquidacionMensual;
        }

        public override string ToString()
        {
            return $"numero liquidacion:{Numero}-Identificacion: {Identificacion}-Nombre: {Nombre}-Sexo: {Sexo}-edad: {Edad}- Regimen: {Regimen}-Dias de afiliacion: {DiasAfiliacion}-valor liquidacion: {LiquidacionMensual} ";
        }
    }
}
