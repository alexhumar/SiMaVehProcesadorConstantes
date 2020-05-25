using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SubseccionGeneradorCuerpoLoader : GeneradorCuerpoLoader<InfoSubseccion, InfoLinea>
    {
        public SubseccionGeneradorCuerpoLoader(long currentId)
            : base(currentId)
        {
        }

        public override ResultadoGeneracionCuerpoLoader GenerarCuerpo(InfoSubseccion infoEstructura, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad)
        {
            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = GenerarEntradaCuerpo(infoEstructura, tipoEntidad, descripcionEntidad, infoEstructura.Cabecera.NombreConstante, tipoSuperEntidad, descripcionSuperEntidad, nombreSuperEntidad),
                FinishId = CurrentId
            };
        }
    }
}
