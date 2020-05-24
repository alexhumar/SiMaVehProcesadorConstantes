using SiMaVehProcesadorConstantes.GeneracionConstantes;
using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
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
            IGeneradorArchivoLoader<InfoSubseccion> subseccionGeneradorArchivoLoader = new SubseccionGeneradorArchivoLoader();
            IGeneradorArchivoLoader<InfoSeccion> seccionGeneradorArchivoLoader = new SeccionGeneradorArchivoLoader();

            #endregion

            var infoPartidos = infoSubseccionLoader.LoadInfo(baseDirectory, "Buenos Aires");
            var infoLocalidadesPartido = infoSeccionLoader.LoadInfo(baseDirectory, "Buenos Aires");

            subseccionGeneradorArchivoConstantes.GenerarArchivo(baseDirectory, "Partido", "Partidos", "SubdivisionesPais", infoPartidos);
            seccionGeneradorArchivoConstantes.GenerarArchivo(baseDirectory, "Localidad", "Localidades", "SubSubdivisionesPais", infoLocalidadesPartido);

            subseccionGeneradorArchivoLoader.GenerarArchivo(infoPartidos, baseDirectory, "Partido", "Provincia", "Argentina", 0);
            seccionGeneradorArchivoLoader.GenerarArchivo(infoLocalidadesPartido, baseDirectory, "Localidad", "Partido", "Buenos Aires", 0);
        }
    }
}
