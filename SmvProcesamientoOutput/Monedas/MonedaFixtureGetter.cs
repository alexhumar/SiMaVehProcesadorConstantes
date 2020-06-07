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
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Afgani, Constants.Monedas.MonedaCodigosISO.AFN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lek, Constants.Monedas.MonedaCodigosISO.ALL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraEsterlina, Constants.Monedas.MonedaCodigosISO.GBP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dinar, Constants.Monedas.MonedaCodigosISO.DZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KuanzaDeAngola, Constants.Monedas.MonedaCodigosISO.AOA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoArgentino, Constants.Monedas.MonedaCodigosISO.ARS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DramArmenio, Constants.Monedas.MonedaCodigosISO.AMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FlorinArubano, Constants.Monedas.MonedaCodigosISO.AWG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarAustraliano, Constants.Monedas.MonedaCodigosISO.AUD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ManatAzerbayano, Constants.Monedas.MonedaCodigosISO.AZN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasBahamas, Constants.Monedas.MonedaCodigosISO.BSD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarDeBarein, Constants.Monedas.MonedaCodigosISO.BHD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.TakaDeBanglades, Constants.Monedas.MonedaCodigosISO.BDT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasBarbados, Constants.Monedas.MonedaCodigosISO.BBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RubloBielorruso, Constants.Monedas.MonedaCodigosISO.BYR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarBeliceno, Constants.Monedas.MonedaCodigosISO.BZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.GultrumButanes, Constants.Monedas.MonedaCodigosISO.BTN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Boliviano, Constants.Monedas.MonedaCodigosISO.BOB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.MarcoConvertibleDeBosniaYHerzegovina, Constants.Monedas.MonedaCodigosISO.BAM));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PulaDeBotsuana, Constants.Monedas.MonedaCodigosISO.BWP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RealBrasileno, Constants.Monedas.MonedaCodigosISO.BRL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeBrunei, Constants.Monedas.MonedaCodigosISO.BND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LevaBulgaro, Constants.Monedas.MonedaCodigosISO.BGN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KiatDeBirmania, Constants.Monedas.MonedaCodigosISO.MMK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoBurundes, Constants.Monedas.MonedaCodigosISO.BIF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RielCamboyano, Constants.Monedas.MonedaCodigosISO.KHR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarCanadiense, Constants.Monedas.MonedaCodigosISO.CAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.EscudoDeCaboVerde, Constants.Monedas.MonedaCodigosISO.CVE));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeLasIslasCaiman, Constants.Monedas.MonedaCodigosISO.KYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoChileno, Constants.Monedas.MonedaCodigosISO.CLP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Yuan,Renminbi, Constants.Monedas.MonedaCodigosISO.CNY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoColombiano, Constants.Monedas.MonedaCodigosISO.COP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoComorano, Constants.Monedas.MonedaCodigosISO.KMF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCongoleno, Constants.Monedas.MonedaCodigosISO.CDF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ColonCostarricense, Constants.Monedas.MonedaCodigosISO.CRC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KunaCroata, Constants.Monedas.MonedaCodigosISO.HRK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoCubano, Constants.Monedas.MonedaCodigosISO.CUP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FlorinDeLasAntillasNeerlandesas, Constants.Monedas.MonedaCodigosISO.ANG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaCheca, Constants.Monedas.MonedaCodigosISO.CZK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaDanesa, Constants.Monedas.MonedaCodigosISO.DKK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoYibutiano, Constants.Monedas.MonedaCodigosISO.DJF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoDominicano, Constants.Monedas.MonedaCodigosISO.DOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarEstadounidense, Constants.Monedas.MonedaCodigosISO.USD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraEgipcia, Constants.Monedas.MonedaCodigosISO.EGP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ColonSalvadoreno, Constants.Monedas.MonedaCodigosISO.SVC));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NakfaDeEritrea, Constants.Monedas.MonedaCodigosISO.ERN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Bir, Constants.Monedas.MonedaCodigosISO.ETB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFP, Constants.Monedas.MonedaCodigosISO.XPF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XAF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DalasiGambiano, Constants.Monedas.MonedaCodigosISO.GMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LariGeorgiano, Constants.Monedas.MonedaCodigosISO.GEL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CediDeGana, Constants.Monedas.MonedaCodigosISO.GHS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraDeGibraltar, Constants.Monedas.MonedaCodigosISO.GIP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Quetzal, Constants.Monedas.MonedaCodigosISO.GTQ));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoGuineano, Constants.Monedas.MonedaCodigosISO.GNF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Gurde, Constants.Monedas.MonedaCodigosISO.HTG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lempira, Constants.Monedas.MonedaCodigosISO.HNL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Forinto, Constants.Monedas.MonedaCodigosISO.HUF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaIslandesa, Constants.Monedas.MonedaCodigosISO.ISK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaIndia, Constants.Monedas.MonedaCodigosISO.INR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaIndonesia, Constants.Monedas.MonedaCodigosISO.IDR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialIrani, Constants.Monedas.MonedaCodigosISO.IRR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarIraki, Constants.Monedas.MonedaCodigosISO.IQD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NuevoSequel, Constants.Monedas.MonedaCodigosISO.ILS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarJamaicano, Constants.Monedas.MonedaCodigosISO.JMD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Yen, Constants.Monedas.MonedaCodigosISO.JPY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarJordano, Constants.Monedas.MonedaCodigosISO.JOD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.TengueKazajo, Constants.Monedas.MonedaCodigosISO.KZT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinKeniano, Constants.Monedas.MonedaCodigosISO.KES));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.WonNorcoreano, Constants.Monedas.MonedaCodigosISO.KPW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.WonSurcoreano, Constants.Monedas.MonedaCodigosISO.KRW));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarKuwaiti, Constants.Monedas.MonedaCodigosISO.KWD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.SomKirguis, Constants.Monedas.MonedaCodigosISO.KGS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kip, Constants.Monedas.MonedaCodigosISO.LAK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lats, Constants.Monedas.MonedaCodigosISO.LVL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraLibanesa, Constants.Monedas.MonedaCodigosISO.LBP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LotiDeLesoto, Constants.Monedas.MonedaCodigosISO.LSL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarLiberiano, Constants.Monedas.MonedaCodigosISO.LRD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarLibio, Constants.Monedas.MonedaCodigosISO.LYD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Litas, Constants.Monedas.MonedaCodigosISO.LTL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PatacaDeMacao, Constants.Monedas.MonedaCodigosISO.MOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Denar, Constants.Monedas.MonedaCodigosISO.MKD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Ariari, Constants.Monedas.MonedaCodigosISO.MGA));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KuachaDeMalaui, Constants.Monedas.MonedaCodigosISO.MWK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Ringit, Constants.Monedas.MonedaCodigosISO.MYR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rufiya, Constants.Monedas.MonedaCodigosISO.MVR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Uguiya, Constants.Monedas.MonedaCodigosISO.MRO));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaDeMauricio, Constants.Monedas.MonedaCodigosISO.MUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoMexicano, Constants.Monedas.MonedaCodigosISO.MXN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarMicronesio, Constants.Monedas.MonedaCodigosISO.Nenhum));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LeuMoldavo, Constants.Monedas.MonedaCodigosISO.MDL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.TugrikMongol, Constants.Monedas.MonedaCodigosISO.MNT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dirham, Constants.Monedas.MonedaCodigosISO.MAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Metical, Constants.Monedas.MonedaCodigosISO.MZN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeNamibia, Constants.Monedas.MonedaCodigosISO.NAD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarNauruano, Constants.Monedas.MonedaCodigosISO.Nenhum));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaNepali, Constants.Monedas.MonedaCodigosISO.NPR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFP, Constants.Monedas.MonedaCodigosISO.XPF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDeNuevaZelanda, Constants.Monedas.MonedaCodigosISO.NZD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CordobaNicaraguense, Constants.Monedas.MonedaCodigosISO.NIO));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NairaNigeriano, Constants.Monedas.MonedaCodigosISO.NGN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaNoruega, Constants.Monedas.MonedaCodigosISO.NOK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialDeOman, Constants.Monedas.MonedaCodigosISO.OMR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaPakistani, Constants.Monedas.MonedaCodigosISO.PKR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.BalboaPanameno, Constants.Monedas.MonedaCodigosISO.PAB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Kina, Constants.Monedas.MonedaCodigosISO.PGK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.GuaraniParaguayo, Constants.Monedas.MonedaCodigosISO.PYG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Sol, Constants.Monedas.MonedaCodigosISO.PEN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoFilipino, Constants.Monedas.MonedaCodigosISO.PHP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Złoti, Constants.Monedas.MonedaCodigosISO.PLN));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialCatari, Constants.Monedas.MonedaCodigosISO.QAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LeuRumano, Constants.Monedas.MonedaCodigosISO.RON));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rublo, Constants.Monedas.MonedaCodigosISO.RUB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoRuandes, Constants.Monedas.MonedaCodigosISO.RWF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDelCaribeOriental, Constants.Monedas.MonedaCodigosISO.XCD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDelCaribeOriental, Constants.Monedas.MonedaCodigosISO.XCD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarDelCaribeOriental, Constants.Monedas.MonedaCodigosISO.XCD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Tala, Constants.Monedas.MonedaCodigosISO.WST));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dobra, Constants.Monedas.MonedaCodigosISO.STD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialSaudi, Constants.Monedas.MonedaCodigosISO.SAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarSerbio, Constants.Monedas.MonedaCodigosISO.RSD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaSeychellense, Constants.Monedas.MonedaCodigosISO.SCR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Leona, Constants.Monedas.MonedaCodigosISO.SLL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarSingapurense, Constants.Monedas.MonedaCodigosISO.SGD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarSalomonense, Constants.Monedas.MonedaCodigosISO.SBD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinSomali, Constants.Monedas.MonedaCodigosISO.SOS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Rand, Constants.Monedas.MonedaCodigosISO.ZAR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSursudanesa, Constants.Monedas.MonedaCodigosISO.SSP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RupiaCeilandesa, Constants.Monedas.MonedaCodigosISO.LKR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSudanesa, Constants.Monedas.MonedaCodigosISO.SDG));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarSurinames, Constants.Monedas.MonedaCodigosISO.SRD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Lilangeni, Constants.Monedas.MonedaCodigosISO.SZL));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.CoronaSueca, Constants.Monedas.MonedaCodigosISO.SEK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoSuizo, Constants.Monedas.MonedaCodigosISO.CHF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LibraSiria, Constants.Monedas.MonedaCodigosISO.SYP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.NuevoDolarDeTaiwan, Constants.Monedas.MonedaCodigosISO.TWD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Somoni, Constants.Monedas.MonedaCodigosISO.TJS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinTanzaniano, Constants.Monedas.MonedaCodigosISO.TZS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Bat, Constants.Monedas.MonedaCodigosISO.THB));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.FrancoCFA, Constants.Monedas.MonedaCodigosISO.XOF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Paanga, Constants.Monedas.MonedaCodigosISO.TOP));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarTrinitense, Constants.Monedas.MonedaCodigosISO.TTD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DinarTunecino, Constants.Monedas.MonedaCodigosISO.TND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.LiraTurca, Constants.Monedas.MonedaCodigosISO.TRY));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ManatTurcomano, Constants.Monedas.MonedaCodigosISO.TMT));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.ChelinUgandes, Constants.Monedas.MonedaCodigosISO.UGX));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Grivna, Constants.Monedas.MonedaCodigosISO.UAH));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dirham, Constants.Monedas.MonedaCodigosISO.AED));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarEstadounidense, Constants.Monedas.MonedaCodigosISO.USD));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.PesoUruguayo, Constants.Monedas.MonedaCodigosISO.UYU));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Sum, Constants.Monedas.MonedaCodigosISO.UZS));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.VatuDoVanuatu, Constants.Monedas.MonedaCodigosISO.VUV));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Euro, Constants.Monedas.MonedaCodigosISO.EUR));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.BolivarFuerte, Constants.Monedas.MonedaCodigosISO.VEF));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.Dong, Constants.Monedas.MonedaCodigosISO.VND));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.RialYemeni, Constants.Monedas.MonedaCodigosISO.YER));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.KuachaZambiano, Constants.Monedas.MonedaCodigosISO.ZMK));
            monedas.Add(datosEntidadBuilder.Build(Constants.Monedas.Moneda.DolarZimbabuense, Constants.Monedas.MonedaCodigosISO.ZWL));
        }
    }
}
