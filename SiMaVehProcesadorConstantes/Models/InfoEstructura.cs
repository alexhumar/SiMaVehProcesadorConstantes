using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.Collections.Generic;

namespace SiMaVehProcesadorConstantes.Models
{
    public abstract class InfoEstructura<T> : IInfoEstructura<T>
    {
        public InfoEstructura()
        {
            Cabecera = new InfoLinea();
            Unidades = new List<T>();
        }

        public InfoLinea Cabecera { get; set; }

        public IList<T> Unidades { get; set; }

        public void AgregarUnidad(T unidad)
        {
            Unidades.Add(unidad);
        }

        public abstract IList<InfoLinea> GetLineas();
    }
}
