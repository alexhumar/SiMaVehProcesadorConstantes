using System.Collections.Generic;
using System.Linq;

namespace SiMaVehProcesadorConstantes.Models
{
    public class InfoMarca
    {
        public InfoMarca()
        {
            InfoMarcas = new List<InfoSubseccion>();
        }

        /// <summary>
        /// InfoMarcas - Cada InfoSubseccion va a ser una marca, donde la cabecera tenga la marca en sí 
        /// y las Unidades tengan las categorias de esa marca.
        /// </summary>
        public readonly List<InfoSubseccion> InfoMarcas;

        public void AgregarMarca(InfoSubseccion infoMarca)
        {
            InfoMarcas.Add(infoMarca);
        }

        public InfoSubseccion GetMarca(string marca)
        {
            return InfoMarcas.FirstOrDefault(m => m.Cabecera.NombreOriginal == marca);
        }
    }
}
