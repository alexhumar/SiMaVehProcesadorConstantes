using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;
using System.IO;

namespace SiMaVehProcesadorConstantes.Loaders
{
    public class MonedaInfoLoader : InfoLoader<InfoSubseccion, InfoLinea>
    {
        public MonedaInfoLoader(IProcesadorNombreConstante procesadorConstante)
            : base(procesadorConstante)
        {
        }

        protected override InfoLinea CrearUnidadInfoEstructura(StreamReader sr, string linea)
        {
            return CrearInfoLinea(linea);
        }

        protected override string GetNombreInputFile()
        {
            return Procesamiento.NombreArchivoMoneda;
        }
    }
}
