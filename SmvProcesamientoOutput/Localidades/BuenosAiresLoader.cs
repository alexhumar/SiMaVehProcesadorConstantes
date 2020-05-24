using SiMaVeh.Domain.DataSeed.Constants.SubdivisionesPais;
using SiMaVeh.Domain.DataSeed.Fixtures.Interfaces;
using System.Collections.Generic;

namespace SiMaVeh.Domain.DataSeed.Fixtures.Localidad.Loaders
{
    public class BuenosAiresLoader : IFixtureItemKeyValueLoader<long, long, string>
    {
        private readonly IFixturePartido fixturePartido;

        public BuenosAiresLoader(IFixturePartido fixturePartido)
        {
            this.fixturePartido = fixturePartido;
        }

        public void Load(Dictionary<long, Dictionary<long, string>> dictionary)
        {
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AdolfoAlsina).Value.Key, new Dictionary<long, string>
            {
                { 1, LocalidadAdolfoAlsina.Carhue },
                { 2, LocalidadAdolfoAlsina.Rivera },
                { 3, LocalidadAdolfoAlsina.VillaMaza },
                { 4, LocalidadAdolfoAlsina.SanMiguelArcangel },
                { 5, LocalidadAdolfoAlsina.EstebanAgustinGascon },
                { 6, LocalidadAdolfoAlsina.DelfinHuergo },
                { 7, LocalidadAdolfoAlsina.LaPala },
                { 8, LocalidadAdolfoAlsina.Thames },
                { 9, LocalidadAdolfoAlsina.Yutuyaco },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AdolfoGonzalesChaves).Value.Key, new Dictionary<long, string>
            {
                { 10, LocalidadAdolfoGonzalesChaves.GonzalesChaves },
                { 11, LocalidadAdolfoGonzalesChaves.DeLaGarma },
                { 12, LocalidadAdolfoGonzalesChaves.JuanEulogioBarra },
                { 13, LocalidadAdolfoGonzalesChaves.Vasquez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Alberti).Value.Key, new Dictionary<long, string>
            {
                { 14, LocalidadAlberti.Alberti },
                { 15, LocalidadAlberti.Mechita },
                { 16, LocalidadAlberti.VillaOrtiz },
                { 17, LocalidadAlberti.Pla },
                { 18, LocalidadAlberti.CoronelSegui },
                { 19, LocalidadAlberti.VillaGrisolia },
                { 20, LocalidadAlberti.VillaMaria },
                { 21, LocalidadAlberti.GobernadorUgarte },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AlmiranteBrown).Value.Key, new Dictionary<long, string>
            {
                { 22, LocalidadAlmiranteBrown.Adrogue },
                { 23, LocalidadAlmiranteBrown.Burzaco },
                { 24, LocalidadAlmiranteBrown.Glew },
                { 25, LocalidadAlmiranteBrown.Claypole },
                { 26, LocalidadAlmiranteBrown.RafaelCalzada },
                { 27, LocalidadAlmiranteBrown.Longchamps },
                { 28, LocalidadAlmiranteBrown.JoseMarmol },
                { 29, LocalidadAlmiranteBrown.MinistroRivadavia },
                { 30, LocalidadAlmiranteBrown.MalvinasArgentinas },
                { 31, LocalidadAlmiranteBrown.SanFranciscoDeAsis },
                { 32, LocalidadAlmiranteBrown.SanJose },
                { 33, LocalidadAlmiranteBrown.SanFranciscoSolano },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Arrecifes).Value.Key, new Dictionary<long, string>
            {
                { 34, LocalidadArrecifes.Arrecifes },
                { 35, LocalidadArrecifes.Todd },
                { 36, LocalidadArrecifes.Vina },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Avellaneda).Value.Key, new Dictionary<long, string>
            {
                { 37, LocalidadAvellaneda.AvellanedaCentro },
                { 38, LocalidadAvellaneda.DockSud },
                { 39, LocalidadAvellaneda.Gerli },
                { 40, LocalidadAvellaneda.Pineyro },
                { 41, LocalidadAvellaneda.Sarandi },
                { 42, LocalidadAvellaneda.VillaDominico },
                { 43, LocalidadAvellaneda.Wilde },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ayacucho).Value.Key, new Dictionary<long, string>
            {
                { 44, LocalidadAyacucho.Ayacucho },
                { 45, LocalidadAyacucho.Udaquiola },
                { 46, LocalidadAyacucho.LaConstancia },
                { 47, LocalidadAyacucho.Solanet },
                { 48, LocalidadAyacucho.ParajeCangallo },
                { 49, LocalidadAyacucho.ParajeLangueyu },
                { 50, LocalidadAyacucho.ParajeFair },
                { 51, LocalidadAyacucho.ParajeSanIgnacio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Azul).Value.Key, new Dictionary<long, string>
            {
                { 52, LocalidadAzul.Azul },
                { 53, LocalidadAzul.Chillar },
                { 54, LocalidadAzul.Cachari },
                { 55, LocalidadAzul.DieciseisDeJulio },
                { 56, LocalidadAzul.Ariel },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.BahiaBlanca).Value.Key, new Dictionary<long, string>
            {
                { 57, LocalidadBahiaBlanca.BahiaBlanca },
                { 58, LocalidadBahiaBlanca.IngenieroWhite },
                { 59, LocalidadBahiaBlanca.GeneralDanielCerri },
                { 60, LocalidadBahiaBlanca.Grunbein },
                { 61, LocalidadBahiaBlanca.Cabildo },
                { 62, LocalidadBahiaBlanca.VillaEspora },
                { 63, LocalidadBahiaBlanca.VillaBordeu },
                { 64, LocalidadBahiaBlanca.LaViticola },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Balcarce).Value.Key, new Dictionary<long, string>
            {
                { 65, LocalidadBalcarce.Balcarce },
                { 66, LocalidadBalcarce.SanAgustin },
                { 67, LocalidadBalcarce.Napaleofu },
                { 68, LocalidadBalcarce.LosPinos },
                { 69, LocalidadBalcarce.VillaLagunaLaBrava },
                { 70, LocalidadBalcarce.RamosOtero },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Baradero).Value.Key, new Dictionary<long, string>
            {
                { 71, LocalidadBaradero.Baradero },
                { 72, LocalidadBaradero.VillaAlsina },
                { 73, LocalidadBaradero.IreneoPortela },
                { 74, LocalidadBaradero.SantaColoma },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.BenitoJuarez).Value.Key, new Dictionary<long, string>
            {
                { 75, LocalidadBenitoJuarez.BenitoJuarez },
                { 76, LocalidadBenitoJuarez.VillaCacique },
                { 77, LocalidadBenitoJuarez.Barker },
                { 78, LocalidadBenitoJuarez.EstacionLopez },
                { 79, LocalidadBenitoJuarez.TedinUriburu },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Berazategui).Value.Key, new Dictionary<long, string>
            {
                { 80, LocalidadBerazategui.Berazategui },
                { 81, LocalidadBerazategui.Hudson },
                { 82, LocalidadBerazategui.JuanMariaGutierrez },
                { 83, LocalidadBerazategui.Ranelagh },
                { 84, LocalidadBerazategui.Sourigues },
                { 85, LocalidadBerazategui.Pereyra },
                { 86, LocalidadBerazategui.Platanos },
                { 87, LocalidadBerazategui.VillaEspana },
                { 88, LocalidadBerazategui.ElPato },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Berisso).Value.Key, new Dictionary<long, string>
            {
                { 89, LocalidadBerisso.Berisso },
                { 90, LocalidadBerisso.VillaProgreso },
                { 91, LocalidadBerisso.VillaSanCarlos },
                { 92, LocalidadBerisso.VillaIndependencia },
                { 93, LocalidadBerisso.BarrioElCarmenEste },
                { 94, LocalidadBerisso.VillaDolores },
                { 95, LocalidadBerisso.VillaArguello },
                { 96, LocalidadBerisso.VillaZula },
                { 97, LocalidadBerisso.BarrioBancoProvincia },
                { 98, LocalidadBerisso.VillaNueva },
                { 99, LocalidadBerisso.BarrioUniversitario },
                { 100, LocalidadBerisso.LosTalas },
                { 101, LocalidadBerisso.PaloBlanco },
                { 102, LocalidadBerisso.VillaBancoConstructor },
                { 103, LocalidadBerisso.LosCatorce },
                { 104, LocalidadBerisso.VillaEspana },
                { 105, LocalidadBerisso.LaBalandra },
                { 106, LocalidadBerisso.JuanBJusto },
                { 107, LocalidadBerisso.BarrioObrero },
                { 108, LocalidadBerisso.BarrioSantaTeresita },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Bolivar).Value.Key, new Dictionary<long, string>
            {
                { 109, LocalidadBolivar.SanCarlosDeBolivar },
                { 110, LocalidadBolivar.Urdampilleta },
                { 111, LocalidadBolivar.Pirovano },
                { 112, LocalidadBolivar.Hale },
                { 113, LocalidadBolivar.JuanFIbarra },
                { 114, LocalidadBolivar.Paula },
                { 115, LocalidadBolivar.MarianoUnzue },
                { 116, LocalidadBolivar.VillaLynchPueyrredon },
                { 117, LocalidadBolivar.ParajeVallimanca },
                { 118, LocalidadBolivar.ParajeVillaSanz },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Bragado).Value.Key, new Dictionary<long, string>
            {
                { 119, LocalidadBragado.Bragado },
                { 120, LocalidadBragado.EduardoObrien },
                { 121, LocalidadBragado.Mechita },
                { 122, LocalidadBragado.ComodoroPy },
                { 123, LocalidadBragado.Warnes },
                { 124, LocalidadBragado.Irala },
                { 125, LocalidadBragado.Olascoaga },
                { 126, LocalidadBragado.MaximoFernandez },
                { 127, LocalidadBragado.LaLimpia },
                { 128, LocalidadBragado.Asamblea },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Brandsen).Value.Key, new Dictionary<long, string>
            {
                { 129, LocalidadBrandsen.Brandsen },
                { 130, LocalidadBrandsen.Jeppener },
                { 131, LocalidadBrandsen.Gomez },
                { 132, LocalidadBrandsen.Altamirano },
                { 133, LocalidadBrandsen.Samborombon },
                { 134, LocalidadBrandsen.Oliden },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Campana).Value.Key, new Dictionary<long, string>
            {
                { 135, LocalidadCampana.Campana },
                { 136, LocalidadCampana.AltoLosCardales },
                { 137, LocalidadCampana.LomasDelRioLujan },
                { 138, LocalidadCampana.IngenieroRomuloOtamendi },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Canuelas).Value.Key, new Dictionary<long, string>
            {
                { 139, LocalidadCanuelas.Canuelas },
                { 140, LocalidadCanuelas.SantaRosa },
                { 141, LocalidadCanuelas.AlejandroPetion },
                { 142, LocalidadCanuelas.MaximoPaz },
                { 143, LocalidadCanuelas.Uribelarrea },
                { 144, LocalidadCanuelas.VicenteCasares },
                { 145, LocalidadCanuelas.GobernadorUdaondo },
                { 146, LocalidadCanuelas.ElTaladro },
                { 147, LocalidadCanuelas.SantaAnita },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CapitanSarmiento).Value.Key, new Dictionary<long, string>
            {
                { 148, LocalidadCapitanSarmiento.CapitanSarmiento },
                { 149, LocalidadCapitanSarmiento.LaLuisa },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CarlosCasares).Value.Key, new Dictionary<long, string>
            {
                { 150, LocalidadCarlosCasares.CarlosCasares },
                { 151, LocalidadCarlosCasares.Smith },
                { 152, LocalidadCarlosCasares.Bellocq },
                { 153, LocalidadCarlosCasares.Moctezuma },
                { 154, LocalidadCarlosCasares.Cadret },
                { 155, LocalidadCarlosCasares.Hortensia },
                { 156, LocalidadCarlosCasares.Ordoqui },
                { 157, LocalidadCarlosCasares.MauricioHirsch },
                { 158, LocalidadCarlosCasares.ColoniaMauricio },
                { 159, LocalidadCarlosCasares.LaSofia },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CarlosTejedor).Value.Key, new Dictionary<long, string>
            {
                { 160, LocalidadCarlosTejedor.CarlosTejedor },
                { 161, LocalidadCarlosTejedor.TresAlgarrobos },
                { 162, LocalidadCarlosTejedor.ColoniaSere },
                { 163, LocalidadCarlosTejedor.Timote },
                { 164, LocalidadCarlosTejedor.Curaru },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CarmenDeAreco).Value.Key, new Dictionary<long, string>
            {
                { 165, LocalidadCarmenDeAreco.CarmenDeAreco },
                { 166, LocalidadCarmenDeAreco.TresSargentos },
                { 167, LocalidadCarmenDeAreco.PuebloGouin },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Castelli).Value.Key, new Dictionary<long, string>
            {
                { 168, LocalidadCastelli.Castelli },
                { 169, LocalidadCastelli.CentroGuerrero },
                { 170, LocalidadCastelli.CerroDeLaGloria },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Chacabuco).Value.Key, new Dictionary<long, string>
            {
                { 171, LocalidadChacabuco.Chacabuco },
                { 172, LocalidadChacabuco.Rawson },
                { 173, LocalidadChacabuco.Ohiggins },
                { 174, LocalidadChacabuco.Castilla },
                { 175, LocalidadChacabuco.LosAngeles },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Chascomus).Value.Key, new Dictionary<long, string>
            {
                { 176, LocalidadChascomus.Chascomus },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Chivilcoy).Value.Key, new Dictionary<long, string>
            {
                { 177, LocalidadChivilcoy.Chivilcoy },
                { 178, LocalidadChivilcoy.Moquehua },
                { 179, LocalidadChivilcoy.Gorostiaga },
                { 180, LocalidadChivilcoy.EmilioAyarza },
                { 181, LocalidadChivilcoy.LaRica },
                { 182, LocalidadChivilcoy.SanSebastian },
                { 183, LocalidadChivilcoy.Benitez },
                { 184, LocalidadChivilcoy.HenryBell },
                { 185, LocalidadChivilcoy.Indacochea },
                { 186, LocalidadChivilcoy.PalemonHuergo },
                { 187, LocalidadChivilcoy.RamonBiaus },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Colon).Value.Key, new Dictionary<long, string>
            {
                { 188, LocalidadColon.Colon },
                { 189, LocalidadColon.Pearson },
                { 190, LocalidadColon.Sarasa },
                { 191, LocalidadColon.ElArbolito },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelDorrego).Value.Key, new Dictionary<long, string>
            {
                { 192, LocalidadCoronelDorrego.CoronelDorrego },
                { 193, LocalidadCoronelDorrego.Oriente },
                { 194, LocalidadCoronelDorrego.ElPerdido },
                { 195, LocalidadCoronelDorrego.Aparicio },
                { 196, LocalidadCoronelDorrego.SanRoman },
                { 197, LocalidadCoronelDorrego.BalnearioMarisol },
                { 198, LocalidadCoronelDorrego.Irene },
                { 199, LocalidadCoronelDorrego.Faro },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelPringles).Value.Key, new Dictionary<long, string>
            {
                { 200, LocalidadCoronelPringles.CoronelPringles },
                { 201, LocalidadCoronelPringles.IndioRico },
                { 202, LocalidadCoronelPringles.Lartigau },
                { 203, LocalidadCoronelPringles.ElPensamiento },
                { 204, LocalidadCoronelPringles.ElDivisorio },
                { 205, LocalidadCoronelPringles.Frapal },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelRosales).Value.Key, new Dictionary<long, string>
            {
                { 206, LocalidadCoronelRosales.PuntaAlta },
                { 207, LocalidadCoronelRosales.VillaGeneralArias },
                { 208, LocalidadCoronelRosales.BalnearioPehuen-Co },
                { 209, LocalidadCoronelRosales.VillaDelMar },
                { 210, LocalidadCoronelRosales.BajoHondo },
                { 211, LocalidadCoronelRosales.Calderon },
                { 212, LocalidadCoronelRosales.PuertoRosales },
                { 213, LocalidadCoronelRosales.BaseNavalPuertoBelgrano },
                { 214, LocalidadCoronelRosales.ArroyoPareja },
                { 215, LocalidadCoronelRosales.PuntaAncla },
                { 216, LocalidadCoronelRosales.BaseDeInfanteriaDeMarinaBaterias },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelSuarez).Value.Key, new Dictionary<long, string>
            {
                { 217, LocalidadCoronelSuarez.CoronelSuarez },
                { 218, LocalidadCoronelSuarez.Huanguelen },
                { 219, LocalidadCoronelSuarez.SanJose },
                { 220, LocalidadCoronelSuarez.SantaMaria },
                { 221, LocalidadCoronelSuarez.SantaTrinidad },
                { 222, LocalidadCoronelSuarez.VillaArcadia },
                { 223, LocalidadCoronelSuarez.Pasman },
                { 224, LocalidadCoronelSuarez.CuraMalal },
                { 225, LocalidadCoronelSuarez.EstacionPineyro },
                { 226, LocalidadCoronelSuarez.Dorbigny },
                { 227, LocalidadCoronelSuarez.Cascada },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Daireaux).Value.Key, new Dictionary<long, string>
            {
                { 228, LocalidadDaireaux.Daireaux },
                { 229, LocalidadDaireaux.SalazarMouras },
                { 230, LocalidadDaireaux.Arboledas },
                { 231, LocalidadDaireaux.LaCopeta },
                { 232, LocalidadDaireaux.LaLarga },
                { 233, LocalidadDaireaux.LaManuela },
                { 234, LocalidadDaireaux.Luro },
                { 235, LocalidadDaireaux.Andant },
                { 236, LocalidadDaireaux.EnriqueLavalleFreyre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Dolores).Value.Key, new Dictionary<long, string>
            {
                { 237, LocalidadDolores.Dolores },
                { 238, LocalidadDolores.Sevigne },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ensenada).Value.Key, new Dictionary<long, string>
            {
                { 239, LocalidadEnsenada.Ensenada },
                { 240, LocalidadEnsenada.PuntaLara },
                { 241, LocalidadEnsenada.VillaCatella },
                { 242, LocalidadEnsenada.DiqueN1 },
                { 243, LocalidadEnsenada.IslaSantiagoOeste },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Escobar).Value.Key, new Dictionary<long, string>
            {
                { 244, LocalidadEscobar.BelenDeEscobar },
                { 245, LocalidadEscobar.Garin },
                { 246, LocalidadEscobar.IngenieroMaschwitz },
                { 247, LocalidadEscobar.Matheu },
                { 248, LocalidadEscobar.MaquinistaFSavio },
                { 249, LocalidadEscobar.PuertoParana },
                { 250, LocalidadEscobar.LomaVerde },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.EstebanEcheverria).Value.Key, new Dictionary<long, string>
            {
                { 251, LocalidadEstebanEcheverria.NueveDeAbril },
                { 252, LocalidadEstebanEcheverria.CanningOriental },
                { 253, LocalidadEstebanEcheverria.ElJaguel },
                { 254, LocalidadEstebanEcheverria.LuisGuillon },
                { 255, LocalidadEstebanEcheverria.MonteGrande },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.ExaltacionDeLaCruz).Value.Key, new Dictionary<long, string>
            {
                { 256, LocalidadExaltacionDeLaCruz.CapillaDelSenor },
                { 257, LocalidadExaltacionDeLaCruz.LosCardales },
                { 258, LocalidadExaltacionDeLaCruz.Pavon },
                { 259, LocalidadExaltacionDeLaCruz.ArroyoDeLaCruz },
                { 260, LocalidadExaltacionDeLaCruz.ParadaOrlando },
                { 261, LocalidadExaltacionDeLaCruz.ParadaRobles },
                { 262, LocalidadExaltacionDeLaCruz.ElRemanso },
                { 263, LocalidadExaltacionDeLaCruz.Etchegoyen },
                { 264, LocalidadExaltacionDeLaCruz.ParadaLaLata-LaLoma },
                { 265, LocalidadExaltacionDeLaCruz.DiegoGaynor },
                { 266, LocalidadExaltacionDeLaCruz.GobernadorAndonaegui },
                { 267, LocalidadExaltacionDeLaCruz.Chenaut },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ezeiza).Value.Key, new Dictionary<long, string>
            {
                { 268, LocalidadEzeiza.AeropuertoInternacionalEzeiza },
                { 269, LocalidadEzeiza.CanningOccidental },
                { 270, LocalidadEzeiza.CarlosSpegazzini },
                { 271, LocalidadEzeiza.Ezeiza },
                { 272, LocalidadEzeiza.LaUnion },
                { 273, LocalidadEzeiza.TristanSuarez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.FlorencioVarela).Value.Key, new Dictionary<long, string>
            {
                { 274, LocalidadFlorencioVarela.CiudadDeBosques },
                { 275, LocalidadFlorencioVarela.CiudadDeFlorencioVarela },
                { 276, LocalidadFlorencioVarela.EstanislaoSeveroZeballos },
                { 277, LocalidadFlorencioVarela.GobernadorJulioACosta },
                { 278, LocalidadFlorencioVarela.IngenieroJuanAllan },
                { 279, LocalidadFlorencioVarela.LaCapilla },
                { 280, LocalidadFlorencioVarela.VillaBrown },
                { 281, LocalidadFlorencioVarela.VillaSanLuis },
                { 282, LocalidadFlorencioVarela.VillaSantaRosa },
                { 283, LocalidadFlorencioVarela.VillaVatteone },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.FlorentinoAmeghino).Value.Key, new Dictionary<long, string>
            {
                { 284, LocalidadFlorentinoAmeghino.FlorentinoAmeghino },
                { 285, LocalidadFlorentinoAmeghino.Blaquier },
                { 286, LocalidadFlorentinoAmeghino.Porvenir },
                { 287, LocalidadFlorentinoAmeghino.ParajeNuevaSuiza },
                { 288, LocalidadFlorentinoAmeghino.ParajePorvenir },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralAlvarado).Value.Key, new Dictionary<long, string>
            {
                { 289, LocalidadGeneralAlvarado.Miramar },
                { 290, LocalidadGeneralAlvarado.MarDelSur },
                { 291, LocalidadGeneralAlvarado.ComandanteNicanorOtamendi },
                { 292, LocalidadGeneralAlvarado.Mechongue },
                { 293, LocalidadGeneralAlvarado.CentinelaDelMar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralAlvear).Value.Key, new Dictionary<long, string>
            {
                { 294, LocalidadGeneralAlvear.GeneralAlvear },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralArenales).Value.Key, new Dictionary<long, string>
            {
                { 295, LocalidadGeneralArenales.GeneralArenales },
                { 296, LocalidadGeneralArenales.Arribenos },
                { 297, LocalidadGeneralArenales.Ascension },
                { 298, LocalidadGeneralArenales.EstacionArenales },
                { 299, LocalidadGeneralArenales.Ferre },
                { 300, LocalidadGeneralArenales.LaAngelita },
                { 301, LocalidadGeneralArenales.LaTrinidad },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralBelgrano).Value.Key, new Dictionary<long, string>
            {
                { 302, LocalidadGeneralBelgrano.GeneralBelgrano },
                { 303, LocalidadGeneralBelgrano.Gorchs },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralGuido).Value.Key, new Dictionary<long, string>
            {
                { 304, LocalidadGeneralGuido.GeneralGuido },
                { 305, LocalidadGeneralGuido.Labarden },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralMadariaga).Value.Key, new Dictionary<long, string>
            {
                { 306, LocalidadGeneralMadariaga.GeneralMadariaga },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralLaMadrid).Value.Key, new Dictionary<long, string>
            {
                { 307, LocalidadGeneralLaMadrid.GeneralLaMadrid },
                { 308, LocalidadGeneralLaMadrid.LaColina },
                { 309, LocalidadGeneralLaMadrid.Libano },
                { 310, LocalidadGeneralLaMadrid.LasMartinetas },
                { 311, LocalidadGeneralLaMadrid.Pontaut },
                { 312, LocalidadGeneralLaMadrid.Lastra },
                { 313, LocalidadGeneralLaMadrid.Quilco },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralLasHeras).Value.Key, new Dictionary<long, string>
            {
                { 314, LocalidadGeneralLasHeras.GeneralLasHeras },
                { 315, LocalidadGeneralLasHeras.Villars },
                { 316, LocalidadGeneralLasHeras.GeneralHornos },
                { 317, LocalidadGeneralLasHeras.Plomer },
                { 318, LocalidadGeneralLasHeras.LaChoza },
                { 319, LocalidadGeneralLasHeras.Lozano },
                { 320, LocalidadGeneralLasHeras.EnriqueFynn },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralLavalle).Value.Key, new Dictionary<long, string>
            {
                { 321, LocalidadGeneralLavalle.GeneralLavalle },
                { 322, LocalidadGeneralLavalle.Pavon },
                { 323, LocalidadGeneralLavalle.LasChacras },
                { 324, LocalidadGeneralLavalle.LasTijeras },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralPaz).Value.Key, new Dictionary<long, string>
            {
                { 325, LocalidadGeneralPaz.Ranchos },
                { 326, LocalidadGeneralPaz.LomaVerde },
                { 327, LocalidadGeneralPaz.Villanueva },
                { 328, LocalidadGeneralPaz.BarrioRioSalado },
                { 329, LocalidadGeneralPaz.Alegre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralPinto).Value.Key, new Dictionary<long, string>
            {
                { 330, LocalidadGeneralPinto.GeneralPinto },
                { 331, LocalidadGeneralPinto.Germania },
                { 332, LocalidadGeneralPinto.VillaFrancia },
                { 333, LocalidadGeneralPinto.ColoniaSanRicardo },
                { 334, LocalidadGeneralPinto.VillaRoth },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralPueyrredon).Value.Key, new Dictionary<long, string>
            {
                { 335, LocalidadGeneralPueyrredon.MarDelPlata },
                { 336, LocalidadGeneralPueyrredon.LasQuintas },
                { 337, LocalidadGeneralPueyrredon.LosZorzales },
                { 338, LocalidadGeneralPueyrredon.ElSosiego },
                { 339, LocalidadGeneralPueyrredon.EstacionCamet },
                { 340, LocalidadGeneralPueyrredon.SantaAngela },
                { 341, LocalidadGeneralPueyrredon.Barrio2DeAbril },
                { 342, LocalidadGeneralPueyrredon.LaAdela },
                { 343, LocalidadGeneralPueyrredon.LasMargaritas },
                { 344, LocalidadGeneralPueyrredon.ElDorado },
                { 345, LocalidadGeneralPueyrredon.ColinasVerdes },
                { 346, LocalidadGeneralPueyrredon.BarrioLaGloriaDeLaPeregrina },
                { 347, LocalidadGeneralPueyrredon.SierraDeLosPadres },
                { 348, LocalidadGeneralPueyrredon.ElCoyunco },
                { 349, LocalidadGeneralPueyrredon.LagunaDeLosPadres },
                { 350, LocalidadGeneralPueyrredon.SantaPaula },
                { 351, LocalidadGeneralPueyrredon.Batan },
                { 352, LocalidadGeneralPueyrredon.BarrioEstacionChapadmalal },
                { 353, LocalidadGeneralPueyrredon.BarrioFelixUCamet },
                { 354, LocalidadGeneralPueyrredon.BarrioLosAcantilados },
                { 355, LocalidadGeneralPueyrredon.BarrioChapadmalal },
                { 356, LocalidadGeneralPueyrredon.BarrioSanEduardoDelMar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralRodriguez).Value.Key, new Dictionary<long, string>
            {
                { 357, LocalidadGeneralRodriguez.GeneralRodriguez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 358, LocalidadGeneralSanMartin.Billinghurst },
                { 359, LocalidadGeneralSanMartin.LomaHermosa },
                { 360, LocalidadGeneralSanMartin.JoseLeonSuarez },
                { 361, LocalidadGeneralSanMartin.SanAndres },
                { 362, LocalidadGeneralSanMartin.SanMartin },
                { 363, LocalidadGeneralSanMartin.VillaAyacucho },
                { 364, LocalidadGeneralSanMartin.VillaChacabuco },
                { 365, LocalidadGeneralSanMartin.VillaBallester },
                { 366, LocalidadGeneralSanMartin.VillaLynch },
                { 367, LocalidadGeneralSanMartin.VillaMaipu },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralViamonte).Value.Key, new Dictionary<long, string>
            {
                { 368, LocalidadGeneralViamonte.LosToldos },
                { 369, LocalidadGeneralViamonte.Baigorrita },
                { 370, LocalidadGeneralViamonte.Zavalia },
                { 371, LocalidadGeneralViamonte.SanEmilio },
                { 372, LocalidadGeneralViamonte.LaDelfina },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralVillegas).Value.Key, new Dictionary<long, string>
            {
                { 373, LocalidadGeneralVillegas.GeneralVillegas },
                { 374, LocalidadGeneralVillegas.Piedritas },
                { 375, LocalidadGeneralVillegas.EmilioVBunge },
                { 376, LocalidadGeneralVillegas.CoronelCharlone },
                { 377, LocalidadGeneralVillegas.Banderalo },
                { 378, LocalidadGeneralVillegas.CanadaSeca },
                { 379, LocalidadGeneralVillegas.VillaSauze },
                { 380, LocalidadGeneralVillegas.SantaRegina },
                { 381, LocalidadGeneralVillegas.VillaSaboya },
                { 382, LocalidadGeneralVillegas.SantaEleodora },
                { 383, LocalidadGeneralVillegas.MasseyEstElordi },
                { 384, LocalidadGeneralVillegas.Pichincha },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Guamini).Value.Key, new Dictionary<long, string>
            {
                { 385, LocalidadGuamini.LagunaAlsina },
                { 386, LocalidadGuamini.Casbas },
                { 387, LocalidadGuamini.Guamini },
                { 388, LocalidadGuamini.VictorinoDeLaPlaza },
                { 389, LocalidadGuamini.Garre },
                { 390, LocalidadGuamini.ArroyoVenado },
                { 391, LocalidadGuamini.Huanguelen },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.HipolitoYrigoyen).Value.Key, new Dictionary<long, string>
            {
                { 392, LocalidadHipolitoYrigoyen.Henderson },
                { 393, LocalidadHipolitoYrigoyen.HerreraVegas },
                { 394, LocalidadHipolitoYrigoyen.MariaLucila },
                { 395, LocalidadHipolitoYrigoyen.Coraceros },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Hurlingham).Value.Key, new Dictionary<long, string>
            {
                { 396, LocalidadHurlingham.Hurlingham },
                { 397, LocalidadHurlingham.VillaTesei },
                { 398, LocalidadHurlingham.WilliamCMorris },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ituzaingo).Value.Key, new Dictionary<long, string>
            {
                { 399, LocalidadItuzaingo.Ituzaingo },
                { 400, LocalidadItuzaingo.VillaUdaondo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.JoseCPaz).Value.Key, new Dictionary<long, string>
            {
                { 401, LocalidadJoseCPaz.JoseCPaz },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Junin).Value.Key, new Dictionary<long, string>
            {
                { 402, LocalidadJunin.Junin },
                { 403, LocalidadJunin.Morse },
                { 404, LocalidadJunin.AgustinRoca },
                { 405, LocalidadJunin.FortinTiburcio },
                { 406, LocalidadJunin.Saforcada },
                { 407, LocalidadJunin.Agustina },
                { 408, LocalidadJunin.Laplacette },
                { 409, LocalidadJunin.BalnearioLagunaDeGomez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LaCosta).Value.Key, new Dictionary<long, string>
            {
                { 410, LocalidadLaCosta.SanClementeDelTuyu },
                { 411, LocalidadLaCosta.LasToninas },
                { 412, LocalidadLaCosta.CostaChica },
                { 413, LocalidadLaCosta.SantaTeresita },
                { 414, LocalidadLaCosta.MarDelTuyu },
                { 415, LocalidadLaCosta.CostaDelEste },
                { 416, LocalidadLaCosta.AguasVerdes },
                { 417, LocalidadLaCosta.LaLucilaDelMar },
                { 418, LocalidadLaCosta.CostaAzul },
                { 419, LocalidadLaCosta.SanBernardoDelTuyu },
                { 420, LocalidadLaCosta.MarDeAjo },
                { 421, LocalidadLaCosta.NuevaAtlantis },
                { 422, LocalidadLaCosta.PuntaMedanos },
                { 423, LocalidadLaCosta.PinarDelSol },
                { 424, LocalidadLaCosta.CostaEsmeralda },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LaMatanza).Value.Key, new Dictionary<long, string>
            {
                { 425, LocalidadLaMatanza.SanJusto },
                { 426, LocalidadLaMatanza.20DeJunio },
                { 427, LocalidadLaMatanza.AldoBonzi },
                { 428, LocalidadLaMatanza.CiudadCelina },
                { 429, LocalidadLaMatanza.CiudadEvita },
                { 430, LocalidadLaMatanza.GonzalezCatan },
                { 431, LocalidadLaMatanza.GregorioDeLaferrere },
                { 432, LocalidadLaMatanza.IsidroCasanova },
                { 433, LocalidadLaMatanza.LaTablada },
                { 434, LocalidadLaMatanza.LomasDelMirador },
                { 435, LocalidadLaMatanza.RafaelCastillo },
                { 436, LocalidadLaMatanza.RamosMejia },
                { 437, LocalidadLaMatanza.Tapiales },
                { 438, LocalidadLaMatanza.VillaLuzuriaga },
                { 439, LocalidadLaMatanza.VillaMadero },
                { 440, LocalidadLaMatanza.VirreyDelPino },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LaPlata).Value.Key, new Dictionary<long, string>
            {
                { 441, LocalidadLaPlata.CountryClubElRodeo },
                { 442, LocalidadLaPlata.BarrioRutaSol },
                { 443, LocalidadLaPlata.Abasto },
                { 444, LocalidadLaPlata.AngelEtcheverry },
                { 445, LocalidadLaPlata.Arana },
                { 446, LocalidadLaPlata.ArturoSegui },
                { 447, LocalidadLaPlata.BarrioElCarmen },
                { 448, LocalidadLaPlata.BarrioGambier },
                { 449, LocalidadLaPlata.BarrioLasMalvinas },
                { 450, LocalidadLaPlata.BarrioLasQuintas },
                { 451, LocalidadLaPlata.CityBell },
                { 452, LocalidadLaPlata.ElRetiro },
                { 453, LocalidadLaPlata.JoaquinGorina },
                { 454, LocalidadLaPlata.JoseHernandez },
                { 455, LocalidadLaPlata.JoseMelchorRomero },
                { 456, LocalidadLaPlata.LaCumbre },
                { 457, LocalidadLaPlata.CascoUrbano },
                { 458, LocalidadLaPlata.LisandroOlmos },
                { 459, LocalidadLaPlata.LosHornos },
                { 460, LocalidadLaPlata.ManuelBGonnet },
                { 461, LocalidadLaPlata.Ringuelet },
                { 462, LocalidadLaPlata.AltosDeSanLorenzo },
                { 463, LocalidadLaPlata.Tolosa },
                { 464, LocalidadLaPlata.Transradio },
                { 465, LocalidadLaPlata.VillaElisa },
                { 466, LocalidadLaPlata.VillaElvira },
                { 467, LocalidadLaPlata.VillaGaribaldi },
                { 468, LocalidadLaPlata.VillaMontoro },
                { 469, LocalidadLaPlata.VillaParqueSicardi },
                { 470, LocalidadLaPlata.IgnacioCorreas },
                { 471, LocalidadLaPlata.LomasDeCopello },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lanus).Value.Key, new Dictionary<long, string>
            {
                { 472, LocalidadLanus.LanusOeste },
                { 473, LocalidadLanus.LanusEste },
                { 474, LocalidadLanus.RemediosDeEscalada },
                { 475, LocalidadLanus.Gerli },
                { 476, LocalidadLanus.ValentinAlsina },
                { 477, LocalidadLanus.MonteChingolo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Laprida).Value.Key, new Dictionary<long, string>
            {
                { 478, LocalidadLaprida.Laprida },
                { 479, LocalidadLaprida.PuebloSanJorge },
                { 480, LocalidadLaprida.PuebloNuevo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LasFlores).Value.Key, new Dictionary<long, string>
            {
                { 481, LocalidadLasFlores.LasFlores },
                { 482, LocalidadLasFlores.Pardo },
                { 483, LocalidadLasFlores.ElTrigo },
                { 484, LocalidadLasFlores.CoronelBoerr },
                { 485, LocalidadLasFlores.Rosas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LeandroNAlem).Value.Key, new Dictionary<long, string>
            {
                { 486, LocalidadLeandroNAlem.Vedia },
                { 487, LocalidadLeandroNAlem.JuanBautistaAlberdi },
                { 488, LocalidadLeandroNAlem.LeandroNAlem },
                { 489, LocalidadLeandroNAlem.AlberdiViejo },
                { 490, LocalidadLeandroNAlem.ElDorado },
                { 491, LocalidadLeandroNAlem.FortinAcha },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lezama).Value.Key, new Dictionary<long, string>
            {
                { 492, LocalidadLezama.Lezama },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lincoln).Value.Key, new Dictionary<long, string>
            {
                { 493, LocalidadLincoln.Lincoln },
                { 494, LocalidadLincoln.Roberts },
                { 495, LocalidadLincoln.Pasteur },
                { 496, LocalidadLincoln.ElTriunfo },
                { 497, LocalidadLincoln.Arenaza },
                { 498, LocalidadLincoln.CoronelMartinezDeHoz },
                { 499, LocalidadLincoln.Bayauca },
                { 500, LocalidadLincoln.LasToscas },
                { 501, LocalidadLincoln.CarlosSalas },
                { 502, LocalidadLincoln.Triunvirato },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Loberia).Value.Key, new Dictionary<long, string>
            {
                { 503, LocalidadLoberia.Loberia },
                { 504, LocalidadLoberia.SanManuel },
                { 505, LocalidadLoberia.Tamangueyu },
                { 506, LocalidadLoberia.LicenciadoMatienzo },
                { 507, LocalidadLoberia.Pieres },
                { 508, LocalidadLoberia.ArenasVerdes },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lobos).Value.Key, new Dictionary<long, string>
            {
                { 509, LocalidadLobos.AntonioCarboni },
                { 510, LocalidadLobos.Elvira },
                { 511, LocalidadLobos.JoseSantosArevalo },
                { 512, LocalidadLobos.Lobos },
                { 513, LocalidadLobos.EmpalmeLobos },
                { 514, LocalidadLobos.LasChacras },
                { 515, LocalidadLobos.SalvadorMaria },
                { 516, LocalidadLobos.VillaLoguercio },
                { 517, LocalidadLobos.Zapiola },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LomasDeZamora).Value.Key, new Dictionary<long, string>
            {
                { 518, LocalidadLomasDeZamora.LomasDeZamora },
                { 519, LocalidadLomasDeZamora.Banfield },
                { 520, LocalidadLomasDeZamora.Temperley },
                { 521, LocalidadLomasDeZamora.Llavallol },
                { 522, LocalidadLomasDeZamora.Turdera },
                { 523, LocalidadLomasDeZamora.VillaCentenario },
                { 524, LocalidadLomasDeZamora.VillaFiorito },
                { 525, LocalidadLomasDeZamora.IngenieroBudge },
                { 526, LocalidadLomasDeZamora.VillaAlbertina },
                { 527, LocalidadLomasDeZamora.SanJose },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lujan).Value.Key, new Dictionary<long, string>
            {
                { 528, LocalidadLujan.CarlosKeen },
                { 529, LocalidadLujan.Cortines },
                { 530, LocalidadLujan.JoseMariaJauregui },
                { 531, LocalidadLujan.Lujan },
                { 532, LocalidadLujan.Olivera },
                { 533, LocalidadLujan.OpenDoor },
                { 534, LocalidadLujan.Torres },
                { 535, LocalidadLujan.LezicaYTorrezuri },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Magdalena).Value.Key, new Dictionary<long, string>
            {
                { 536, LocalidadMagdalena.Magdalena },
                { 537, LocalidadMagdalena.GeneralMansilla },
                { 538, LocalidadMagdalena.Atalaya },
                { 539, LocalidadMagdalena.Vieytes },
                { 540, LocalidadMagdalena.RobertoJPayro },
                { 541, LocalidadMagdalena.LosNaranjos },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Maipu).Value.Key, new Dictionary<long, string>
            {
                { 542, LocalidadMaipu.Maipu },
                { 543, LocalidadMaipu.LasArmas },
                { 544, LocalidadMaipu.SantoDomingo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MalvinasArgentinas).Value.Key, new Dictionary<long, string>
            {
                { 545, LocalidadMalvinasArgentinas.AreaDePromocionElTriangulo },
                { 546, LocalidadMalvinasArgentinas.GrandBourg },
                { 547, LocalidadMalvinasArgentinas.IngenieroAdolfoSourdeaux },
                { 548, LocalidadMalvinasArgentinas.IngenieroPabloNogues },
                { 549, LocalidadMalvinasArgentinas.LosPolvorines },
                { 550, LocalidadMalvinasArgentinas.Tortuguitas },
                { 551, LocalidadMalvinasArgentinas.VillaDeMayo },
                { 552, LocalidadMalvinasArgentinas.TierrasAltas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MarChiquita).Value.Key, new Dictionary<long, string>
            {
                { 553, LocalidadMarChiquita.CoronelVidal },
                { 554, LocalidadMarChiquita.GeneralPiran },
                { 555, LocalidadMarChiquita.LaArmonia },
                { 556, LocalidadMarChiquita.MarChiquita },
                { 557, LocalidadMarChiquita.MarDeCobo },
                { 558, LocalidadMarChiquita.LaBaliza },
                { 559, LocalidadMarChiquita.LaCaleta },
                { 560, LocalidadMarChiquita.MarDeCobo },
                { 561, LocalidadMarChiquita.SantaClaraDelMar },
                { 562, LocalidadMarChiquita.Atlantida },
                { 563, LocalidadMarChiquita.CametNorte },
                { 564, LocalidadMarChiquita.FrenteMar },
                { 565, LocalidadMarChiquita.PlayaDorada },
                { 566, LocalidadMarChiquita.SantaClaraDelMar },
                { 567, LocalidadMarChiquita.SantaElena },
                { 568, LocalidadMarChiquita.Vivorata },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MarcosPaz).Value.Key, new Dictionary<long, string>
            {
                { 569, LocalidadMarcosPaz.MarcosPaz },
                { 570, LocalidadMarcosPaz.EliasRomero },
                { 571, LocalidadMarcosPaz.SantaRosa },
                { 572, LocalidadMarcosPaz.LisandroDeLaTorre },
                { 573, LocalidadMarcosPaz.SantaMarta },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Mercedes).Value.Key, new Dictionary<long, string>
            {
                { 574, LocalidadMercedes.Agote },
                { 575, LocalidadMercedes.Altamira },
                { 576, LocalidadMercedes.Goldney },
                { 577, LocalidadMercedes.Gowland },
                { 578, LocalidadMercedes.JMGarcia },
                { 579, LocalidadMercedes.LaVerde },
                { 580, LocalidadMercedes.Mercedes },
                { 581, LocalidadMercedes.TomasJofre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Merlo).Value.Key, new Dictionary<long, string>
            {
                { 582, LocalidadMerlo.Merlo },
                { 583, LocalidadMerlo.SanAntonioDePadua },
                { 584, LocalidadMerlo.Libertad },
                { 585, LocalidadMerlo.MarianoAcosta },
                { 586, LocalidadMerlo.ParqueSanMartin },
                { 587, LocalidadMerlo.Pontevedra },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Monte).Value.Key, new Dictionary<long, string>
            {
                { 588, LocalidadMonte.SanMiguelDelMonte },
                { 589, LocalidadMonte.Abbott },
                { 590, LocalidadMonte.ZenonVidelaDorna },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MonteHermoso).Value.Key, new Dictionary<long, string>
            {
                { 591, LocalidadMonteHermoso.MonteHermoso },
                { 592, LocalidadMonteHermoso.BalnearioSauceGrande },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Moreno).Value.Key, new Dictionary<long, string>
            {
                { 593, LocalidadMoreno.Moreno },
                { 594, LocalidadMoreno.LaReja },
                { 595, LocalidadMoreno.FranciscoAlvarez },
                { 596, LocalidadMoreno.CuartelV },
                { 597, LocalidadMoreno.Trujui },
                { 598, LocalidadMoreno.PasoDelRey },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Moron).Value.Key, new Dictionary<long, string>
            {
                { 599, LocalidadMoron.Moron },
                { 600, LocalidadMoron.Castelar },
                { 601, LocalidadMoron.ElPalomar },
                { 602, LocalidadMoron.Haedo },
                { 603, LocalidadMoron.VillaSarmiento },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Navarro).Value.Key, new Dictionary<long, string>
            {
                { 604, LocalidadNavarro.Navarro },
                { 605, LocalidadNavarro.VillaMoll },
                { 606, LocalidadNavarro.LasMarianas },
                { 607, LocalidadNavarro.JoseJuanAlmeyra },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Necochea).Value.Key, new Dictionary<long, string>
            {
                { 608, LocalidadNecochea.Necochea },
                { 609, LocalidadNecochea.Quequen },
                { 610, LocalidadNecochea.JuanNepomucenoFernandez },
                { 611, LocalidadNecochea.LaDulce },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.NueveDeJulio).Value.Key, new Dictionary<long, string>
            {
                { 612, LocalidadNueveDeJulio.NueveDeJulio },
                { 613, LocalidadNueveDeJulio.Dudignac },
                { 614, LocalidadNueveDeJulio.AlfredoDemarchi },
                { 615, LocalidadNueveDeJulio.ManuelBGonnet },
                { 616, LocalidadNueveDeJulio.Patricios },
                { 617, LocalidadNueveDeJulio.LaAurora },
                { 618, LocalidadNueveDeJulio.CarlosMariaNaon },
                { 619, LocalidadNueveDeJulio.VillaGeneralFournier },
                { 620, LocalidadNueveDeJulio.Morea },
                { 621, LocalidadNueveDeJulio.DoceDeOctubre },
                { 622, LocalidadNueveDeJulio.MarcelinoUgarte },
                { 623, LocalidadNueveDeJulio.Norumbega },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Olavarria).Value.Key, new Dictionary<long, string>
            {
                { 624, LocalidadOlavarria.SierrasBayas },
                { 625, LocalidadOlavarria.LomaNegra },
                { 626, LocalidadOlavarria.SierraChica },
                { 627, LocalidadOlavarria.Hinojo },
                { 628, LocalidadOlavarria.ColoniaHinojo },
                { 629, LocalidadOlavarria.ColoniaSanMiguel },
                { 630, LocalidadOlavarria.Espigas },
                { 631, LocalidadOlavarria.Recalde },
                { 632, LocalidadOlavarria.VillaLaSerrania },
                { 633, LocalidadOlavarria.SantaLuisa },
                { 634, LocalidadOlavarria.BlancaGrande },
                { 635, LocalidadOlavarria.ColoniaNievas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Patagones).Value.Key, new Dictionary<long, string>
            {
                { 636, LocalidadPatagones.CarmenDePatagones },
                { 637, LocalidadPatagones.Villalonga },
                { 638, LocalidadPatagones.Stroeder },
                { 639, LocalidadPatagones.BahiaSanBlas },
                { 640, LocalidadPatagones.JuanAPradere },
                { 641, LocalidadPatagones.CardenalCagliero },
                { 642, LocalidadPatagones.JoseBCasas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pehuajo).Value.Key, new Dictionary<long, string>
            {
                { 643, LocalidadPehuajo.Pehuajo },
                { 644, LocalidadPehuajo.JuanJosePaso },
                { 645, LocalidadPehuajo.MonesCazon },
                { 646, LocalidadPehuajo.FranciscoMadero },
                { 647, LocalidadPehuajo.SanBernardoDePehuajo },
                { 648, LocalidadPehuajo.Magdala },
                { 649, LocalidadPehuajo.NuevaPlata },
                { 650, LocalidadPehuajo.Chiclana },
                { 651, LocalidadPehuajo.CapitanCastro },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pellegrini).Value.Key, new Dictionary<long, string>
            {
                { 652, LocalidadPellegrini.Pellegrini },
                { 653, LocalidadPellegrini.Bocayuva },
                { 654, LocalidadPellegrini.DeBary },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pergamino).Value.Key, new Dictionary<long, string>
            {
                { 655, LocalidadPergamino.Pergamino },
                { 656, LocalidadPergamino.Acevedo },
                { 657, LocalidadPergamino.ManuelOcampo },
                { 658, LocalidadPergamino.VillaAngelica },
                { 659, LocalidadPergamino.JuanAnchorena },
                { 660, LocalidadPergamino.LaVioleta },
                { 661, LocalidadPergamino.MarianoHAlfonzo },
                { 662, LocalidadPergamino.Guerrico },
                { 663, LocalidadPergamino.Rancagua },
                { 664, LocalidadPergamino.Pinzon },
                { 665, LocalidadPergamino.Fontezuela },
                { 666, LocalidadPergamino.JADeLaPena },
                { 667, LocalidadPergamino.MarianoBenitez },
                { 668, LocalidadPergamino.VillaSanJose },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pila).Value.Key, new Dictionary<long, string>
            {
                { 669, LocalidadPila.Pila },
                { 670, LocalidadPila.Casalins },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pilar).Value.Key, new Dictionary<long, string>
            {
                { 671, LocalidadPilar.DelViso },
                { 672, LocalidadPilar.Fatima },
                { 673, LocalidadPilar.LaLonja },
                { 674, LocalidadPilar.Manzanares },
                { 675, LocalidadPilar.DelPilar },
                { 676, LocalidadPilar.PilarSur },
                { 677, LocalidadPilar.Champagnat },
                { 678, LocalidadPilar.SanFrancisco },
                { 679, LocalidadPilar.PresidenteDerqui },
                { 680, LocalidadPilar.VillaAstolfi },
                { 681, LocalidadPilar.Manzone },
                { 682, LocalidadPilar.ManuelAlberti },
                { 683, LocalidadPilar.Lagomarsino },
                { 684, LocalidadPilar.VillaRosa },
                { 685, LocalidadPilar.Zelaya },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pinamar).Value.Key, new Dictionary<long, string>
            {
                { 686, LocalidadPinamar.Montecarlo },
                { 687, LocalidadPinamar.Pinamar },
                { 688, LocalidadPinamar.MarDeOstende },
                { 689, LocalidadPinamar.Ostende },
                { 690, LocalidadPinamar.ValeriaDelMar },
                { 691, LocalidadPinamar.Carilo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.PresidentePeron).Value.Key, new Dictionary<long, string>
            {
                { 692, LocalidadPresidentePeron.Guernica },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Puan).Value.Key, new Dictionary<long, string>
            {
                { 693, LocalidadPuan.Azopardo },
                { 694, LocalidadPuan.Bordenave },
                { 695, LocalidadPuan.Darregueira },
                { 696, LocalidadPuan.Estela },
                { 697, LocalidadPuan.FelipeSola },
                { 698, LocalidadPuan.LopezLecube },
                { 699, LocalidadPuan.Puan },
                { 700, LocalidadPuan.SanGerman },
                { 701, LocalidadPuan.TresCuervos },
                { 702, LocalidadPuan.Viboras },
                { 703, LocalidadPuan.VillaCastelar },
                { 704, LocalidadPuan.VillaDurcudoy },
                { 705, LocalidadPuan.VillaIris },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.PuntaIndio).Value.Key, new Dictionary<long, string>
            {
                { 706, LocalidadPuntaIndio.Veronica },
                { 707, LocalidadPuntaIndio.Pipinas },
                { 708, LocalidadPuntaIndio.PuntaDelIndio },
                { 709, LocalidadPuntaIndio.AlvarezJonte },
                { 710, LocalidadPuntaIndio.LasTahonas },
                { 711, LocalidadPuntaIndio.MonteVeloz },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Quilmes).Value.Key, new Dictionary<long, string>
            {
                { 712, LocalidadQuilmes.BernalEste },
                { 713, LocalidadQuilmes.BernalOeste },
                { 714, LocalidadQuilmes.DonBosco },
                { 715, LocalidadQuilmes.Ezpeleta },
                { 716, LocalidadQuilmes.EzpeletaOeste },
                { 717, LocalidadQuilmes.Quilmes },
                { 718, LocalidadQuilmes.QuilmesOeste },
                { 719, LocalidadQuilmes.SanFranciscoSolano },
                { 720, LocalidadQuilmes.VillaLaFlorida },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ramallo).Value.Key, new Dictionary<long, string>
            {
                { 721, LocalidadRamallo.Ramallo },
                { 722, LocalidadRamallo.ElParaiso },
                { 723, LocalidadRamallo.PerezMillan },
                { 724, LocalidadRamallo.VillaRamallo },
                { 725, LocalidadRamallo.VillaGeneralSavio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Rauch).Value.Key, new Dictionary<long, string>
            {
                { 726, LocalidadRauch.Rauch },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Rivadavia).Value.Key, new Dictionary<long, string>
            {
                { 727, LocalidadRivadavia.America },
                { 728, LocalidadRivadavia.GonzalezMoreno },
                { 729, LocalidadRivadavia.FortinOlavarria },
                { 730, LocalidadRivadavia.Sansinena },
                { 731, LocalidadRivadavia.Roosevelt },
                { 732, LocalidadRivadavia.Sundblad },
                { 733, LocalidadRivadavia.MiraPampa },
                { 734, LocalidadRivadavia.SanMauricio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Rojas).Value.Key, new Dictionary<long, string>
            {
                { 735, LocalidadRojas.Rojas },
                { 736, LocalidadRojas.LasCarabelas },
                { 737, LocalidadRojas.RafaelObligado },
                { 738, LocalidadRojas.LosIndios },
                { 739, LocalidadRojas.VillaManuelPomar },
                { 740, LocalidadRojas.LaBeba },
                { 741, LocalidadRojas.VillaParqueCecir },
                { 742, LocalidadRojas.RobertoCano },
                { 743, LocalidadRojas.SolDeMayo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.RoquePerez).Value.Key, new Dictionary<long, string>
            {
                { 744, LocalidadRoquePerez.RoquePerez },
                { 745, LocalidadRoquePerez.CarlosBeguerie },
                { 746, LocalidadRoquePerez.SantiagoLarre },
                { 747, LocalidadRoquePerez.LaReforma },
                { 748, LocalidadRoquePerez.JuanTronconi },
                { 749, LocalidadRoquePerez.LaPaz },
                { 750, LocalidadRoquePerez.LaPazChica },
                { 751, LocalidadRoquePerez.Atucha },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Saavedra).Value.Key, new Dictionary<long, string>
            {
                { 752, LocalidadSaavedra.Pigue },
                { 753, LocalidadSaavedra.Saavedra },
                { 754, LocalidadSaavedra.Espartillar },
                { 755, LocalidadSaavedra.Goyena },
                { 756, LocalidadSaavedra.ArroyoCorto },
                { 757, LocalidadSaavedra.Dufaur },
                { 758, LocalidadSaavedra.ColoniaSanMartin },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Saladillo).Value.Key, new Dictionary<long, string>
            {
                { 759, LocalidadSaladillo.Saladillo },
                { 760, LocalidadSaladillo.DelCarril },
                { 761, LocalidadSaladillo.Polvaredas },
                { 762, LocalidadSaladillo.Cazon },
                { 763, LocalidadSaladillo.AlvarezDeToledo },
                { 764, LocalidadSaladillo.JuanJoseBlaquier },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Salliquelo).Value.Key, new Dictionary<long, string>
            {
                { 765, LocalidadSalliquelo.Salliquelo },
                { 766, LocalidadSalliquelo.Quenuma },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Salto).Value.Key, new Dictionary<long, string>
            {
                { 767, LocalidadSalto.Salto },
                { 768, LocalidadSalto.ArroyoDulce },
                { 769, LocalidadSalto.InesIndart },
                { 770, LocalidadSalto.Gahan },
                { 771, LocalidadSalto.Berdier },
                { 772, LocalidadSalto.LaInvencible },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanAndresDeGiles).Value.Key, new Dictionary<long, string>
            {
                { 773, LocalidadSanAndresDeGiles.SanAndresDeGiles },
                { 774, LocalidadSanAndresDeGiles.Solis },
                { 775, LocalidadSanAndresDeGiles.VillaRuiz },
                { 776, LocalidadSanAndresDeGiles.Cucullu },
                { 777, LocalidadSanAndresDeGiles.Azcuenaga },
                { 778, LocalidadSanAndresDeGiles.VillaEspil },
                { 779, LocalidadSanAndresDeGiles.Franklin },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanAntonioDeAreco).Value.Key, new Dictionary<long, string>
            {
                { 780, LocalidadSanAntonioDeAreco.SanAntonioDeAreco },
                { 781, LocalidadSanAntonioDeAreco.VillaLia },
                { 782, LocalidadSanAntonioDeAreco.Duggan },
                { 783, LocalidadSanAntonioDeAreco.Vagues },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanCayetano).Value.Key, new Dictionary<long, string>
            {
                { 784, LocalidadSanCayetano.SanCayetano },
                { 785, LocalidadSanCayetano.Ochandio },
                { 786, LocalidadSanCayetano.BalnearioSanCayetano },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanFernando).Value.Key, new Dictionary<long, string>
            {
                { 787, LocalidadSanFernando.SanFernando },
                { 788, LocalidadSanFernando.Victoria },
                { 789, LocalidadSanFernando.Virreyes },
                { 790, LocalidadSanFernando.Islas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanIsidro).Value.Key, new Dictionary<long, string>
            {
                { 791, LocalidadSanIsidro.VillaAdelina },
                { 792, LocalidadSanIsidro.BoulogneSurMer },
                { 793, LocalidadSanIsidro.Martinez },
                { 794, LocalidadSanIsidro.Acassuso },
                { 795, LocalidadSanIsidro.SanIsidro },
                { 796, LocalidadSanIsidro.Beccar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanMiguel).Value.Key, new Dictionary<long, string>
            {
                { 797, LocalidadSanMiguel.SanMiguel },
                { 798, LocalidadSanMiguel.BellaVista },
                { 799, LocalidadSanMiguel.CampoDeMayo },
                { 800, LocalidadSanMiguel.Muniz },
                { 801, LocalidadSanMiguel.SantaMaria },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanNicolas).Value.Key, new Dictionary<long, string>
            {
                { 802, LocalidadSanNicolas.CamposSalles },
                { 803, LocalidadSanNicolas.Conesa },
                { 804, LocalidadSanNicolas.Erezcano },
                { 805, LocalidadSanNicolas.GeneralRojo },
                { 806, LocalidadSanNicolas.LaEmilia },
                { 807, LocalidadSanNicolas.SanNicolasDeLosArroyos },
                { 808, LocalidadSanNicolas.VillaCampi },
                { 809, LocalidadSanNicolas.VillaCanto },
                { 810, LocalidadSanNicolas.VillaEsperanza },
                { 811, LocalidadSanNicolas.VillaHermosa },
                { 812, LocalidadSanNicolas.VillaRiccio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanPedro).Value.Key, new Dictionary<long, string>
            {
                { 813, LocalidadSanPedro.SanPedro },
                { 814, LocalidadSanPedro.GobernadorCastro },
                { 815, LocalidadSanPedro.SantaLucia },
                { 816, LocalidadSanPedro.RioTala },
                { 817, LocalidadSanPedro.PuebloDoyle },
                { 818, LocalidadSanPedro.Obligado },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanVicente).Value.Key, new Dictionary<long, string>
            {
                { 819, LocalidadSanVicente.SanVicente },
                { 820, LocalidadSanVicente.AlejandroKorn },
                { 821, LocalidadSanVicente.Domselaar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Suipacha).Value.Key, new Dictionary<long, string>
            {
                { 822, LocalidadSuipacha.Suipacha },
                { 823, LocalidadSuipacha.GeneralRivas },
                { 824, LocalidadSuipacha.RomanBaez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tandil).Value.Key, new Dictionary<long, string>
            {
                { 825, LocalidadTandil.Tandil },
                { 826, LocalidadTandil.MariaIgnacia },
                { 827, LocalidadTandil.Gardey },
                { 828, LocalidadTandil.DeLaCanal },
                { 829, LocalidadTandil.DesvioAguirre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tapalque).Value.Key, new Dictionary<long, string>
            {
                { 830, LocalidadTapalque.Tapalque },
                { 831, LocalidadTapalque.Altona },
                { 832, LocalidadTapalque.Crotto },
                { 833, LocalidadTapalque.EufemioUballes },
                { 834, LocalidadTapalque.Yerbas },
                { 835, LocalidadTapalque.SanBernardo },
                { 836, LocalidadTapalque.Covello },
                { 837, LocalidadTapalque.Velloso },
                { 838, LocalidadTapalque.LaPaloma },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tigre).Value.Key, new Dictionary<long, string>
            {
                { 839, LocalidadTigre.Tigre },
                { 840, LocalidadTigre.DonTorcuato },
                { 841, LocalidadTigre.GeneralPacheco },
                { 842, LocalidadTigre.ElTalar },
                { 843, LocalidadTigre.TroncosDelTalar },
                { 844, LocalidadTigre.Benavidez },
                { 845, LocalidadTigre.DiqueLujan },
                { 846, LocalidadTigre.RicardoRojas },
                { 847, LocalidadTigre.RinconDeMilberg },
                { 848, LocalidadTigre.Nordelta },
                { 849, LocalidadTigre.DeltaDelTigre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tordillo).Value.Key, new Dictionary<long, string>
            {
                { 850, LocalidadTordillo.GeneralConesa },
                { 851, LocalidadTordillo.VillaRoch },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tornquist).Value.Key, new Dictionary<long, string>
            {
                { 852, LocalidadTornquist.Tornquist },
                { 853, LocalidadTornquist.SierraDeLaVentana },
                { 854, LocalidadTornquist.Saldungaray },
                { 855, LocalidadTornquist.VillaVentana },
                { 856, LocalidadTornquist.Chasico },
                { 857, LocalidadTornquist.TresPicos },
                { 858, LocalidadTornquist.VillaSerranaLaGruta },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TrenqueLauquen).Value.Key, new Dictionary<long, string>
            {
                { 859, LocalidadTrenqueLauquen.TrenqueLauquen },
                { 860, LocalidadTrenqueLauquen.TreintaDeAgosto },
                { 861, LocalidadTrenqueLauquen.Beruti },
                { 862, LocalidadTrenqueLauquen.Girodias },
                { 863, LocalidadTrenqueLauquen.LaCarreta },
                { 864, LocalidadTrenqueLauquen.Garre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TresArroyos).Value.Key, new Dictionary<long, string>
            {
                { 865, LocalidadTresArroyos.TresArroyos },
                { 866, LocalidadTresArroyos.Claromeco },
                { 867, LocalidadTresArroyos.Orense },
                { 868, LocalidadTresArroyos.Copetonas },
                { 869, LocalidadTresArroyos.MicaelaCascallares },
                { 870, LocalidadTresArroyos.SanFranciscoDeBellocq },
                { 871, LocalidadTresArroyos.Reta },
                { 872, LocalidadTresArroyos.BalnearioOrense },
                { 873, LocalidadTresArroyos.SanMayol },
                { 874, LocalidadTresArroyos.LinCalel },
                { 875, LocalidadTresArroyos.Barrow },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TresDeFebrero).Value.Key, new Dictionary<long, string>
            {
                { 876, LocalidadTresDeFebrero.Caseros },
                { 877, LocalidadTresDeFebrero.Churruca },
                { 878, LocalidadTresDeFebrero.CiudadJardinLomasDelPalomar },
                { 879, LocalidadTresDeFebrero.Ciudadela },
                { 880, LocalidadTresDeFebrero.ElLibertador },
                { 881, LocalidadTresDeFebrero.JoseIngenieros },
                { 882, LocalidadTresDeFebrero.LomaHermosa },
                { 883, LocalidadTresDeFebrero.MartinCoronado },
                { 884, LocalidadTresDeFebrero.OnceDeSeptiembre },
                { 885, LocalidadTresDeFebrero.PabloPodesta },
                { 886, LocalidadTresDeFebrero.RemediosDeEscalada },
                { 887, LocalidadTresDeFebrero.SaenzPena },
                { 888, LocalidadTresDeFebrero.SantosLugares },
                { 889, LocalidadTresDeFebrero.VillaBosch },
                { 890, LocalidadTresDeFebrero.VillaRaffo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TresLomas).Value.Key, new Dictionary<long, string>
            {
                { 891, LocalidadTresLomas.TresLomas },
                { 892, LocalidadTresLomas.IngenieroThompson },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.VeinticincoDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 893, LocalidadVeinticincoDeMayo.25DeMayo },
                { 894, LocalidadVeinticincoDeMayo.NorbertoDeLaRiestra },
                { 895, LocalidadVeinticincoDeMayo.Pedernales },
                { 896, LocalidadVeinticincoDeMayo.DelValle },
                { 897, LocalidadVeinticincoDeMayo.GobernadorUgarte },
                { 898, LocalidadVeinticincoDeMayo.Valdes },
                { 899, LocalidadVeinticincoDeMayo.SanEnrique },
                { 900, LocalidadVeinticincoDeMayo.AgustinMosconi },
                { 901, LocalidadVeinticincoDeMayo.Ernestina },
                { 902, LocalidadVeinticincoDeMayo.LucasMonteverde },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.VicenteLopez).Value.Key, new Dictionary<long, string>
            {
                { 903, LocalidadVicenteLopez.VicenteLopez },
                { 904, LocalidadVicenteLopez.Olivos },
                { 905, LocalidadVicenteLopez.Florida },
                { 906, LocalidadVicenteLopez.LaLucila },
                { 907, LocalidadVicenteLopez.VillaMartelli },
                { 908, LocalidadVicenteLopez.FloridaOeste },
                { 909, LocalidadVicenteLopez.Munro },
                { 910, LocalidadVicenteLopez.Carapachay },
                { 911, LocalidadVicenteLopez.VillaAdelina },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.VillaGesell).Value.Key, new Dictionary<long, string>
            {
                { 912, LocalidadVillaGesell.LasGaviotas },
                { 913, LocalidadVillaGesell.MarAzul },
                { 914, LocalidadVillaGesell.MarDeLasPampas },
                { 915, LocalidadVillaGesell.VillaGesell },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Villarino).Value.Key, new Dictionary<long, string>
            {
                { 916, LocalidadVillarino.PedroLuro },
                { 917, LocalidadVillarino.MayorBuratovich },
                { 918, LocalidadVillarino.Medanos },
                { 919, LocalidadVillarino.JuanCouste },
                { 920, LocalidadVillarino.HilarioAscasubi },
                { 921, LocalidadVillarino.TenienteOrigone },
                { 922, LocalidadVillarino.ColoniaSanAdolfo },
                { 923, LocalidadVillarino.Argerich },
                { 924, LocalidadVillarino.LagunaChasico },
                { 925, LocalidadVillarino.BalnearioLaChiquita },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Zarate).Value.Key, new Dictionary<long, string>
            {
                { 926, LocalidadZarate.Zarate },
                { 927, LocalidadZarate.Lima },
                { 928, LocalidadZarate.BarrioSaavedra },
                { 929, LocalidadZarate.CountryClubElCasco },
                { 930, LocalidadZarate.Escalada },
                { 931, LocalidadZarate.ParajeOrtiz },
            });
        }
    }
}
