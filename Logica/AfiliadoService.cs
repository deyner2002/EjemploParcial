using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class AfiliadoService
    {
        AfiliadoRepository afiliadoRepository;
        public AfiliadoService()
        {
             afiliadoRepository= new AfiliadoRepository();
        }

        public string Guardar(Afiliado afiliado)
        {
            try
            {
                afiliadoRepository.Guardar(afiliado);
                return "se guardó la informacion satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }
  
    }
}
