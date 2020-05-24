using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class SubseccionGeneradorCuerpoLoader : GeneradorCuerpoLoader<InfoSubseccion, InfoLinea>
    {
        public SubseccionGeneradorCuerpoLoader(long startId)
            : base(startId)
        {

        }

        public override string GenerarCuerpo(InfoSubseccion infoEstructura, string tipoEntidad, string tipoSuperEntidad, string nombreSuperEntidad)
        {
            return GenerarEntradaCuerpo(infoEstructura, tipoEntidad, tipoSuperEntidad, nombreSuperEntidad);
        }
    }
}


/*

    var sbLoaders = new StringBuilder();
    var nombreClaseConstante = string.Concat(tipoEntidad, infoEstructura.Cabecera.NombreConstante);

    sbLoaders.AppendLine(string.Concat(Indent, $"dictionary.Add(fixture{tipoSuperEntidad}.FindByNombre({tipoSuperEntidad}{nombreSuperEntidad}.{infoEstructura.Cabecera.NombreConstante}).Value.Key, new Dictionary<long, string>"));
    sbLoaders.AppendLine(string.Concat(Indent, "{"));

    foreach (var linea in infoEstructura.GetLineas())
    {
        var stringToWrite = string.Format("{{ {0}, {1}.{2} }},", StartId, nombreClaseConstante, linea.NombreConstante);
        sbLoaders.AppendLine(string.Concat(SubIndent, stringToWrite));
    }

    sbLoaders.AppendLine(string.Concat(Indent, "});"));

    return sbLoaders.ToString().TrimEnd(); 

 */
