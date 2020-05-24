using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Loaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.Procesadores
{
    public class ProcesadorPartidos
    {
        private readonly IInfoLoader<InfoSubseccion> infoSubseccionLoader;
        private readonly IGeneradorArchivoContantes<InfoSubseccion> subseccionGeneradorArchivoConstantes;
        private readonly IGeneradorArchivoLoader<InfoSubseccion> subseccionGeneradorArchivoLoader;

        public ProcesadorPartidos(IInfoLoader<InfoSubseccion> infoSubseccionLoader,
            IGeneradorArchivoContantes<InfoSubseccion> subseccionGeneradorArchivoConstantes,
            IGeneradorArchivoLoader<InfoSubseccion> subseccionGeneradorArchivoLoader)
        {
            this.infoSubseccionLoader = infoSubseccionLoader;
            this.subseccionGeneradorArchivoConstantes = subseccionGeneradorArchivoConstantes;
            this.subseccionGeneradorArchivoLoader = subseccionGeneradorArchivoLoader;
        }

        public ResultadoGeneracionLoader ProcesarPartidos(string directorioBase, string nombreProvincia, long startId)
        {
            var infoPartidos = infoSubseccionLoader.LoadInfo(directorioBase, nombreProvincia);
            subseccionGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Partido", "Partidos", "SubdivisionesPais", infoPartidos);
            
            return subseccionGeneradorArchivoLoader.GenerarArchivo(infoPartidos, directorioBase, "Partido", "Provincia", "Argentina", startId);
        }
    }
}
