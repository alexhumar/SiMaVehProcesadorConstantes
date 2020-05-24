using SiMaVehProcesadorConstantes.Models;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SeccionGeneradorCuerpoLoaders : GeneradorCuerpoLoaders<InfoSeccion, InfoSubseccion>
    {
        public override string GenerarCuerpo(InfoSeccion infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad)
        {
            var sbLoaders = new StringBuilder();
            var nombreClaseConstante = string.Concat(tipoEntidad, infoEstructura.Cabecera.NombreConstante);
            var nombreConstanteSuperClase = string.Concat(tipoSuperEntidad, infoEstructura.Cabecera.NombreConstante);

            foreach (var infoSubSeccion in infoEstructura.Unidades)
            {
                sbLoaders.AppendLine(string.Concat(Indent, $"dictionary.Add(fixture{tipoSuperEntidad}.FindByNombre({tipoSuperEntidad}{nombreConstanteSuperClase}.{infoEstructura.Cabecera.NombreConstante}).Value.Key, new Dictionary<long, string>"));
                sbLoaders.AppendLine(string.Concat(Indent, "{"));

                foreach (var linea in infoSubSeccion.Unidades)
                {
                    var stringToWrite = string.Format("{{ {0}, {1}.{2} }},", StartId, nombreClaseConstante, linea.NombreConstante);
                    sbLoaders.AppendLine(string.Concat(SubIndent, stringToWrite));
                }

                sbLoaders.AppendLine(string.Concat(Indent, "},"));
            }

            //Se saca la ultima coma
            sbLoaders.Length--;

            sbLoaders.Append(string.Concat(Indent, ");"));

            return sbLoaders.ToString().TrimEnd();
        }
    }
}
