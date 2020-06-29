using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class MonedaGeneradorCuerpoLoader : IGeneradorCuerpoLoader<InfoMoneda>
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

        protected string GenerarEntradaCuerpo(InfoMoneda infoMoneda, string tipoEntidad, string descripcionEntidad)
        {
            var sbLoaders = new StringBuilder();
            var templateLineaCuerpo = "monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.CodigoISOMoneda.{0}, Constants.Monedas.Moneda.{1}));";
            var lineasInfoMoneda = infoMoneda.InfoMonedas.GetLineas();
            var lineasInfoCodMoneda = infoMoneda.InfoCodsMonedas.GetLineas();

            foreach (var lineaInfoMoneda in lineasInfoMoneda)
            {
                //Asocio los elementos de las colecciones por su orden...
                var lineaInfoCodMoneda = lineasInfoCodMoneda[lineasInfoMoneda.IndexOf(lineaInfoMoneda)];
                var stringToWrite = string.Format(templateLineaCuerpo, lineaInfoCodMoneda.NombreConstante, lineaInfoMoneda.NombreConstante);
                sbLoaders.AppendLine(string.Concat(Indent, stringToWrite));
            }

            return sbLoaders.ToString().TrimEnd();
        }

        public ResultadoGeneracionCuerpoLoader GenerarCuerpo(InfoMoneda infoEstructura, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad)
        {
            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = GenerarEntradaCuerpo(infoEstructura, tipoEntidad, descripcionEntidad)
            };
        }
    }
}
