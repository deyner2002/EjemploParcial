using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class AfiliadoRepository
    {
        private string fileName = "Afiliados.txt";
        public void Guardar(Afiliado afiliado)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(afiliado.DameDatosFormatoArchivo());
            writer.Close();
            file.Close();
        }

        public List<Afiliado> ConsultarTodos()
        {
            List<Afiliado> lista = new List<Afiliado>();
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Afiliado afiliado = Map(linea);
                lista.Add(afiliado);
            }
            reader.Close();
            file.Close();
            return lista;
        }

        private Afiliado Map(string linea)
        {
            Afiliado afiliado;
            char delimeter = ';';
            string[] vectorLiquidacion = linea.Split(delimeter);
            if (vectorLiquidacion[5] == "C")
            {
                afiliado = new Contributivo();
            }
            else
            {
                afiliado = new Subsidiado();
            }
            afiliado.Regimen = char.Parse(vectorLiquidacion[5]);
            afiliado.Numero = int.Parse(vectorLiquidacion[0]);
            afiliado.Identificacion = int.Parse(vectorLiquidacion[1]);
            afiliado.Nombre = vectorLiquidacion[2];
            afiliado.Edad = int.Parse(vectorLiquidacion[3]);
            afiliado.Sexo = char.Parse(vectorLiquidacion[4]);
            afiliado.DiasAfiliacion = int.Parse(vectorLiquidacion[6]);
            afiliado.LiquidacionMensual = double.Parse(vectorLiquidacion[7]);
            return afiliado;
        }
    }
}
