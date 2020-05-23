using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.IO;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionConstantes
{
    public abstract class GeneradorArchivoConstantes<T, S> : IGeneradorArchivoContantes<T> where T : IInfoEstructura<S>
    {
        private readonly GeneradorCuerpoConstantes generadorCuerpoConstantes;

        public GeneradorArchivoConstantes()
        {
            generadorCuerpoConstantes = new GeneradorCuerpoConstantes();
        }

        public void GenerarArchivo(string directorioBase, string tipoEntidad,
            string descripcionEntidad, string agrupacionEntidades, T infoEstructura)
        {
            string nombreClase = string.Concat(tipoEntidad, infoEstructura.Cabecera.NombreConstante);
            string outputConstantesPath = Path.Combine(directorioBase, Procesamiento.SubdirectorioOutput, $"{nombreClase}.cs");
            string templateFilePath = Path.Combine(directorioBase, Procesamiento.SubdirectorioTemplates, "TemplateConstante.txt");

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
            var contenido = generadorCuerpoConstantes.Generar(infoEstructura.GetLineas());

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(outputConstantesPath))
            {
                sw.Write(string.Format(template, agrupacionEntidades, string.Format(Procesamiento.SummaryConstanteTemplateText, descripcionEntidad, infoEstructura.Cabecera.NombreOriginal), nombreClase, contenido));
            }
        }
    }
}
