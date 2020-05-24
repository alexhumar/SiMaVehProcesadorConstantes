using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Models.Interfaces;
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

        protected string GenerarEntradaCuerpo(IInfoEstructura<InfoLinea> infoEstructura, string tipoEntidad, string tipoSuperEntidad, string valorSuperEntidad, bool finalizar = true)
        {
            var sbLoaders = new StringBuilder();
            var nombreClaseConstante = string.Concat(tipoEntidad, infoEstructura.Cabecera.NombreConstante);

            sbLoaders.AppendLine(string.Concat(Indent, $"dictionary.Add(fixture{tipoSuperEntidad}.FindByNombre({tipoSuperEntidad}{valorSuperEntidad}.{infoEstructura.Cabecera.NombreConstante}).Value.Key, new Dictionary<long, string>"));
            sbLoaders.AppendLine(string.Concat(Indent, "{"));

            foreach (var linea in infoEstructura.GetLineas())
            {
                var stringToWrite = string.Format("{{ {0}, {1}.{2} }},", CurrentId, nombreClaseConstante, linea.NombreConstante);
                sbLoaders.AppendLine(string.Concat(SubIndent, stringToWrite));
            }

            sbLoaders.AppendLine(finalizar ? string.Concat(Indent, "});") : string.Concat(Indent, "},"));

            return sbLoaders.ToString().TrimEnd();
        }

        public abstract ResultadoGeneracionCuerpoLoader GenerarCuerpo(T infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad);
    }
}
