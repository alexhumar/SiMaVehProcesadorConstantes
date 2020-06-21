using SiMaVehProcesadorConstantes.Builders.Interfaces;
using SiMaVehProcesadorConstantes.Models;

namespace SiMaVehProcesadorConstantes.Builders
{
    public class InfoMarcaBuilder : IInfoMarcaBuilder
    {
        public InfoMarca Build(InfoSeccion infoMarcas)
        {
            var result = new InfoMarca();

            foreach (var categoria in infoMarcas.Unidades)
            {
                var infoCategoriaMarca = categoria.Cabecera;

                foreach (var marca in categoria.Unidades)
                {
                    var marcaAProcesar = result.GetMarca(marca.NombreOriginal);

                    if (marcaAProcesar == null)
                    {
                        marcaAProcesar = new InfoSubseccion
                        {
                            Cabecera = new InfoLinea
                            {
                                NombreConstante = marca.NombreConstante,
                                NombreOriginal = marca.NombreOriginal
                            }
                        };
                        result.AgregarMarca(marcaAProcesar);
                    }

                    marcaAProcesar.AgregarUnidad(infoCategoriaMarca);
                }
            }

            return result;
        }
    }
}
