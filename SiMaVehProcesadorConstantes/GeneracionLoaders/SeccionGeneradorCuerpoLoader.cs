using SiMaVehProcesadorConstantes.Models;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SeccionGeneradorCuerpoLoader : GeneradorCuerpoLoader<InfoSeccion, InfoSubseccion>
    {
        public SeccionGeneradorCuerpoLoader(long startId)
            : base(startId)
        {

        }

        public override string GenerarCuerpo(InfoSeccion infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad)
        {
            var sbLoaders = new StringBuilder();
            //var nombreClaseConstante = string.Concat(tipoEntidad, infoEstructura.Cabecera.NombreConstante);
            var nombreConstanteSuperClase = string.Concat(tipoSuperEntidad, infoEstructura.Cabecera.NombreConstante);

            foreach (var infoSubSeccion in infoEstructura.Unidades)
            {
                sbLoaders.AppendLine(GenerarEntradaCuerpo(infoSubSeccion, tipoEntidad, tipoSuperEntidad, nombreConstanteSuperClase));
            }

            //Se saca la ultima coma
            sbLoaders.Length--;

            sbLoaders.Append(string.Concat(Indent, ");"));

            return sbLoaders.ToString().TrimEnd();
        }
    }
}

/*
 
    sbLoaders.AppendLine(string.Concat(Indent, $"dictionary.Add(fixture{tipoSuperEntidad}.FindByNombre({tipoSuperEntidad}{nombreConstanteSuperClase}.{infoEstructura.Cabecera.NombreConstante}).Value.Key, new Dictionary<long, string>"));
    sbLoaders.AppendLine(string.Concat(Indent, "{"));

    foreach (var linea in infoSubSeccion.Unidades)
    {
        var stringToWrite = string.Format("{{ {0}, {1}.{2} }},", StartId, nombreClaseConstante, linea.NombreConstante);
        sbLoaders.AppendLine(string.Concat(SubIndent, stringToWrite));
    }

    sbLoaders.AppendLine(string.Concat(Indent, "},"));
 
 */
