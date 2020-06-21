using SiMaVehProcesadorConstantes.Builders.Interfaces;
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
        private readonly IInfoMarcaBuilder infoMarcaBuilder;
        private readonly IGeneradorArchivoLoader<InfoMarca> marcaGeneradorArchivoLoader;

        public ProcesadorMarcas(IInfoLoader<InfoSeccion> infoMarcaLoader,
            IGeneradorArchivoContantes<InfoSeccion> marcaGeneradorArchivoConstantes,
            IInfoMarcaBuilder infoMarcaBuilder,
            IGeneradorArchivoLoader<InfoMarca> marcaGeneradorArchivoLoader)
        {
            this.infoMarcaLoader = infoMarcaLoader;
            this.marcaGeneradorArchivoConstantes = marcaGeneradorArchivoConstantes;
            this.infoMarcaBuilder = infoMarcaBuilder;
            this.marcaGeneradorArchivoLoader = marcaGeneradorArchivoLoader;
        }

        public ResultadoGeneracionLoader ProcesarMarcas(string directorioBase)
        {
            var infoMarcas = infoMarcaLoader.LoadInfo(directorioBase, "Marcas");
            var infoMarcaCategorias = infoMarcaBuilder.Build(infoMarcas);
            marcaGeneradorArchivoConstantes.GenerarArchivo(directorioBase, "Marca", "Marcas", "Marcas", infoMarcas);

            return marcaGeneradorArchivoLoader.GenerarArchivo(infoMarcaCategorias, directorioBase, "Marca", "Marcas");
        }
    }
}
