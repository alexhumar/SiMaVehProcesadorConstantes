namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorCuerpoLoader<T>
    {
        string GenerarCuerpo(T infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad);
    }
}
