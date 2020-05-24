using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Models.Interfaces;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Factories
{
    public class GeneradorCuerpoLoadersFactory<T, S> where T : IInfoEstructura<S>
    {
        public IGeneradorCuerpoLoader<T> Get(T infoEstructura)
        {
            if (infoEstructura is InfoSeccion)
            {
                return new SeccionGeneradorCuerpoLoaders() as IGeneradorCuerpoLoader<T>;
            }
            else
            {
                return new SubseccionGeneradorCuerpoLoaders() as IGeneradorCuerpoLoader<T>;
            }
        }
    }
}
