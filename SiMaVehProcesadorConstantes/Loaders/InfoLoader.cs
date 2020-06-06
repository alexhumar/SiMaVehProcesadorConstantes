using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Loaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Models.Interfaces;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;
using System.Globalization;
using System.IO;

namespace SiMaVehProcesadorConstantes.Loaders
{
    public abstract class InfoLoader<T, S> : IInfoLoader<T> where T : IInfoEstructura<S>, new()
    {
        protected readonly IProcesadorNombreConstante procesadorConstante;

        public InfoLoader(IProcesadorNombreConstante procesadorConstante)
        {
            this.procesadorConstante = procesadorConstante;
        }

        public T LoadInfo(string directorioBase, string nombreCabecera)
        {
            var result = new T
            {
                Cabecera = new InfoLinea
                {
                    NombreConstante = procesadorConstante.ProcesarNombreConstante(nombreCabecera),
                    NombreOriginal = nombreCabecera
                }
            };

            var inputPath = Path.Combine(directorioBase, Procesamiento.SubdirectorioProcesamiento, nombreCabecera);
            var inputFile = Path.Combine(inputPath, GetNombreInputFile());
            string linea;

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(inputFile))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    result.AgregarUnidad(CrearUnidadInfoEstructura(sr, linea));
                }
            }

            return result;
        }

        protected InfoLinea CrearInfoLinea(string linea)
        {
            var textInfo = CultureInfo.InvariantCulture.TextInfo;
            var lineaTitleCase = textInfo.ToTitleCase(linea);

            return new InfoLinea
            {
                NombreConstante = procesadorConstante.ProcesarNombreConstante(lineaTitleCase),
                NombreOriginal = lineaTitleCase
            };
        }

        //TODO: ver si se puede pasar a una nueva estructura de clases
        protected abstract S CrearUnidadInfoEstructura(StreamReader sr, string linea);

        protected abstract string GetNombreInputFile();
    }
}
