namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorArchivoLoader<T>
    {
        ResultadoGeneracionLoader GenerarArchivo(T infoEstructura, string directorioBase, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad = null, string descripcionSuperEntidad = null, string nombreSuperEntidad = null, long startId = 0);
    }
}
