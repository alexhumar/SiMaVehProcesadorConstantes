namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorArchivoLoader<T>
    {
        ResultadoGeneracionLoader GenerarArchivo(T infoEstructura, string directorioBase, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad, long startId);
    }
}
