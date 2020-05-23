using System.Collections.Generic;

namespace SiMaVehProcesadorConstantes.Models
{
    public class InfoSubseccion : InfoEstructura<InfoLinea>
    {
        public override IList<InfoLinea> GetLineas()
        {
            return Unidades;
        }
    }
}
