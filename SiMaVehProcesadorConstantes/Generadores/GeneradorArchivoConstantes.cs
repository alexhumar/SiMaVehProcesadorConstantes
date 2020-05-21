using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SiMaVehProcesadorConstantes.Generadores
{
    public class GeneradorArchivoConstantes
    {
        private readonly GeneradorCuerpoConstantes generadorCuerpoConstantes;

        public GeneradorArchivoConstantes()
        {
            generadorCuerpoConstantes = new GeneradorCuerpoConstantes();
        }

        public void GenerarArchivo(string directorioBase, string summaryClase,
            string nombreClase, List<InfoLinea> infoLineas)
        {
            string outputConstantesPath = Path.Combine(directorioBase, "SmvOutputConstantes", $"{nombreClase}.cs");
            string templateFilePath = Path.Combine(directorioBase, "SmvTemplates", "TemplaceConstante.txt");

            if (File.Exists(outputConstantesPath))
            {
                File.Delete(outputConstantesPath);
            }

            var sbTemplate = new StringBuilder();

            using (StreamReader sr = File.OpenText(templateFilePath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    sbTemplate.AppendLine(linea);
                }
            }

            var template = sbTemplate.ToString();
            var constantes = generadorCuerpoConstantes.Generar(infoLineas);


            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(outputConstantesPath))
            {
                sw.Write(string.Format(template, summaryClase, nombreClase, constantes));
            }
        }
    }
}
