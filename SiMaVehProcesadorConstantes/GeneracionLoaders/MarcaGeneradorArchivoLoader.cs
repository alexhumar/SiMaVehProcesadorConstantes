using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using System.IO;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class MarcaGeneradorArchivoLoader : IGeneradorArchivoLoader<InfoMarca>
    {
        private readonly MarcaGeneradorCuerpoLoader marcaGeneradorCuerpoLoader;

        public MarcaGeneradorArchivoLoader()
        {
            marcaGeneradorCuerpoLoader = new MarcaGeneradorCuerpoLoader();
        }

        public ResultadoGeneracionLoader GenerarArchivo(InfoMarca infoEstructura, string directorioBase, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad = null, string descripcionSuperEntidad = null, string nombreSuperEntidad = null, long startId = 0)
        {
            string nombreClase = string.Concat(tipoEntidad, "FixtureGetter");
            string outputLoadersPath = Path.Combine(directorioBase, Procesamiento.SubdirectorioOutput, GetSubdirectorioOutput(), $"{nombreClase}.cs");
            string templateFilePath = Path.Combine(directorioBase, Procesamiento.SubdirectorioTemplates, GetTemplateLoaderName());

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
            var resultadoGeneracionCuerpo = marcaGeneradorCuerpoLoader.GenerarCuerpo(infoEstructura, tipoEntidad, descripcionEntidad, null, null, null);

            using (StreamWriter sw = File.CreateText(outputLoadersPath))
            {
                sw.Write(GetContenidoArchivo(template, nombreClase, resultadoGeneracionCuerpo.Cuerpo));
            }

            return new ResultadoGeneracionLoader
            {
                FinishId = resultadoGeneracionCuerpo.FinishId
            };
        }

        protected string GetContenidoArchivo(string template, string nombreClase, string cuerpo)
        {
            return string.Format(template, nombreClase, cuerpo);
        }

        protected string GetSubdirectorioOutput()
        {
            return Procesamiento.SubdirectorioMarca;
        }

        protected string GetTemplateLoaderName()
        {
            return "TemplateLoaderMarca.txt";
        }
    }
}
