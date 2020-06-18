using SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces;
using SiMaVehProcesadorConstantes.GeneracionLoaders;
using SiMaVehProcesadorConstantes.GeneracionLoaders.Interfaces;
using SiMaVehProcesadorConstantes.Loaders.Interfaces;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.Procesadores
{
    public class ProcesadorMarcas
    {
        private readonly IInfoLoader<InfoSeccion> infoMarcaLoader;
        private readonly IGeneradorArchivoContantes<InfoSeccion> marcaGeneradorArchivoConstantes;
        private readonly IGeneradorArchivoLoader<InfoMoneda> monedaGeneradorArchivoLoader;

        public ProcesadorMarcas(IInfoLoader<InfoSeccion> infoMarcaLoader,
            IGeneradorArchivoContantes<InfoSeccion> marcaGeneradorArchivoConstantes,
            IGeneradorArchivoLoader<InfoMoneda> monedaGeneradorArchivoLoader)
        {
            this.infoMarcaLoader = infoMarcaLoader;
            this.marcaGeneradorArchivoConstantes = marcaGeneradorArchivoConstantes;
            this.monedaGeneradorArchivoLoader = monedaGeneradorArchivoLoader;
        }

        public ResultadoGeneracionLoader ProcesarMarcas(string directorioBase)
        {
            var infoMarcas = infoMarcaLoader.LoadInfo(directorioBase, "Marcas");
            marcaGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Marca", "Marcas", "Marcas", infoMarcas);
            //var infoCodsMonedas = infoMarcaLoader.LoadInfo(directorioBase, "MonedasCodigosISO");
            //monedaGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Moneda", "Monedas", "Monedas", infoCodsMonedas);

            //var info = new InfoMoneda
            //{
            //    InfoCodsMonedas = infoCodsMonedas,
            //    InfoMonedas = infoMarcas
            //};

            //return monedaGeneradorArchivoLoader.GenerarArchivo(info, directorioBase, "Moneda", "Monedas");
            return null;
        }
    }
}
