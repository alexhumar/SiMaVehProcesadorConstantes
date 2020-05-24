using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SubseccionGeneradorArchivoLoader : GeneradorArchivoLoader<InfoSubseccion, InfoLinea>
    {
        public SubseccionGeneradorArchivoLoader()
        {
        }

        protected override string GetSubdirectorioOutput()
        {
            return Procesamiento.SubdirectorioSubseccion;
        }
    }
}
