using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SeccionGeneradorArchivoLoader : GeneradorArchivoLoader<InfoSeccion, InfoSubseccion>
    {
        protected override string GetContenidoArchivo(string template, string tipoEntidad, string nombreClase, string tipoSuperEntidad, string cuerpo)
        {
            return string.Format(template, nombreClase, cuerpo);
        }

        protected override string GetSubdirectorioOutput()
        {
            return Procesamiento.SubdirectorioSeccion;
        }

        protected override string GetTemplateLoaderName()
        {
            return "TemplateLoaderSeccion.txt";
        }
    }
}
