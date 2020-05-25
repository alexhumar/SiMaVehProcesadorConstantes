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

        public ResultadoGeneracionLoader GenerarArchivo(T infoEstructura, string directorioBase, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad, long startId)
        {
            string nombreClase = string.Concat(descripcionEntidad, infoEstructura.Cabecera.NombreConstante, "Loader");
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
            var resultadoGeneracionCuerpo = generadorCuerpoLoadersFactory
                .Get(infoEstructura, startId)
                .GenerarCuerpo(infoEstructura, tipoEntidad, descripcionEntidad, tipoSuperEntidad, descripcionSuperEntidad, nombreSuperEntidad);

            using (StreamWriter sw = File.CreateText(outputLoadersPath))
            {
                sw.Write(GetContenidoArchivo(template, tipoEntidad, nombreClase, tipoSuperEntidad, resultadoGeneracionCuerpo.Cuerpo));
            }

            return new ResultadoGeneracionLoader
            {
                FinishId = resultadoGeneracionCuerpo.FinishId
            };
        }

        protected abstract string GetSubdirectorioOutput();

        protected abstract string GetTemplateLoaderName();

        protected abstract string GetContenidoArchivo(string template, string tipoEntidad, string nombreClase, string tipoSuperEntidad, string cuerpo);
    }
}
