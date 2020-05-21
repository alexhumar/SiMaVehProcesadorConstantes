using System.Globalization;

namespace SiMaVehProcesadorConstantes.Procesadores
{
    public class ProcesadorNombreConstante
    {
        private string ProcesarPalabra(string palabra)
        {
            return palabra
                .Replace('á', 'a')
                .Replace('é', 'e')
                .Replace('í', 'i')
                .Replace('ó', 'o')
                .Replace('ú', 'u')
                .Replace('ä', 'a')
                .Replace('ë', 'e')
                .Replace('ï', 'i')
                .Replace('ö', 'o')
                .Replace('ü', 'u')
                .Replace('Á', 'A')
                .Replace('É', 'E')
                .Replace('Í', 'I')
                .Replace('Ó', 'O')
                .Replace('Ú', 'U')
                .Replace('Ä', 'A')
                .Replace('Ë', 'E')
                .Replace('Ï', 'I')
                .Replace('Ö', 'O')
                .Replace('Ü', 'U')
                .Replace('ñ', 'n')
                .Replace('Ñ', 'N')
                .Replace(".", "")
                .Replace("'", "")
                .Replace("º", "");
        }

        public string ProcesarNombreConstante(string linea)
        {
            var palabras = linea.Split(" ");
            var result = string.Empty;
            var textInfo = CultureInfo.InvariantCulture.TextInfo;

            foreach (var palabra in palabras)
            {
                result += ProcesarPalabra(textInfo.ToTitleCase(palabra));
            }

            return result;
        }
    }
}
