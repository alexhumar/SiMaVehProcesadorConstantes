using SiMaVeh.Domain.DataSeed.Fixtures.Builders.Interfaces;
using SiMaVeh.Domain.DataSeed.Fixtures.Moneda.Interfaces;
using SiMaVeh.Domain.DataSeed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Moneda.FixtureGetters
{
    /// <summary>
    /// Fixture getter de moneda
    /// </summary>
    internal class MonedaFixtureGetter : IMonedaFixtureGetter
    {
        private readonly IDatosEntidadBuilder datosEntidadBuilder;
        private readonly ICollection<DatosMoneda> monedas;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="datosEntidadBuilder"></param>
        public MonedaFixtureGetter(IDatosEntidadBuilder datosEntidadBuilder)
        {
            this.datosEntidadBuilder = datosEntidadBuilder;
            monedas = new List<DatosMoneda>();

            Initialize();
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public ICollection<DatosMoneda> Get()
        {
            return monedas;
        }

        private void Initialize()
        {
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DirhamDeLosEmiratosArabesUnidos, Constants.Monedas.MonedaCodigosISO.AED));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Afgani, Constants.Monedas.MonedaCodigosISO.AFN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lek, Constants.Monedas.MonedaCodigosISO.ALL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DramArmenio, Constants.Monedas.MonedaCodigosISO.AMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FlorinAntillanoNeerlandes, Constants.Monedas.MonedaCodigosISO.ANG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kwanza, Constants.Monedas.MonedaCodigosISO.AOA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoArgentino, Constants.Monedas.MonedaCodigosISO.ARS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarAustraliano, Constants.Monedas.MonedaCodigosISO.AUD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FlorinArubeno, Constants.Monedas.MonedaCodigosISO.AWG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ManatAzerbaiyano, Constants.Monedas.MonedaCodigosISO.AZN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MarcoConvertible, Constants.Monedas.MonedaCodigosISO.BAM));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeBarbados, Constants.Monedas.MonedaCodigosISO.BBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Taka, Constants.Monedas.MonedaCodigosISO.BDT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LevBulgaro, Constants.Monedas.MonedaCodigosISO.BGN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarBareini, Constants.Monedas.MonedaCodigosISO.BHD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoDeBurundi, Constants.Monedas.MonedaCodigosISO.BIF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBermudeno, Constants.Monedas.MonedaCodigosISO.BMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeBrunei, Constants.Monedas.MonedaCodigosISO.BND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Boliviano, Constants.Monedas.MonedaCodigosISO.BOB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MVDOL, Constants.Monedas.MonedaCodigosISO.BOV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RealBrasileno, Constants.Monedas.MonedaCodigosISO.BRL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBahameno, Constants.Monedas.MonedaCodigosISO.BSD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Ngultrum, Constants.Monedas.MonedaCodigosISO.BTN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Pula, Constants.Monedas.MonedaCodigosISO.BWP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RubloBielorruso, Constants.Monedas.MonedaCodigosISO.BYN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBeliceno, Constants.Monedas.MonedaCodigosISO.BZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarCanadiense, Constants.Monedas.MonedaCodigosISO.CAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCongoleno, Constants.Monedas.MonedaCodigosISO.CDF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.EuroWIR, Constants.Monedas.MonedaCodigosISO.CHE));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoSuizo, Constants.Monedas.MonedaCodigosISO.CHF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoWIR, Constants.Monedas.MonedaCodigosISO.CHW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeFomento, Constants.Monedas.MonedaCodigosISO.CLF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoChileno, Constants.Monedas.MonedaCodigosISO.CLP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.YuanChino, Constants.Monedas.MonedaCodigosISO.CNY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoColombiano, Constants.Monedas.MonedaCodigosISO.COP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeValorReal, Constants.Monedas.MonedaCodigosISO.COU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ColonCostarricense, Constants.Monedas.MonedaCodigosISO.CRC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoConvertible, Constants.Monedas.MonedaCodigosISO.CUC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoCubano, Constants.Monedas.MonedaCodigosISO.CUP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.EscudoCaboverdiano, Constants.Monedas.MonedaCodigosISO.CVE));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaCheca, Constants.Monedas.MonedaCodigosISO.CZK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoYibutiano, Constants.Monedas.MonedaCodigosISO.DJF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaDanesa, Constants.Monedas.MonedaCodigosISO.DKK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoDominicano, Constants.Monedas.MonedaCodigosISO.DOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarArgelino, Constants.Monedas.MonedaCodigosISO.DZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraEgipcia, Constants.Monedas.MonedaCodigosISO.EGP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Nakfa, Constants.Monedas.MonedaCodigosISO.ERN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.BirrEtiope, Constants.Monedas.MonedaCodigosISO.ETB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarFiyiano, Constants.Monedas.MonedaCodigosISO.FJD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraMalvinense, Constants.Monedas.MonedaCodigosISO.FKP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraEsterlina, Constants.Monedas.MonedaCodigosISO.GBP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lari, Constants.Monedas.MonedaCodigosISO.GEL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CediGhanes, Constants.Monedas.MonedaCodigosISO.GHS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraDeGibraltar, Constants.Monedas.MonedaCodigosISO.GIP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dalasi, Constants.Monedas.MonedaCodigosISO.GMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoGuineano, Constants.Monedas.MonedaCodigosISO.GNF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Quetzal, Constants.Monedas.MonedaCodigosISO.GTQ));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarGuyanes, Constants.Monedas.MonedaCodigosISO.GYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeHongKong, Constants.Monedas.MonedaCodigosISO.HKD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lempira, Constants.Monedas.MonedaCodigosISO.HNL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kuna, Constants.Monedas.MonedaCodigosISO.HRK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Gourde, Constants.Monedas.MonedaCodigosISO.HTG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Forinto, Constants.Monedas.MonedaCodigosISO.HUF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaIndonesia, Constants.Monedas.MonedaCodigosISO.IDR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NuevoShequelIsraeli, Constants.Monedas.MonedaCodigosISO.ILS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaIndia, Constants.Monedas.MonedaCodigosISO.INR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarIraqui, Constants.Monedas.MonedaCodigosISO.IQD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialIrani, Constants.Monedas.MonedaCodigosISO.IRR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaIslandesa, Constants.Monedas.MonedaCodigosISO.ISK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarJamaiquino, Constants.Monedas.MonedaCodigosISO.JMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarJordano, Constants.Monedas.MonedaCodigosISO.JOD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Yen, Constants.Monedas.MonedaCodigosISO.JPY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinKeniano, Constants.Monedas.MonedaCodigosISO.KES));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Som, Constants.Monedas.MonedaCodigosISO.KGS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Riel, Constants.Monedas.MonedaCodigosISO.KHR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoComorense, Constants.Monedas.MonedaCodigosISO.KMF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.WonNorcoreano, Constants.Monedas.MonedaCodigosISO.KPW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Won, Constants.Monedas.MonedaCodigosISO.KRW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarKuwaiti, Constants.Monedas.MonedaCodigosISO.KWD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasIslasCaiman, Constants.Monedas.MonedaCodigosISO.KYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tenge, Constants.Monedas.MonedaCodigosISO.KZT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kip, Constants.Monedas.MonedaCodigosISO.LAK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraLibanesa, Constants.Monedas.MonedaCodigosISO.LBP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaDeSriLanka, Constants.Monedas.MonedaCodigosISO.LKR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarLiberiano, Constants.Monedas.MonedaCodigosISO.LRD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Loti, Constants.Monedas.MonedaCodigosISO.LSL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarLibio, Constants.Monedas.MonedaCodigosISO.LYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DirhamMarroqui, Constants.Monedas.MonedaCodigosISO.MAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LeuMoldavo, Constants.Monedas.MonedaCodigosISO.MDL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.AriaryMalgache, Constants.Monedas.MonedaCodigosISO.MGA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Denar, Constants.Monedas.MonedaCodigosISO.MKD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kyat, Constants.Monedas.MonedaCodigosISO.MMK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tugrik, Constants.Monedas.MonedaCodigosISO.MNT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Pataca, Constants.Monedas.MonedaCodigosISO.MOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Uguiya, Constants.Monedas.MonedaCodigosISO.MRU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaDeMauricio, Constants.Monedas.MonedaCodigosISO.MUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rufiyaa, Constants.Monedas.MonedaCodigosISO.MVR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kwacha, Constants.Monedas.MonedaCodigosISO.MWK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoMexicano, Constants.Monedas.MonedaCodigosISO.MXN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeInversion(UDI)Mexicana, Constants.Monedas.MonedaCodigosISO.MXV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RinggitMalayo, Constants.Monedas.MonedaCodigosISO.MYR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MeticalMozambiqueno, Constants.Monedas.MonedaCodigosISO.MZN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarNamibio, Constants.Monedas.MonedaCodigosISO.NAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Naira, Constants.Monedas.MonedaCodigosISO.NGN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Cordoba, Constants.Monedas.MonedaCodigosISO.NIO));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaNoruega, Constants.Monedas.MonedaCodigosISO.NOK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaNepali, Constants.Monedas.MonedaCodigosISO.NPR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarNeozelandes, Constants.Monedas.MonedaCodigosISO.NZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialOmani, Constants.Monedas.MonedaCodigosISO.OMR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Balboa, Constants.Monedas.MonedaCodigosISO.PAB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Sol, Constants.Monedas.MonedaCodigosISO.PEN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kina, Constants.Monedas.MonedaCodigosISO.PGK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoFilipino, Constants.Monedas.MonedaCodigosISO.PHP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaPakistani, Constants.Monedas.MonedaCodigosISO.PKR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Złoty, Constants.Monedas.MonedaCodigosISO.PLN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Guarani, Constants.Monedas.MonedaCodigosISO.PYG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialCatari, Constants.Monedas.MonedaCodigosISO.QAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LeuRumano, Constants.Monedas.MonedaCodigosISO.RON));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarSerbio, Constants.Monedas.MonedaCodigosISO.RSD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RubloRuso, Constants.Monedas.MonedaCodigosISO.RUB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoRuandes, Constants.Monedas.MonedaCodigosISO.RWF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialSaudi, Constants.Monedas.MonedaCodigosISO.SAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasIslasSalomon, Constants.Monedas.MonedaCodigosISO.SBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaSeychelense, Constants.Monedas.MonedaCodigosISO.SCR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSudanesa, Constants.Monedas.MonedaCodigosISO.SDG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaSueca, Constants.Monedas.MonedaCodigosISO.SEK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeSingapur, Constants.Monedas.MonedaCodigosISO.SGD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraDeSantaElena, Constants.Monedas.MonedaCodigosISO.SHP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Leone, Constants.Monedas.MonedaCodigosISO.SLL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinSomali, Constants.Monedas.MonedaCodigosISO.SOS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarSurinames, Constants.Monedas.MonedaCodigosISO.SRD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSursudanesa, Constants.Monedas.MonedaCodigosISO.SSP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dobra, Constants.Monedas.MonedaCodigosISO.STN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ColonSalvadoreno, Constants.Monedas.MonedaCodigosISO.SVC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSiria, Constants.Monedas.MonedaCodigosISO.SYP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lilangeni, Constants.Monedas.MonedaCodigosISO.SZL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Baht, Constants.Monedas.MonedaCodigosISO.THB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SomoniTayiko, Constants.Monedas.MonedaCodigosISO.TJS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ManatTurcomano, Constants.Monedas.MonedaCodigosISO.TMT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarTunecino, Constants.Monedas.MonedaCodigosISO.TND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Paʻanga, Constants.Monedas.MonedaCodigosISO.TOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LiraTurca, Constants.Monedas.MonedaCodigosISO.TRY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeTrinidadYTobago, Constants.Monedas.MonedaCodigosISO.TTD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NuevoDolarTaiwanes, Constants.Monedas.MonedaCodigosISO.TWD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinTanzano, Constants.Monedas.MonedaCodigosISO.TZS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Grivna, Constants.Monedas.MonedaCodigosISO.UAH));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinUgandes, Constants.Monedas.MonedaCodigosISO.UGX));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarEstadounidense, Constants.Monedas.MonedaCodigosISO.USD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarEstadounidense(SiguienteDia), Constants.Monedas.MonedaCodigosISO.USN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoEnUnidadesIndexadas(Uruguay), Constants.Monedas.MonedaCodigosISO.UYI));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoUruguayo, Constants.Monedas.MonedaCodigosISO.UYU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadPrevisional, Constants.Monedas.MonedaCodigosISO.UYW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SomUzbeko, Constants.Monedas.MonedaCodigosISO.UZS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.BolivarSoberano, Constants.Monedas.MonedaCodigosISO.VES7​));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DongVietnamita, Constants.Monedas.MonedaCodigosISO.VND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Vatu, Constants.Monedas.MonedaCodigosISO.VUV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tala, Constants.Monedas.MonedaCodigosISO.WST));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFADeAfricaCentral, Constants.Monedas.MonedaCodigosISO.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Plata(UnaOnzaTroy), Constants.Monedas.MonedaCodigosISO.XAG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Oro(UnaOnzaTroy), Constants.Monedas.MonedaCodigosISO.XAU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadCompuestaEuropea(EURCO)(UnidadDelMercadosDeBonos), Constants.Monedas.MonedaCodigosISO.XBA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadMonetariaEuropea(EMU6)(UnidadDelMercadoDeBonos), Constants.Monedas.MonedaCodigosISO.XBB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadEuropeaDeCuenta9(EUA9)(UnidadDelMercadoDeBonos), Constants.Monedas.MonedaCodigosISO.XBC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadEuropeaDeCuenta17(EUA17)(UnidadDelMercadoDeBonos), Constants.Monedas.MonedaCodigosISO.XBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDelCaribeOriental, Constants.Monedas.MonedaCodigosISO.XCD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DerechosEspecialesDeGiro, Constants.Monedas.MonedaCodigosISO.XDR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFADeAfricaOccidental, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Paladio(UnaOnzaTroy), Constants.Monedas.MonedaCodigosISO.XPD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFP, Constants.Monedas.MonedaCodigosISO.XPF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Platino(UnaOnzaTroy), Constants.Monedas.MonedaCodigosISO.XPT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SUCRE, Constants.Monedas.MonedaCodigosISO.XSU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ReservadoParaPruebas, Constants.Monedas.MonedaCodigosISO.XTS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.UnidadDeCuentaBAD, Constants.Monedas.MonedaCodigosISO.XUA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SinDivisa, Constants.Monedas.MonedaCodigosISO.XXX));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialYemeni, Constants.Monedas.MonedaCodigosISO.YER));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rand, Constants.Monedas.MonedaCodigosISO.ZAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KwachaZambiano, Constants.Monedas.MonedaCodigosISO.ZMW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarZimbabuense, Constants.Monedas.MonedaCodigosISO.ZWL));
        }
    }
}
