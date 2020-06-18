using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;

namespace SiMaVehProcesadorConstantes.Loaders
{
    public class MarcaInfoLoader : SeccionInfoLoader
    {
        public MarcaInfoLoader(IProcesadorNombreConstante procesadorConstante)
            : base(procesadorConstante)
        {
        }

        protected override string GetNombreInputFile()
        {
            return Procesamiento.NombreArchivoMarca;
        }

        protected override string GetMarcadorCorteControl()
        {
            return Procesamiento.MarcadorCorteControlMarcas;
        }
    }
}
