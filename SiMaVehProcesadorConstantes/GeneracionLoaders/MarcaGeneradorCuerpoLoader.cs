using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.Linq;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class MarcaGeneradorCuerpoLoader : SeccionGeneradorCuerpoLoader
    {
        public MarcaGeneradorCuerpoLoader(long currentId)
            : base(currentId)
        {
        }

        protected override string GenerarEntradaCuerpo(IInfoEstructura<InfoLinea> infoEstructura, string tipoEntidad, string descripcionEntidad, string valorEntidad, string tipoSuperEntidad, string descripcionSuperEntidad, string valorSuperEntidad)
        {
            //TODO: ESTO HAY QUE IMPLEMENTARLO BIEN, CON LA LOGICA NECESARIA PARA MARCA...

            var sbLoaders = new StringBuilder();
            var nombreClaseConstante = string.Concat(tipoEntidad, valorEntidad);
            var lineasPendientesProcesar = infoEstructura.GetLineas().Count();

            sbLoaders.AppendLine(string.Concat(Indent, $"{descripcionEntidad.ToLower()}.Add({tipoSuperEntidad.ToLower()}FixtureGetter.FindByNombre({tipoSuperEntidad}{valorSuperEntidad}.{infoEstructura.Cabecera.NombreConstante}).Id, new List<DatosEntidad>"));
            sbLoaders.AppendLine(string.Concat(Indent, "{"));

            foreach (var linea in infoEstructura.GetLineas())
            {
                lineasPendientesProcesar--;
                var stringToWrite = string.Format("datosEntidadBuilder.Build({0}, {1}.{2}){3}", CurrentId, nombreClaseConstante, linea.NombreConstante, lineasPendientesProcesar > 0 ? "," : string.Empty);
                sbLoaders.AppendLine(string.Concat(SubIndent, stringToWrite));
            }

            sbLoaders.AppendLine(string.Concat(Indent, "});"));

            return sbLoaders.ToString().TrimEnd();
        }
    }
}
