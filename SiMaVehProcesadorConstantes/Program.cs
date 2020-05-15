using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SiMaVehProcesadorConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Config

            int startId = 217;
            string nombreClaseConstante = "PartidoCorientes";

            //End config

            var infoLineas = new List<InfoLinea>();

            string inputPath = @"C:\Users\Alex Humar\Desktop\SMVCONSTANTES\Input.txt";
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(inputPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    infoLineas.Add(new InfoLinea
                    {
                        NombreConstante = CalcularNombreConstante(linea),
                        NombreOriginal = linea
                    });
                }
            }

            string outputConstantesPath = @"C:\Users\Alex Humar\Desktop\SMVCONSTANTES\Output_Constantes.txt";
            if (!File.Exists(outputConstantesPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(outputConstantesPath))
                {
                    foreach (var linea in infoLineas)
                    {
                        sw.WriteLine("/// <summary>");
                        sw.WriteLine($"/// {linea.NombreOriginal}");
                        sw.WriteLine("/// </summary>");
                        sw.WriteLine($"public const string {linea.NombreConstante} = \"{linea.NombreOriginal}\";");
                        sw.WriteLine(string.Empty);
                    }
                }
            }

            string outputDictionaryPath = @"C:\Users\Alex Humar\Desktop\SMVCONSTANTES\Output_Dictionary.txt";
            if (!File.Exists(outputDictionaryPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(outputDictionaryPath))
                {
                    foreach (var linea in infoLineas)
                    {
                        var stringToWrite = string.Format("/ {0}, {1}.{2} |,", startId, nombreClaseConstante, linea.NombreConstante);
                        sw.WriteLine(stringToWrite.Replace("/", "{").Replace("|", "}"));
                        startId++;
                    }
                }
            }
        }

        private static string CalcularNombreConstante(string linea)
        {
            var palabras = linea.Split(" ");
            var result = string.Empty;
            var textInfo = CultureInfo.InvariantCulture.TextInfo;

            foreach (var palabra in palabras)
            {
                result += ProcesarPalabra(textInfo.ToTitleCase(palabra));
            }

            return result;
        }

        private static string ProcesarPalabra(string palabra)
        {
            return palabra.Replace('á', 'a').Replace('é', 'e').Replace('í', 'i')
                .Replace('ó', 'o').Replace('ú', 'u').Replace('ñ', 'n');
        }
    }
}
