using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Loaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.Procesadores
{
    public class ProcesadorMonedas
    {
        private readonly IInfoLoader<InfoSubseccion> infoMonedaLoader;
        private readonly IGeneradorArchivoContantes<InfoSubseccion> monedaGeneradorArchivoConstantes;
        private readonly IGeneradorArchivoLoader<InfoMoneda> monedaGeneradorArchivoLoader;

        public ProcesadorMonedas(IInfoLoader<InfoSubseccion> infoMonedaLoader,
            IGeneradorArchivoContantes<InfoSubseccion> monedaGeneradorArchivoConstantes,
            IGeneradorArchivoLoader<InfoMoneda> monedaGeneradorArchivoLoader)
        {
            this.infoMonedaLoader = infoMonedaLoader;
            this.monedaGeneradorArchivoConstantes = monedaGeneradorArchivoConstantes;
            this.monedaGeneradorArchivoLoader = monedaGeneradorArchivoLoader;
        }

        public ResultadoGeneracionLoader ProcesarMonedas(string directorioBase)
        {
            var infoMonedas = infoMonedaLoader.LoadInfo(directorioBase, string.Empty, true);
            monedaGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Moneda", "Monedas", "Monedas", infoMonedas);
            var infoCodsMonedas = infoMonedaLoader.LoadInfo(directorioBase, "MonedasCodigosISO");
            monedaGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Moneda", "Monedas", "Monedas", infoCodsMonedas);

            var info = new InfoMoneda
            {
                InfoCodsMonedas = infoCodsMonedas,
                InfoMonedas = infoMonedas
            };

            return monedaGeneradorArchivoLoader.GenerarArchivo(info, directorioBase, "Moneda", "Monedas");
        }
    }
}
