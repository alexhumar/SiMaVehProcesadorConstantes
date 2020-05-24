using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SeccionGeneradorArchivoLoader : GeneradorArchivoLoader<InfoSeccion, InfoSubseccion>
    {
        public SeccionGeneradorArchivoLoader()
        {
        }

        protected override string GetSubdirectorioOutput()
        {
            return Procesamiento.SubdirectorioSeccion;
        }
    }
}
