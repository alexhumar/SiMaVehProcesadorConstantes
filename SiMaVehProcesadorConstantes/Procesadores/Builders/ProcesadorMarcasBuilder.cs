using SiMaVehProcesadorConstantes.Builders;
using SiMaVehProcesadorConstantes.GeneracionConstantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.Loaders;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;

namespace SiMaVehProcesadorConstantes.Procesadores.Builders
{
    public class ProcesadorMarcasBuilder : IProcesadorBuilder<ProcesadorMarcas>
    {
        private readonly IProcesadorNombreConstante procesadorConstante;

        public ProcesadorMarcasBuilder(IProcesadorNombreConstante procesadorConstante)
        {
            this.procesadorConstante = procesadorConstante;
        }

        public ProcesadorMarcas BuildProcesador()
        {
            return new ProcesadorMarcas(new MarcaInfoLoader(procesadorConstante), new MarcaGeneradorArchivoConstantes(), new InfoMarcaBuilder(), new MarcaGeneradorArchivoLoader());
        }
    }
}
