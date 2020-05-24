using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models.Interfaces;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public abstract class GeneradorCuerpoLoaders<T, S> : IGeneradorCuerpoLoader<T> where T : IInfoEstructura<S>
    {
        //TODO: ver como manejar este ID.
        public static long StartId { get; set; }

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

        public GeneradorCuerpoLoaders()
        {
            StartId = 1;
        }

        public abstract string GenerarCuerpo(T infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad);
    }
}
