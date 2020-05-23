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

            //TODO: Implementar en clase aparte

            //string outputDictionaryPath = Path.Combine(baseInputDirectory, "Output_Dictionary.txt");
            //if (!File.Exists(outputDictionaryPath))
            //{
            //    // Create a file to write to.
            //    using (StreamWriter sw = File.CreateText(outputDictionaryPath))
            //    {
            //        foreach (var linea in infoLineas)
            //        {
            //            var stringToWrite = string.Format("/ {0}, {1}.{2} |,", startId, nombreClaseConstante, linea.NombreConstante);
            //            sw.WriteLine(stringToWrite.Replace("/", "{").Replace("|", "}"));
            //            startId++;
            //        }
            //    }
            //}
        }
    }
}
