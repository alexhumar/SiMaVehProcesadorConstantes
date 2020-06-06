using SiMaVehProcesadorConstantes.GeneracionConstantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.Loaders;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;

namespace SiMaVehProcesadorConstantes.Procesadores.Builders
{
    public class ProcesadorMonedasBuilder : IProcesadorBuilder<ProcesadorMonedas>
    {
        private readonly IProcesadorNombreConstante procesadorConstante;

        public ProcesadorMonedasBuilder(IProcesadorNombreConstante procesadorConstante)
        {
            this.procesadorConstante = procesadorConstante;
        }

        public ProcesadorMonedas BuildProcesador()
        {
            return new ProcesadorMonedas(new MonedaInfoLoader(procesadorConstante), new MonedaGeneradorArchivoConstantes(), new MonedaGeneradorArchivoLoader());
        }
    }
}
