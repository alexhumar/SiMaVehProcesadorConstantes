namespace SiMaVehProcesadorConstantes.Models
{
    /// <summary>
    /// InfoLinea
    /// </summary>
    public class InfoLinea
    {
        public string NombreOriginal { get; set; }

        public string NombreConstante { get; set; }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is InfoLinea infoLinea))
                return false;
            else
            {
                if (ReferenceEquals(this, infoLinea))
                    return true;
                else
                    return NombreConstante == infoLinea.NombreConstante && NombreOriginal == infoLinea.NombreOriginal;
            }
        }
    }
}
