using SiMaVehProcesadorConstantes.Generadores;
using SiMaVehProcesadorConstantes.Procesadores;
using System.Collections.Generic;
using System.IO;

namespace SiMaVehProcesadorConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Config

            int startId = 217;
            string nombreClaseConstante = "PartidoCorrientes";
            string baseDirectory = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string baseInputDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "SmvConstantesProcesadas");

            //End config

            // Dependencies

            var procesadorConstante = new ProcesadorNombreConstante();
            var generadorArchivoConstantes = new GeneradorArchivoConstantes();

            // End dependencies

            var infoLineas = new List<InfoLinea>();

            string inputPath = Path.Combine(baseInputDirectory, "Input.txt");
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(inputPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    infoLineas.Add(new InfoLinea
                    {
                        NombreConstante = procesadorConstante.ProcesarNombreConstante(linea),
                        NombreOriginal = linea
                    });
                }
            }

            generadorArchivoConstantes.GenerarArchivo(baseDirectory, 
                "Constante de nombres de Localidades de Buenos Aires", "LocalidadBuenosAires", infoLineas);

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
