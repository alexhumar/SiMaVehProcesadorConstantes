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

        public override ResultadoGeneracionCuerpoLoader GenerarCuerpo(InfoSeccion infoEstructura, string tipoEntidad, string descripcionEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string nombreSuperEntidad)
        {
            var sbLoaders = new StringBuilder();

            foreach (var infoSubSeccion in infoEstructura.Unidades)
            {
                sbLoaders.AppendLine(GenerarEntradaCuerpo(infoSubSeccion, tipoEntidad, descripcionEntidad, infoEstructura.Cabecera.NombreConstante, tipoSuperEntidad, descripcionSuperEntidad, infoEstructura.Cabecera.NombreConstante));
            }

            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = sbLoaders.ToString().TrimEnd(),
                FinishId = CurrentId
            };
        }
    }
}
