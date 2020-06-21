using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using System.Linq;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class MarcaGeneradorCuerpoLoader : IGeneradorCuerpoLoader<InfoMarca>
    {
        private string indent;
        protected string Indent
        {
            get
            {
                if (string.IsNullOrEmpty(indent))
                {
                    indent = string.Empty.PadLeft(12);
                }

                return indent;
            }
        }

        protected string GenerarEntradaCuerpo(InfoMarca marcas, string tipoEntidad, string descripcionEntidad)
        {
            var sbLoaders = new StringBuilder();
            var marcaId = 1;
            var templateLineaCuerpo = "marcas.Add(datosEntidadBuilder.Build({0}, Constants.Marcas.Marca.{1}, new List<DatosEntidad> {{ {2} }}));";

            foreach (var infoMarca in marcas.InfoMarcas)
            {
                var stringToWrite = string.Format(templateLineaCuerpo, marcaId, infoMarca.Cabecera.NombreConstante, string.Join(", ", infoMarca.Unidades.Select(u => u.NombreOriginal)));
                sbLoaders.AppendLine(string.Concat(Indent, stringToWrite));
                marcaId++;
            }

            return sbLoaders.ToString().TrimEnd();
        }

        public ResultadoGeneracionCuerpoLoader GenerarCuerpo(InfoMarca infoEstructura, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad)
        {
            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = GenerarEntradaCuerpo(infoEstructura, tipoEntidad, descripcionEntidad)
            };
        }
    }
}
