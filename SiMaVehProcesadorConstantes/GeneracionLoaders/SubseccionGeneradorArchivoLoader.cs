using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SubseccionGeneradorArchivoLoader : GeneradorArchivoLoader<InfoSubseccion, InfoLinea>
    {
        protected override string GetContenidoArchivo(string template, string tipoEntidad, string nombreClase, string tipoSuperEntidad, string cuerpo)
        {
            return string.Format(template, nombreClase, cuerpo);
        }

        protected override string GetSubdirectorioOutput()
        {
            return Procesamiento.SubdirectorioSubseccion;
        }

        protected override string GetTemplateLoaderName()
        {
            return "TemplateLoaderSubseccion.txt";
        }
    }
}
