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

    }
}
