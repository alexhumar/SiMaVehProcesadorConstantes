using System.Collections.Generic;

namespace SiMaVehProcesadorConstantes.Models.Interfaces
{
    public interface IInfoEstructura<T>
    {
        InfoLinea Cabecera { get; set; }

        IList<T> Unidades { get; set; }

        void AgregarUnidad(T unidad);

        IList<InfoLinea> GetLineas();
    }
}
