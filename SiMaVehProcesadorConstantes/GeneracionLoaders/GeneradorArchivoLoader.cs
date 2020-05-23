using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.IO;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public abstract class GeneradorArchivoLoader<T, S> : IGeneradorArchivoLoader<T> where T : IInfoEstructura<S>
    {
        protected readonly GeneradorCuerpoLoaders generadorCuerpoLoaders;

        public GeneradorArchivoLoader()
        {
            generadorCuerpoLoaders = new GeneradorCuerpoLoaders();
        }

        public void GenerarArchivo(string directorioBase, string tipoEntidad, T infoEstructura)
        {
            string nombreClase = string.Concat(infoEstructura.Cabecera.NombreConstante, "Loader");
            string outputLoadersPath = Path.Combine(directorioBase, Procesamiento.SubdirectorioOutput, $"{nombreClase}.cs");
            string templateFilePath = Path.Combine(directorioBase, Procesamiento.SubdirectorioTemplates, "TemplateLoader.txt");

            if (File.Exists(outputLoadersPath))
            {
                File.Delete(outputLoadersPath);
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
            var contenido = generadorCuerpoLoaders.Generar(infoEstructura, tipoEntidad);

            using (StreamWriter sw = File.CreateText(outputLoadersPath))
            {
                sw.Write(string.Format(template, tipoEntidad, nombreClase, "A determinar como lo calculo", contenido));
            }
        }

        /*
         
        public void GenerarArchivo(string directorioBase, string tipoEntidad,
            string descripcionEntidad, string agrupacionEntidades, T infoEstructura)
        {
            string nombreClase = string.Concat(tipoEntidad, infoEstructura.Cabecera.NombreConstante);
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
            var constantes = generadorCuerpoConstantes.Generar(infoEstructura.GetLineas());

            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(outputConstantesPath))
            {
                sw.Write(string.Format(template, agrupacionEntidades, string.Format(Procesamiento.SummaryConstanteTemplateText, descripcionEntidad, infoEstructura.Cabecera.NombreOriginal), nombreClase, constantes));
            }
        }

         */
    }
}
