namespace SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces
{
    public interface IGeneradorCuerpoLoader<T>
    {
        ResultadoGeneracionCuerpoLoader GenerarCuerpo(T infoEstructura, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad);
    }
}
