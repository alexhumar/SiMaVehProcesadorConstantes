using SiMaVehProcesadorConstantes.GeneracionConstantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.Loaders;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;

namespace SiMaVehProcesadorConstantes.Procesadores.Builders
{
    public class ProcesadorPartidosBuilder : IProcesadorBuilder<ProcesadorPartidos>
    {
        private readonly IProcesadorNombreConstante procesadorConstante;

        public ProcesadorPartidosBuilder(IProcesadorNombreConstante procesadorConstante)
        {
            this.procesadorConstante = procesadorConstante;
        }

        public ProcesadorPartidos BuildProcesador()
        {
            return new ProcesadorPartidos(new SubseccionInfoLoader(procesadorConstante), new SubseccionGeneradorArchivoConstantes(), new SubseccionGeneradorArchivoLoader());
        }
    }
}
