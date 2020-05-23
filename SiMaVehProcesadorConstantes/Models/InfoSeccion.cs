using System.Collections.Generic;
using System.Linq;

namespace SiMaVehProcesadorConstantes.Models
{
    public class InfoSeccion : InfoEstructura<InfoSubseccion>
    {
        public override IList<InfoLinea> GetLineas()
        {
            return Unidades.SelectMany(u => u.Unidades).ToList();
        }
    }
}
