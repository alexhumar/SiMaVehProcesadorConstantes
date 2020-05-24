using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Loaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.Procesadores
{
    public class ProcesadorLocalidades
    {
        private readonly IInfoLoader<InfoSeccion> infoSeccionLoader;
        private readonly IGeneradorArchivoContantes<InfoSeccion> seccionGeneradorArchivoConstantes;
        private readonly IGeneradorArchivoLoader<InfoSeccion> seccionGeneradorArchivoLoader;

        public ProcesadorLocalidades(IInfoLoader<InfoSeccion> infoSeccionLoader,
            IGeneradorArchivoContantes<InfoSeccion> seccionGeneradorArchivoConstantes,
            IGeneradorArchivoLoader<InfoSeccion> seccionGeneradorArchivoLoader)
        {
            this.infoSeccionLoader = infoSeccionLoader;
            this.seccionGeneradorArchivoConstantes = seccionGeneradorArchivoConstantes;
            this.seccionGeneradorArchivoLoader = seccionGeneradorArchivoLoader;
        }

        public ResultadoGeneracionLoader ProcesarLocalidades(string directorioBase, string nombreProvincia, long startId)
        {
            var infoLocalidadesPartido = infoSeccionLoader.LoadInfo(directorioBase, nombreProvincia);
            seccionGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Localidad", "Localidades", "SubSubdivisionesPais", infoLocalidadesPartido);

            return seccionGeneradorArchivoLoader.GenerarArchivo(infoLocalidadesPartido, directorioBase, "Localidad", "Partido", nombreProvincia, startId);
        }
    }
}
