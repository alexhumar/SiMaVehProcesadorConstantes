using SiMaVehProcesadorConstantes.Models;
using System.Text;

namespace SiMaVehProcesadorConstantes.GeneracionLoaders
{
    public class GeneradorCuerpoLoaders
    {
        //TODO: ver como manejar este ID.
        public static long StartId { get; set; }

        public GeneradorCuerpoLoaders()
        {
            StartId = 1;
        }

        public string Generar(InfoSubseccion infoSubSeccion, string tipoEntidad)
        {
            var sbLoaders = new StringBuilder();
            var indent = string.Empty.PadLeft(12);
            var subIndent = string.Empty.PadLeft(16);
            var nombreClaseConstante = string.Concat(tipoEntidad, infoSubSeccion.Cabecera.NombreConstante);

            //TODO: este es masomenos el codigo para una subseccion... O sea los partidos de una provincia. Para el de seccion seria generar este codigo por cada subseccion.
            //Hay que ver como hacerlo.

            //TODO: aca "Partido" tiene que ser parametrizado
            sbLoaders.AppendLine(string.Concat(indent, "dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AdolfoAlsina).Value.Key, new Dictionary<long, string>"));
            sbLoaders.AppendLine(string.Concat(indent, "{"));

            foreach (var linea in infoSubSeccion.Unidades)
            {
                var stringToWrite = string.Format("{{ {0}, {1}.{2} }},", StartId, nombreClaseConstante, linea.NombreConstante);
                sbLoaders.AppendLine(string.Concat(subIndent, stringToWrite));
            }

            sbLoaders.AppendLine(string.Concat(indent, "});"));

            return sbLoaders.ToString().TrimEnd();
        }

        //dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AdolfoAlsina).Value.Key, new Dictionary<long, string>
        //    {
        //        //{ 1, LocalidadBuenosAires.Quilmes },
        //        //{ 2, LocalidadBuenosAires.Ezpeleta }
        //    });

        //string outputDictionaryPath = Path.Combine(directorioBase, "Output_Dictionary.txt");
        //if (!File.Exists(outputDictionaryPath))
        //{
        //    // Create a file to write to.
        //    using (StreamWriter sw = File.CreateText(outputDictionaryPath))
        //    {
        //        foreach (var linea in infoLineas)
        //        {
        //            var stringToWrite = string.Format("/ {0}, {1}.{2} |,", startId, nombreClaseConstante, linea.NombreConstante);
        //            sw.WriteLine(stringToWrite.Replace("/", "{").Replace("|", "}"));
        //            startId++;
        //        }
        //    }
        //}
    }
}
