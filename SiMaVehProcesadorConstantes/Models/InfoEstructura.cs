using SiMaVehProcesadorConstantes.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVehProcesadorConstantes.Models
{
    /// <summary>
    /// InfoEstructura
    /// </summary>
    /// <typeparam name="T"></typeparam>
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

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is InfoEstructura<T> infoEstructura))
                return false;
            else
            {
                if (ReferenceEquals(this, infoEstructura))
                    return true;
                else
                {
                    var iguales = Cabecera.Equals(infoEstructura.Cabecera) && (Unidades.Count() == infoEstructura.Unidades.Count());

                    if (iguales)
                    {
                        foreach (var unidad in Unidades)
                        {
                            var indexUnidad = Unidades.IndexOf(unidad);

                            if (!unidad.Equals(infoEstructura.Unidades[indexUnidad]))
                            {
                                iguales = false;
                                break;
                            }
                        }
                    }

                    return iguales;
                }
            }
        }
    }
}
