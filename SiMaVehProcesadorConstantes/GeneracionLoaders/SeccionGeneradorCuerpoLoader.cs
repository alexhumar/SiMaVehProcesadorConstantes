using SiMaVehProcesadorConstantes.Models;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SeccionGeneradorCuerpoLoader : GeneradorCuerpoLoader<InfoSeccion, InfoSubseccion>
    {
        public SeccionGeneradorCuerpoLoader(long currentId)
            : base(currentId)
        {
        }

        public override ResultadoGeneracionCuerpoLoader GenerarCuerpo(InfoSeccion infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad)
        {
            var sbLoaders = new StringBuilder();

            foreach (var infoSubSeccion in infoEstructura.Unidades)
            {
                sbLoaders.AppendLine(GenerarEntradaCuerpo(infoSubSeccion, tipoEntidad, infoEstructura.Cabecera.NombreConstante, tipoSuperEntidad, infoEstructura.Cabecera.NombreConstante));
            }

            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = sbLoaders.ToString().TrimEnd(),
                FinishId = CurrentId
            };
        }
    }
}
