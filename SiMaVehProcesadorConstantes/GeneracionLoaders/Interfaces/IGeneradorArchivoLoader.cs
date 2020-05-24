namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorArchivoLoader<T>
    {
        ResultadoGeneracionLoader GenerarArchivo(T infoEstructura, string directorioBase, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad, long startId);
    }
}
