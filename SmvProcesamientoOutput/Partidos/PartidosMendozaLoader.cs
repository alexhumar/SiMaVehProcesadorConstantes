using SiMaVeh.Domain.DataSeed.Constants.DivisionesPais;
using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Provincia.Loaders.Base;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Partido.Loaders.Argentina
{
    class PartidosMendozaLoader : PartidosLoader
    {
        public PartidosMendozaLoader(IProvinciasLoader<long, long, string> provinciasLoader)
            : base(provinciasLoader)
        {
        }

        protected override void Initialize()
        {
            partidos.Add(provinciasLoader.FindByNombre(ProvinciaArgentina.Mendoza).Key, new Dictionary<long, string>
            {
                { 325, PartidoMendoza.Capital },
                { 326, PartidoMendoza.GeneralAlvear },
                { 327, PartidoMendoza.GodoyCruz },
                { 328, PartidoMendoza.Guaymallen },
                { 329, PartidoMendoza.Junin },
                { 330, PartidoMendoza.LaPaz },
                { 331, PartidoMendoza.LasHeras },
                { 332, PartidoMendoza.Lavalle },
                { 333, PartidoMendoza.LujanDeCuyo },
                { 334, PartidoMendoza.Maipu },
                { 335, PartidoMendoza.Malargue },
                { 336, PartidoMendoza.Rivadavia },
                { 337, PartidoMendoza.SanCarlos },
                { 338, PartidoMendoza.GeneralSanMartin },
                { 339, PartidoMendoza.SanRafael },
                { 340, PartidoMendoza.SantaRosa },
                { 341, PartidoMendoza.Tunuyan },
                { 342, PartidoMendoza.Tupungato }
            });
        }
    }
}
