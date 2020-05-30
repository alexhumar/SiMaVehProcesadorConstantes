using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.Linq;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public abstract class GeneradorCuerpoLoader<T, S> : IGeneradorCuerpoLoader<T> where T : IInfoEstructura<S>
    {
        private readonly object myLock = new object();

        private long currentId;
        protected long CurrentId
        {
            get
            {
                lock (myLock)
                {
                    return currentId++;
                }
            }
            set
            {
                currentId = value;
            }
        }

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

        private string subIndent;
        protected string SubIndent
        {
            get
            {
                if (string.IsNullOrEmpty(subIndent))
                {
                    subIndent = string.Empty.PadLeft(16);
                }

                return subIndent;
            }
        }

        public GeneradorCuerpoLoader(long currentId)
        {
            CurrentId = currentId;
        }

        protected string GenerarEntradaCuerpo(IInfoEstructura<InfoLinea> infoEstructura, string tipoEntidad, string descripcionEntidad, string valorEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string valorSuperEntidad)
        {
            var sbLoaders = new StringBuilder();
            var nombreClaseConstante = string.Concat(tipoEntidad, valorEntidad);
            var lineasPendientesProcesar = infoEstructura.GetLineas().Count();

            sbLoaders.AppendLine(string.Concat(Indent, $"{descripcionEntidad.ToLower()}.Add({tipoSuperEntidad.ToLower()}FixtureGetter.FindByNombre({tipoSuperEntidad}{valorSuperEntidad}.{infoEstructura.Cabecera.NombreConstante}).Id, new List<DatosEntidad>"));
            sbLoaders.AppendLine(string.Concat(Indent, "{"));

            foreach (var linea in infoEstructura.GetLineas())
            {
                lineasPendientesProcesar--;
                var stringToWrite = string.Format("datosEntidadBuilder.Build({0}, {1}.{2}){3}", CurrentId, nombreClaseConstante, linea.NombreConstante, lineasPendientesProcesar > 0 ? "," : string.Empty);
                sbLoaders.AppendLine(string.Concat(SubIndent, stringToWrite));
            }

            sbLoaders.AppendLine(string.Concat(Indent, "});"));

            return sbLoaders.ToString().TrimEnd();
        }

        public abstract ResultadoGeneracionCuerpoLoader GenerarCuerpo(T infoEstructura, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad);
    }
}
