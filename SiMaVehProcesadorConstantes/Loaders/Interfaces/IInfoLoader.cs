namespace SiMaVehProcesadorConstantes.Loaders.Interfaces
{
    public interface IInfoLoader<T>
    {
        T LoadInfo(string directorioBase, string nombreCabecera, bool capitalize = false);
    }
}
