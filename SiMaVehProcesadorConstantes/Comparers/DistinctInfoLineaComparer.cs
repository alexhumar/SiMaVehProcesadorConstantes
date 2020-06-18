using SiMaVehProcesadorConstantes.Models;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SiMaVehProcesadorConstantes.Comparers
{
    public class DistinctInfoLineaComparer : IEqualityComparer<InfoLinea>
    {
        public bool Equals([AllowNull] InfoLinea x, [AllowNull] InfoLinea y)
        {
            return x.NombreOriginal == y.NombreOriginal;
        }

        public int GetHashCode([DisallowNull] InfoLinea obj)
        {
            return obj.NombreOriginal.GetHashCode() ^ obj.NombreConstante.GetHashCode();
        }
    }
}
