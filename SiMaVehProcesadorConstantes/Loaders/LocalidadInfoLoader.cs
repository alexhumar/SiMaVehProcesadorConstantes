using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;

namespace SiMaVehProcesadorConstantes.Loaders
{
    public class LocalidadInfoLoader : SeccionInfoLoader
    {
        public LocalidadInfoLoader(IProcesadorNombreConstante procesadorConstante)
            : base(procesadorConstante)
        {
        }

        protected override string GetNombreInputFile()
        {
            return Procesamiento.NombreArchivoSeccion;
        }

        protected override string GetMarcadorCorteControl()
        {
            return Procesamiento.MarcadorCorteControlLocalidades;
        }
    }
}
