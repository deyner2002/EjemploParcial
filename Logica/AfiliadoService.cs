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

        public LiquidacionConsultaResponse Consultar()
        {
            try
            {
                List<Afiliado> afiliados = afiliadoRepository.ConsultarTodos();
                var response = new LiquidacionConsultaResponse(afiliados);
                return response;
            }
            catch (Exception e)
            {
                var response = new LiquidacionConsultaResponse("Error de Aplicacion:" + e.Message);
                return response;
            }

        }

    }
    public class LiquidacionConsultaResponse
    {
        public List<Afiliado> Afiliados { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public LiquidacionConsultaResponse(string message)
        {
            Error = true;
            Message = message;
        }
        public LiquidacionConsultaResponse(List<Afiliado> afiliados)
        {
            Afiliados = afiliados;
            Error = false;
        }
    }
}

