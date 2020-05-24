using SiMaVehProcesadorConstantes.GeneracionConstantes;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.Loaders;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;

namespace SiMaVehProcesadorConstantes.Procesadores.Builders
{
    public class ProcesadorLocalidadesBuilder : IProcesadorBuilder<ProcesadorLocalidades>
    {
        private readonly IProcesadorNombreConstante procesadorConstante;

        public ProcesadorLocalidadesBuilder(IProcesadorNombreConstante procesadorConstante)
        {
            this.procesadorConstante = procesadorConstante;
        }

        public ProcesadorLocalidades BuildProcesador()
        {
            return new ProcesadorLocalidades(new SeccionInfoLoader(procesadorConstante), new SeccionGeneradorArchivoConstantes(), new SeccionGeneradorArchivoLoader());
        }
    }
}
