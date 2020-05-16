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

            int startId = 497;
            string nombreClaseConstante = "PartidoTucuman";
            string baseDirectory = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "SmvConstantesProcesadas"); ;

            //End config

            var infoLineas = new List<InfoLinea>();

            string inputPath = Path.Combine(baseDirectory, "Input.txt");
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

            string outputConstantesPath = Path.Combine(baseDirectory, "Output_Constantes.txt");
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

            string outputDictionaryPath = Path.Combine(baseDirectory, "Output_Dictionary.txt");
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
            return palabra
                .Replace('á', 'a')
                .Replace('é', 'e')
                .Replace('í', 'i')
                .Replace('ó', 'o')
                .Replace('ú', 'u')
                .Replace('ä', 'a')
                .Replace('ë', 'e')
                .Replace('ï', 'i')
                .Replace('ö', 'o')
                .Replace('ü', 'u')
                .Replace('Á', 'A')
                .Replace('É', 'E')
                .Replace('Í', 'I')
                .Replace('Ó', 'O')
                .Replace('Ú', 'U')
                .Replace('Ä', 'A')
                .Replace('Ë', 'E')
                .Replace('Ï', 'I')
                .Replace('Ö', 'O')
                .Replace('Ü', 'U')
                .Replace('ñ', 'n')
                .Replace('Ñ', 'N')
                .Replace(".", "");
        }
    }
}
