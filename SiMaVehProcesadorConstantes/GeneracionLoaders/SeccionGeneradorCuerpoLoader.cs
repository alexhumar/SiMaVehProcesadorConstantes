using SiMaVehProcesadorConstantes.Models;
using System.Linq;
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
            var unidadesPendientesProcesar = infoEstructura.Unidades.Count();

            foreach (var infoSubSeccion in infoEstructura.Unidades)
            {
                unidadesPendientesProcesar--;
                sbLoaders.AppendLine(GenerarEntradaCuerpo(infoSubSeccion, tipoEntidad, tipoSuperEntidad, infoEstructura.Cabecera.NombreConstante, unidadesPendientesProcesar == 0));
            }

            return new ResultadoGeneracionCuerpoLoader
            {
                Cuerpo = sbLoaders.ToString().TrimEnd(),
                FinishId = CurrentId
            };
        }
    }
}
