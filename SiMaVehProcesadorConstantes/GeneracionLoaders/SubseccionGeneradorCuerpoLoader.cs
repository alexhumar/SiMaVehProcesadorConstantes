using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SubseccionGeneradorCuerpoLoader : GeneradorCuerpoLoader<InfoSubseccion, InfoLinea>
    {
        public SubseccionGeneradorCuerpoLoader(long currentId)
            : base(currentId)
        {
        }

        public override ResultadoGeneracionCuerpoLoader GenerarCuerpo(InfoSubseccion infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad)
        {
            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = GenerarEntradaCuerpo(infoEstructura, tipoEntidad, infoEstructura.Cabecera.NombreConstante, tipoSuperEntidad, nombreSuperEntidad),
                FinishId = CurrentId
            };
        }
    }
}
