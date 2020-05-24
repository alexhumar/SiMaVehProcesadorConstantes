using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Factories;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.IO;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public abstract class GeneradorArchivoLoader<T, S> : IGeneradorArchivoLoader<T> where T : IInfoEstructura<S>
    {
        protected readonly GeneradorCuerpoLoadersFactory<T, S> generadorCuerpoLoadersFactory;

        public GeneradorArchivoLoader()
        {
            generadorCuerpoLoadersFactory = new GeneradorCuerpoLoadersFactory<T, S>();
        }

        public ResultadoGeneracionLoader GenerarArchivo(T infoEstructura, string directorioBase, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad, long startId)
        {
            string nombreClase = string.Concat(infoEstructura.Cabecera.NombreConstante, "Loader");
            string outputLoadersPath = Path.Combine(directorioBase, Procesamiento.SubdirectorioOutput, GetSubdirectorioOutput(), $"{nombreClase}.cs");
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
            var resultadoGeneracionCuerpo = generadorCuerpoLoadersFactory
                .Get(infoEstructura, startId)
                .GenerarCuerpo(infoEstructura, tipoEntidad, tipoSuperEntidad, nombreSuperEntidad);

            using (StreamWriter sw = File.CreateText(outputLoadersPath))
            {
                sw.Write(string.Format(template, tipoEntidad, nombreClase, tipoSuperEntidad, resultadoGeneracionCuerpo.Cuerpo));
            }

            return new ResultadoGeneracionLoader
            {
                FinishId = resultadoGeneracionCuerpo.FinishId
            };
        }

        protected abstract string GetSubdirectorioOutput();
    }
}
