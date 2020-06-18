using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;
using System.IO;

namespace SiMaVehProcesadorConstantes.Loaders
{
    public abstract class SeccionInfoLoader : InfoLoader<InfoSeccion, InfoSubseccion>
    {
        public SeccionInfoLoader(IProcesadorNombreConstante procesadorConstante)
            : base(procesadorConstante)
        {
        }

        protected override InfoSubseccion CrearUnidadInfoEstructura(StreamReader sr, string linea, bool capitalize = false)
        {
            InfoSubseccion result = new InfoSubseccion();
            var marcadorCorteControl = GetMarcadorCorteControl();
            result.AgregarUnidad(CrearInfoLinea(linea, capitalize));

            string lineaLocal;

            while (((lineaLocal = sr.ReadLine()) != null) && !lineaLocal.Contains(marcadorCorteControl))
            {
                result.AgregarUnidad(CrearInfoLinea(lineaLocal, capitalize));
            }

            string nombreCorte = lineaLocal.Replace(marcadorCorteControl, string.Empty).Trim();

            result.Cabecera = new InfoLinea
            {
                NombreConstante = procesadorConstante.ProcesarNombreConstante(nombreCorte),
                NombreOriginal = nombreCorte
            };

            return result;
        }

        protected abstract string GetMarcadorCorteControl();
    }
}
