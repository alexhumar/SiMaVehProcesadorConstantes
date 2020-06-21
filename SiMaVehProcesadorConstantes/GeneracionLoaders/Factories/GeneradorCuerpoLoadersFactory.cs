using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Models.Interfaces;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Factories
{
    public class GeneradorCuerpoLoadersFactory<T, S> where T : IInfoEstructura<S>
    {
        public IGeneradorCuerpoLoader<T> Get(T infoEstructura, long startId)
        {
            switch (infoEstructura)
            {
                case InfoSeccion _:
                    return new SeccionGeneradorCuerpoLoader(startId) as IGeneradorCuerpoLoader<T>;
                default:
                    return new SubseccionGeneradorCuerpoLoader(startId) as IGeneradorCuerpoLoader<T>;
            }
        }
    }
}
