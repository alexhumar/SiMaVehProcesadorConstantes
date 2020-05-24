namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorCuerpoLoader<T>
    {
        ResultadoGeneracionCuerpoLoader GenerarCuerpo(T infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad);
    }
}
