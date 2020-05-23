using SiMaVehProcesadorConstantes.GeneracionConstantes;
using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.Loaders;
using SiMaVehProcesadorConstantes.Loaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Procesadores;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;
using System.IO;

namespace SiMaVehProcesadorConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region config

            int startId = 217;
            string nombreClaseConstante = "PartidoCorrientes";
            string baseDirectory = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string baseInputDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "SmvConstantesProcesadas");

            #endregion

            #region dependencias

            IProcesadorNombreConstante procesadorConstante = new ProcesadorNombreConstante();
            IInfoLoader<InfoSubseccion> infoSubseccionLoader = new SubseccionInfoLoader(procesadorConstante);
            IInfoLoader<InfoSeccion> infoSeccionLoader = new SeccionInfoLoader(procesadorConstante);
            IGeneradorArchivoContantes<InfoSubseccion> subseccionGeneradorArchivoConstantes = new SubseccionGeneradorArchivoConstantes();
            IGeneradorArchivoContantes<InfoSeccion> seccionGeneradorArchivoConstantes = new SeccionGeneradorArchivoConstantes();

            #endregion

            var infoPartidos = infoSubseccionLoader.LoadInfo(baseDirectory, "Buenos Aires");
            var infoLocalidadesPartido = infoSeccionLoader.LoadInfo(baseDirectory, "Buenos Aires");

            subseccionGeneradorArchivoConstantes.GenerarArchivo(baseDirectory, "Partido", "Partidos", "SubdivisionesPais", infoPartidos);
            seccionGeneradorArchivoConstantes.GenerarArchivo(baseDirectory, "Localidad", "Localidades", "SubSubdivisionesPais", infoLocalidadesPartido);

            //TODO: aca probar la parte de generacion de archivos de loaders. Cuando este...
        }
    }
}
