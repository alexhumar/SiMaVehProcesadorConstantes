using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Models;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;
using System.IO;

namespace SiMaVehProcesadorConstantes.Loaders
{
    public class SeccionInfoLoader : InfoLoader<InfoSeccion, InfoSubseccion>
    {
        public SeccionInfoLoader(IProcesadorNombreConstante procesadorConstante)
            : base(procesadorConstante)
        {
        }

        protected override InfoSubseccion CrearUnidadInfoEstructura(StreamReader sr, string linea, bool capitalize = false)
        {
            InfoSubseccion result = new InfoSubseccion();
            result.AgregarUnidad(CrearInfoLinea(linea, capitalize));

            string lineaLocal;

            while (((lineaLocal = sr.ReadLine()) != null) && !lineaLocal.Contains(Procesamiento.MarcadorCorteControl))
            {
                result.AgregarUnidad(CrearInfoLinea(lineaLocal, capitalize));
            }

            string nombreCorte = lineaLocal.Replace(Procesamiento.MarcadorCorteControl, string.Empty).Trim();

            result.Cabecera = new InfoLinea
            {
                NombreConstante = procesadorConstante.ProcesarNombreConstante(nombreCorte),
                NombreOriginal = nombreCorte
            };

            return result;
        }

        protected override string GetNombreInputFile()
        {
            return Procesamiento.NombreArchivoSeccion;
        }
    }
}
