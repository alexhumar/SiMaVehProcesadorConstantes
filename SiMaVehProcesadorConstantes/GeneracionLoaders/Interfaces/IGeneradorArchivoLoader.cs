namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorArchivoLoader<T>
    {
        void GenerarArchivo(T infoEstructura, string directorioBase, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad, long startId);
    }
}
