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
                { 1, LocalidadBuenosAires.Carhue },
                { 2, LocalidadBuenosAires.Rivera },
                { 3, LocalidadBuenosAires.VillaMaza },
                { 4, LocalidadBuenosAires.SanMiguelArcangel },
                { 5, LocalidadBuenosAires.EstebanAgustinGascon },
                { 6, LocalidadBuenosAires.DelfinHuergo },
                { 7, LocalidadBuenosAires.LaPala },
                { 8, LocalidadBuenosAires.Thames },
                { 9, LocalidadBuenosAires.Yutuyaco },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AdolfoGonzalesChaves).Value.Key, new Dictionary<long, string>
            {
                { 10, LocalidadBuenosAires.GonzalesChaves },
                { 11, LocalidadBuenosAires.DeLaGarma },
                { 12, LocalidadBuenosAires.JuanEulogioBarra },
                { 13, LocalidadBuenosAires.Vasquez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Alberti).Value.Key, new Dictionary<long, string>
            {
                { 14, LocalidadBuenosAires.Alberti },
                { 15, LocalidadBuenosAires.Mechita },
                { 16, LocalidadBuenosAires.VillaOrtiz },
                { 17, LocalidadBuenosAires.Pla },
                { 18, LocalidadBuenosAires.CoronelSegui },
                { 19, LocalidadBuenosAires.VillaGrisolia },
                { 20, LocalidadBuenosAires.VillaMaria },
                { 21, LocalidadBuenosAires.GobernadorUgarte },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.AlmiranteBrown).Value.Key, new Dictionary<long, string>
            {
                { 22, LocalidadBuenosAires.Adrogue },
                { 23, LocalidadBuenosAires.Burzaco },
                { 24, LocalidadBuenosAires.Glew },
                { 25, LocalidadBuenosAires.Claypole },
                { 26, LocalidadBuenosAires.RafaelCalzada },
                { 27, LocalidadBuenosAires.Longchamps },
                { 28, LocalidadBuenosAires.JoseMarmol },
                { 29, LocalidadBuenosAires.MinistroRivadavia },
                { 30, LocalidadBuenosAires.MalvinasArgentinas },
                { 31, LocalidadBuenosAires.SanFranciscoDeAsis },
                { 32, LocalidadBuenosAires.SanJose },
                { 33, LocalidadBuenosAires.SanFranciscoSolano },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Arrecifes).Value.Key, new Dictionary<long, string>
            {
                { 34, LocalidadBuenosAires.Arrecifes },
                { 35, LocalidadBuenosAires.Todd },
                { 36, LocalidadBuenosAires.Vina },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Avellaneda).Value.Key, new Dictionary<long, string>
            {
                { 37, LocalidadBuenosAires.AvellanedaCentro },
                { 38, LocalidadBuenosAires.DockSud },
                { 39, LocalidadBuenosAires.Gerli },
                { 40, LocalidadBuenosAires.Pineyro },
                { 41, LocalidadBuenosAires.Sarandi },
                { 42, LocalidadBuenosAires.VillaDominico },
                { 43, LocalidadBuenosAires.Wilde },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ayacucho).Value.Key, new Dictionary<long, string>
            {
                { 44, LocalidadBuenosAires.Ayacucho },
                { 45, LocalidadBuenosAires.Udaquiola },
                { 46, LocalidadBuenosAires.LaConstancia },
                { 47, LocalidadBuenosAires.Solanet },
                { 48, LocalidadBuenosAires.ParajeCangallo },
                { 49, LocalidadBuenosAires.ParajeLangueyu },
                { 50, LocalidadBuenosAires.ParajeFair },
                { 51, LocalidadBuenosAires.ParajeSanIgnacio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Azul).Value.Key, new Dictionary<long, string>
            {
                { 52, LocalidadBuenosAires.Azul },
                { 53, LocalidadBuenosAires.Chillar },
                { 54, LocalidadBuenosAires.Cachari },
                { 55, LocalidadBuenosAires.DieciseisDeJulio },
                { 56, LocalidadBuenosAires.Ariel },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.BahiaBlanca).Value.Key, new Dictionary<long, string>
            {
                { 57, LocalidadBuenosAires.BahiaBlanca },
                { 58, LocalidadBuenosAires.IngenieroWhite },
                { 59, LocalidadBuenosAires.GeneralDanielCerri },
                { 60, LocalidadBuenosAires.Grunbein },
                { 61, LocalidadBuenosAires.Cabildo },
                { 62, LocalidadBuenosAires.VillaEspora },
                { 63, LocalidadBuenosAires.VillaBordeu },
                { 64, LocalidadBuenosAires.LaViticola },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Balcarce).Value.Key, new Dictionary<long, string>
            {
                { 65, LocalidadBuenosAires.Balcarce },
                { 66, LocalidadBuenosAires.SanAgustin },
                { 67, LocalidadBuenosAires.Napaleofu },
                { 68, LocalidadBuenosAires.LosPinos },
                { 69, LocalidadBuenosAires.VillaLagunaLaBrava },
                { 70, LocalidadBuenosAires.RamosOtero },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Baradero).Value.Key, new Dictionary<long, string>
            {
                { 71, LocalidadBuenosAires.Baradero },
                { 72, LocalidadBuenosAires.VillaAlsina },
                { 73, LocalidadBuenosAires.IreneoPortela },
                { 74, LocalidadBuenosAires.SantaColoma },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.BenitoJuarez).Value.Key, new Dictionary<long, string>
            {
                { 75, LocalidadBuenosAires.BenitoJuarez },
                { 76, LocalidadBuenosAires.VillaCacique },
                { 77, LocalidadBuenosAires.Barker },
                { 78, LocalidadBuenosAires.EstacionLopez },
                { 79, LocalidadBuenosAires.TedinUriburu },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Berazategui).Value.Key, new Dictionary<long, string>
            {
                { 80, LocalidadBuenosAires.Berazategui },
                { 81, LocalidadBuenosAires.Hudson },
                { 82, LocalidadBuenosAires.JuanMariaGutierrez },
                { 83, LocalidadBuenosAires.Ranelagh },
                { 84, LocalidadBuenosAires.Sourigues },
                { 85, LocalidadBuenosAires.Pereyra },
                { 86, LocalidadBuenosAires.Platanos },
                { 87, LocalidadBuenosAires.VillaEspana },
                { 88, LocalidadBuenosAires.ElPato },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Berisso).Value.Key, new Dictionary<long, string>
            {
                { 89, LocalidadBuenosAires.Berisso },
                { 90, LocalidadBuenosAires.VillaProgreso },
                { 91, LocalidadBuenosAires.VillaSanCarlos },
                { 92, LocalidadBuenosAires.VillaIndependencia },
                { 93, LocalidadBuenosAires.BarrioElCarmenEste },
                { 94, LocalidadBuenosAires.VillaDolores },
                { 95, LocalidadBuenosAires.VillaArguello },
                { 96, LocalidadBuenosAires.VillaZula },
                { 97, LocalidadBuenosAires.BarrioBancoProvincia },
                { 98, LocalidadBuenosAires.VillaNueva },
                { 99, LocalidadBuenosAires.BarrioUniversitario },
                { 100, LocalidadBuenosAires.LosTalas },
                { 101, LocalidadBuenosAires.PaloBlanco },
                { 102, LocalidadBuenosAires.VillaBancoConstructor },
                { 103, LocalidadBuenosAires.LosCatorce },
                { 104, LocalidadBuenosAires.VillaEspana },
                { 105, LocalidadBuenosAires.LaBalandra },
                { 106, LocalidadBuenosAires.JuanBJusto },
                { 107, LocalidadBuenosAires.BarrioObrero },
                { 108, LocalidadBuenosAires.BarrioSantaTeresita },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Bolivar).Value.Key, new Dictionary<long, string>
            {
                { 109, LocalidadBuenosAires.SanCarlosDeBolivar },
                { 110, LocalidadBuenosAires.Urdampilleta },
                { 111, LocalidadBuenosAires.Pirovano },
                { 112, LocalidadBuenosAires.Hale },
                { 113, LocalidadBuenosAires.JuanFIbarra },
                { 114, LocalidadBuenosAires.Paula },
                { 115, LocalidadBuenosAires.MarianoUnzue },
                { 116, LocalidadBuenosAires.VillaLynchPueyrredon },
                { 117, LocalidadBuenosAires.ParajeVallimanca },
                { 118, LocalidadBuenosAires.ParajeVillaSanz },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Bragado).Value.Key, new Dictionary<long, string>
            {
                { 119, LocalidadBuenosAires.Bragado },
                { 120, LocalidadBuenosAires.EduardoObrien },
                { 121, LocalidadBuenosAires.Mechita },
                { 122, LocalidadBuenosAires.ComodoroPy },
                { 123, LocalidadBuenosAires.Warnes },
                { 124, LocalidadBuenosAires.Irala },
                { 125, LocalidadBuenosAires.Olascoaga },
                { 126, LocalidadBuenosAires.MaximoFernandez },
                { 127, LocalidadBuenosAires.LaLimpia },
                { 128, LocalidadBuenosAires.Asamblea },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Brandsen).Value.Key, new Dictionary<long, string>
            {
                { 129, LocalidadBuenosAires.Brandsen },
                { 130, LocalidadBuenosAires.Jeppener },
                { 131, LocalidadBuenosAires.Gomez },
                { 132, LocalidadBuenosAires.Altamirano },
                { 133, LocalidadBuenosAires.Samborombon },
                { 134, LocalidadBuenosAires.Oliden },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Campana).Value.Key, new Dictionary<long, string>
            {
                { 135, LocalidadBuenosAires.Campana },
                { 136, LocalidadBuenosAires.AltoLosCardales },
                { 137, LocalidadBuenosAires.LomasDelRioLujan },
                { 138, LocalidadBuenosAires.IngenieroRomuloOtamendi },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Canuelas).Value.Key, new Dictionary<long, string>
            {
                { 139, LocalidadBuenosAires.Canuelas },
                { 140, LocalidadBuenosAires.SantaRosa },
                { 141, LocalidadBuenosAires.AlejandroPetion },
                { 142, LocalidadBuenosAires.MaximoPaz },
                { 143, LocalidadBuenosAires.Uribelarrea },
                { 144, LocalidadBuenosAires.VicenteCasares },
                { 145, LocalidadBuenosAires.GobernadorUdaondo },
                { 146, LocalidadBuenosAires.ElTaladro },
                { 147, LocalidadBuenosAires.SantaAnita },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CapitanSarmiento).Value.Key, new Dictionary<long, string>
            {
                { 148, LocalidadBuenosAires.CapitanSarmiento },
                { 149, LocalidadBuenosAires.LaLuisa },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CarlosCasares).Value.Key, new Dictionary<long, string>
            {
                { 150, LocalidadBuenosAires.CarlosCasares },
                { 151, LocalidadBuenosAires.Smith },
                { 152, LocalidadBuenosAires.Bellocq },
                { 153, LocalidadBuenosAires.Moctezuma },
                { 154, LocalidadBuenosAires.Cadret },
                { 155, LocalidadBuenosAires.Hortensia },
                { 156, LocalidadBuenosAires.Ordoqui },
                { 157, LocalidadBuenosAires.MauricioHirsch },
                { 158, LocalidadBuenosAires.ColoniaMauricio },
                { 159, LocalidadBuenosAires.LaSofia },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CarlosTejedor).Value.Key, new Dictionary<long, string>
            {
                { 160, LocalidadBuenosAires.CarlosTejedor },
                { 161, LocalidadBuenosAires.TresAlgarrobos },
                { 162, LocalidadBuenosAires.ColoniaSere },
                { 163, LocalidadBuenosAires.Timote },
                { 164, LocalidadBuenosAires.Curaru },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CarmenDeAreco).Value.Key, new Dictionary<long, string>
            {
                { 165, LocalidadBuenosAires.CarmenDeAreco },
                { 166, LocalidadBuenosAires.TresSargentos },
                { 167, LocalidadBuenosAires.PuebloGouin },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Castelli).Value.Key, new Dictionary<long, string>
            {
                { 168, LocalidadBuenosAires.Castelli },
                { 169, LocalidadBuenosAires.CentroGuerrero },
                { 170, LocalidadBuenosAires.CerroDeLaGloria },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Chacabuco).Value.Key, new Dictionary<long, string>
            {
                { 171, LocalidadBuenosAires.Chacabuco },
                { 172, LocalidadBuenosAires.Rawson },
                { 173, LocalidadBuenosAires.Ohiggins },
                { 174, LocalidadBuenosAires.Castilla },
                { 175, LocalidadBuenosAires.LosAngeles },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Chascomus).Value.Key, new Dictionary<long, string>
            {
                { 176, LocalidadBuenosAires.Chascomus },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Chivilcoy).Value.Key, new Dictionary<long, string>
            {
                { 177, LocalidadBuenosAires.Chivilcoy },
                { 178, LocalidadBuenosAires.Moquehua },
                { 179, LocalidadBuenosAires.Gorostiaga },
                { 180, LocalidadBuenosAires.EmilioAyarza },
                { 181, LocalidadBuenosAires.LaRica },
                { 182, LocalidadBuenosAires.SanSebastian },
                { 183, LocalidadBuenosAires.Benitez },
                { 184, LocalidadBuenosAires.HenryBell },
                { 185, LocalidadBuenosAires.Indacochea },
                { 186, LocalidadBuenosAires.PalemonHuergo },
                { 187, LocalidadBuenosAires.RamonBiaus },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Colon).Value.Key, new Dictionary<long, string>
            {
                { 188, LocalidadBuenosAires.Colon },
                { 189, LocalidadBuenosAires.Pearson },
                { 190, LocalidadBuenosAires.Sarasa },
                { 191, LocalidadBuenosAires.ElArbolito },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelDorrego).Value.Key, new Dictionary<long, string>
            {
                { 192, LocalidadBuenosAires.CoronelDorrego },
                { 193, LocalidadBuenosAires.Oriente },
                { 194, LocalidadBuenosAires.ElPerdido },
                { 195, LocalidadBuenosAires.Aparicio },
                { 196, LocalidadBuenosAires.SanRoman },
                { 197, LocalidadBuenosAires.BalnearioMarisol },
                { 198, LocalidadBuenosAires.Irene },
                { 199, LocalidadBuenosAires.Faro },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelPringles).Value.Key, new Dictionary<long, string>
            {
                { 200, LocalidadBuenosAires.CoronelPringles },
                { 201, LocalidadBuenosAires.IndioRico },
                { 202, LocalidadBuenosAires.Lartigau },
                { 203, LocalidadBuenosAires.ElPensamiento },
                { 204, LocalidadBuenosAires.ElDivisorio },
                { 205, LocalidadBuenosAires.Frapal },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelRosales).Value.Key, new Dictionary<long, string>
            {
                { 206, LocalidadBuenosAires.PuntaAlta },
                { 207, LocalidadBuenosAires.VillaGeneralArias },
                { 208, LocalidadBuenosAires.BalnearioPehuen-Co },
                { 209, LocalidadBuenosAires.VillaDelMar },
                { 210, LocalidadBuenosAires.BajoHondo },
                { 211, LocalidadBuenosAires.Calderon },
                { 212, LocalidadBuenosAires.PuertoRosales },
                { 213, LocalidadBuenosAires.BaseNavalPuertoBelgrano },
                { 214, LocalidadBuenosAires.ArroyoPareja },
                { 215, LocalidadBuenosAires.PuntaAncla },
                { 216, LocalidadBuenosAires.BaseDeInfanteriaDeMarinaBaterias },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.CoronelSuarez).Value.Key, new Dictionary<long, string>
            {
                { 217, LocalidadBuenosAires.CoronelSuarez },
                { 218, LocalidadBuenosAires.Huanguelen },
                { 219, LocalidadBuenosAires.SanJose },
                { 220, LocalidadBuenosAires.SantaMaria },
                { 221, LocalidadBuenosAires.SantaTrinidad },
                { 222, LocalidadBuenosAires.VillaArcadia },
                { 223, LocalidadBuenosAires.Pasman },
                { 224, LocalidadBuenosAires.CuraMalal },
                { 225, LocalidadBuenosAires.EstacionPineyro },
                { 226, LocalidadBuenosAires.Dorbigny },
                { 227, LocalidadBuenosAires.Cascada },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Daireaux).Value.Key, new Dictionary<long, string>
            {
                { 228, LocalidadBuenosAires.Daireaux },
                { 229, LocalidadBuenosAires.SalazarMouras },
                { 230, LocalidadBuenosAires.Arboledas },
                { 231, LocalidadBuenosAires.LaCopeta },
                { 232, LocalidadBuenosAires.LaLarga },
                { 233, LocalidadBuenosAires.LaManuela },
                { 234, LocalidadBuenosAires.Luro },
                { 235, LocalidadBuenosAires.Andant },
                { 236, LocalidadBuenosAires.EnriqueLavalleFreyre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Dolores).Value.Key, new Dictionary<long, string>
            {
                { 237, LocalidadBuenosAires.Dolores },
                { 238, LocalidadBuenosAires.Sevigne },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ensenada).Value.Key, new Dictionary<long, string>
            {
                { 239, LocalidadBuenosAires.Ensenada },
                { 240, LocalidadBuenosAires.PuntaLara },
                { 241, LocalidadBuenosAires.VillaCatella },
                { 242, LocalidadBuenosAires.DiqueN1 },
                { 243, LocalidadBuenosAires.IslaSantiagoOeste },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Escobar).Value.Key, new Dictionary<long, string>
            {
                { 244, LocalidadBuenosAires.BelenDeEscobar },
                { 245, LocalidadBuenosAires.Garin },
                { 246, LocalidadBuenosAires.IngenieroMaschwitz },
                { 247, LocalidadBuenosAires.Matheu },
                { 248, LocalidadBuenosAires.MaquinistaFSavio },
                { 249, LocalidadBuenosAires.PuertoParana },
                { 250, LocalidadBuenosAires.LomaVerde },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.EstebanEcheverria).Value.Key, new Dictionary<long, string>
            {
                { 251, LocalidadBuenosAires.NueveDeAbril },
                { 252, LocalidadBuenosAires.CanningOriental },
                { 253, LocalidadBuenosAires.ElJaguel },
                { 254, LocalidadBuenosAires.LuisGuillon },
                { 255, LocalidadBuenosAires.MonteGrande },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.ExaltacionDeLaCruz).Value.Key, new Dictionary<long, string>
            {
                { 256, LocalidadBuenosAires.CapillaDelSenor },
                { 257, LocalidadBuenosAires.LosCardales },
                { 258, LocalidadBuenosAires.Pavon },
                { 259, LocalidadBuenosAires.ArroyoDeLaCruz },
                { 260, LocalidadBuenosAires.ParadaOrlando },
                { 261, LocalidadBuenosAires.ParadaRobles },
                { 262, LocalidadBuenosAires.ElRemanso },
                { 263, LocalidadBuenosAires.Etchegoyen },
                { 264, LocalidadBuenosAires.ParadaLaLata-LaLoma },
                { 265, LocalidadBuenosAires.DiegoGaynor },
                { 266, LocalidadBuenosAires.GobernadorAndonaegui },
                { 267, LocalidadBuenosAires.Chenaut },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ezeiza).Value.Key, new Dictionary<long, string>
            {
                { 268, LocalidadBuenosAires.AeropuertoInternacionalEzeiza },
                { 269, LocalidadBuenosAires.CanningOccidental },
                { 270, LocalidadBuenosAires.CarlosSpegazzini },
                { 271, LocalidadBuenosAires.Ezeiza },
                { 272, LocalidadBuenosAires.LaUnion },
                { 273, LocalidadBuenosAires.TristanSuarez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.FlorencioVarela).Value.Key, new Dictionary<long, string>
            {
                { 274, LocalidadBuenosAires.CiudadDeBosques },
                { 275, LocalidadBuenosAires.CiudadDeFlorencioVarela },
                { 276, LocalidadBuenosAires.EstanislaoSeveroZeballos },
                { 277, LocalidadBuenosAires.GobernadorJulioACosta },
                { 278, LocalidadBuenosAires.IngenieroJuanAllan },
                { 279, LocalidadBuenosAires.LaCapilla },
                { 280, LocalidadBuenosAires.VillaBrown },
                { 281, LocalidadBuenosAires.VillaSanLuis },
                { 282, LocalidadBuenosAires.VillaSantaRosa },
                { 283, LocalidadBuenosAires.VillaVatteone },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.FlorentinoAmeghino).Value.Key, new Dictionary<long, string>
            {
                { 284, LocalidadBuenosAires.FlorentinoAmeghino },
                { 285, LocalidadBuenosAires.Blaquier },
                { 286, LocalidadBuenosAires.Porvenir },
                { 287, LocalidadBuenosAires.ParajeNuevaSuiza },
                { 288, LocalidadBuenosAires.ParajePorvenir },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralAlvarado).Value.Key, new Dictionary<long, string>
            {
                { 289, LocalidadBuenosAires.Miramar },
                { 290, LocalidadBuenosAires.MarDelSur },
                { 291, LocalidadBuenosAires.ComandanteNicanorOtamendi },
                { 292, LocalidadBuenosAires.Mechongue },
                { 293, LocalidadBuenosAires.CentinelaDelMar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralAlvear).Value.Key, new Dictionary<long, string>
            {
                { 294, LocalidadBuenosAires.GeneralAlvear },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralArenales).Value.Key, new Dictionary<long, string>
            {
                { 295, LocalidadBuenosAires.GeneralArenales },
                { 296, LocalidadBuenosAires.Arribenos },
                { 297, LocalidadBuenosAires.Ascension },
                { 298, LocalidadBuenosAires.EstacionArenales },
                { 299, LocalidadBuenosAires.Ferre },
                { 300, LocalidadBuenosAires.LaAngelita },
                { 301, LocalidadBuenosAires.LaTrinidad },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralBelgrano).Value.Key, new Dictionary<long, string>
            {
                { 302, LocalidadBuenosAires.GeneralBelgrano },
                { 303, LocalidadBuenosAires.Gorchs },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralGuido).Value.Key, new Dictionary<long, string>
            {
                { 304, LocalidadBuenosAires.GeneralGuido },
                { 305, LocalidadBuenosAires.Labarden },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralMadariaga).Value.Key, new Dictionary<long, string>
            {
                { 306, LocalidadBuenosAires.GeneralMadariaga },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralLaMadrid).Value.Key, new Dictionary<long, string>
            {
                { 307, LocalidadBuenosAires.GeneralLaMadrid },
                { 308, LocalidadBuenosAires.LaColina },
                { 309, LocalidadBuenosAires.Libano },
                { 310, LocalidadBuenosAires.LasMartinetas },
                { 311, LocalidadBuenosAires.Pontaut },
                { 312, LocalidadBuenosAires.Lastra },
                { 313, LocalidadBuenosAires.Quilco },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralLasHeras).Value.Key, new Dictionary<long, string>
            {
                { 314, LocalidadBuenosAires.GeneralLasHeras },
                { 315, LocalidadBuenosAires.Villars },
                { 316, LocalidadBuenosAires.GeneralHornos },
                { 317, LocalidadBuenosAires.Plomer },
                { 318, LocalidadBuenosAires.LaChoza },
                { 319, LocalidadBuenosAires.Lozano },
                { 320, LocalidadBuenosAires.EnriqueFynn },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralLavalle).Value.Key, new Dictionary<long, string>
            {
                { 321, LocalidadBuenosAires.GeneralLavalle },
                { 322, LocalidadBuenosAires.Pavon },
                { 323, LocalidadBuenosAires.LasChacras },
                { 324, LocalidadBuenosAires.LasTijeras },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralPaz).Value.Key, new Dictionary<long, string>
            {
                { 325, LocalidadBuenosAires.Ranchos },
                { 326, LocalidadBuenosAires.LomaVerde },
                { 327, LocalidadBuenosAires.Villanueva },
                { 328, LocalidadBuenosAires.BarrioRioSalado },
                { 329, LocalidadBuenosAires.Alegre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralPinto).Value.Key, new Dictionary<long, string>
            {
                { 330, LocalidadBuenosAires.GeneralPinto },
                { 331, LocalidadBuenosAires.Germania },
                { 332, LocalidadBuenosAires.VillaFrancia },
                { 333, LocalidadBuenosAires.ColoniaSanRicardo },
                { 334, LocalidadBuenosAires.VillaRoth },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralPueyrredon).Value.Key, new Dictionary<long, string>
            {
                { 335, LocalidadBuenosAires.MarDelPlata },
                { 336, LocalidadBuenosAires.LasQuintas },
                { 337, LocalidadBuenosAires.LosZorzales },
                { 338, LocalidadBuenosAires.ElSosiego },
                { 339, LocalidadBuenosAires.EstacionCamet },
                { 340, LocalidadBuenosAires.SantaAngela },
                { 341, LocalidadBuenosAires.Barrio2DeAbril },
                { 342, LocalidadBuenosAires.LaAdela },
                { 343, LocalidadBuenosAires.LasMargaritas },
                { 344, LocalidadBuenosAires.ElDorado },
                { 345, LocalidadBuenosAires.ColinasVerdes },
                { 346, LocalidadBuenosAires.BarrioLaGloriaDeLaPeregrina },
                { 347, LocalidadBuenosAires.SierraDeLosPadres },
                { 348, LocalidadBuenosAires.ElCoyunco },
                { 349, LocalidadBuenosAires.LagunaDeLosPadres },
                { 350, LocalidadBuenosAires.SantaPaula },
                { 351, LocalidadBuenosAires.Batan },
                { 352, LocalidadBuenosAires.BarrioEstacionChapadmalal },
                { 353, LocalidadBuenosAires.BarrioFelixUCamet },
                { 354, LocalidadBuenosAires.BarrioLosAcantilados },
                { 355, LocalidadBuenosAires.BarrioChapadmalal },
                { 356, LocalidadBuenosAires.BarrioSanEduardoDelMar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralRodriguez).Value.Key, new Dictionary<long, string>
            {
                { 357, LocalidadBuenosAires.GeneralRodriguez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralSanMartin).Value.Key, new Dictionary<long, string>
            {
                { 358, LocalidadBuenosAires.Billinghurst },
                { 359, LocalidadBuenosAires.LomaHermosa },
                { 360, LocalidadBuenosAires.JoseLeonSuarez },
                { 361, LocalidadBuenosAires.SanAndres },
                { 362, LocalidadBuenosAires.SanMartin },
                { 363, LocalidadBuenosAires.VillaAyacucho },
                { 364, LocalidadBuenosAires.VillaChacabuco },
                { 365, LocalidadBuenosAires.VillaBallester },
                { 366, LocalidadBuenosAires.VillaLynch },
                { 367, LocalidadBuenosAires.VillaMaipu },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralViamonte).Value.Key, new Dictionary<long, string>
            {
                { 368, LocalidadBuenosAires.LosToldos },
                { 369, LocalidadBuenosAires.Baigorrita },
                { 370, LocalidadBuenosAires.Zavalia },
                { 371, LocalidadBuenosAires.SanEmilio },
                { 372, LocalidadBuenosAires.LaDelfina },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.GeneralVillegas).Value.Key, new Dictionary<long, string>
            {
                { 373, LocalidadBuenosAires.GeneralVillegas },
                { 374, LocalidadBuenosAires.Piedritas },
                { 375, LocalidadBuenosAires.EmilioVBunge },
                { 376, LocalidadBuenosAires.CoronelCharlone },
                { 377, LocalidadBuenosAires.Banderalo },
                { 378, LocalidadBuenosAires.CanadaSeca },
                { 379, LocalidadBuenosAires.VillaSauze },
                { 380, LocalidadBuenosAires.SantaRegina },
                { 381, LocalidadBuenosAires.VillaSaboya },
                { 382, LocalidadBuenosAires.SantaEleodora },
                { 383, LocalidadBuenosAires.MasseyEstElordi },
                { 384, LocalidadBuenosAires.Pichincha },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Guamini).Value.Key, new Dictionary<long, string>
            {
                { 385, LocalidadBuenosAires.LagunaAlsina },
                { 386, LocalidadBuenosAires.Casbas },
                { 387, LocalidadBuenosAires.Guamini },
                { 388, LocalidadBuenosAires.VictorinoDeLaPlaza },
                { 389, LocalidadBuenosAires.Garre },
                { 390, LocalidadBuenosAires.ArroyoVenado },
                { 391, LocalidadBuenosAires.Huanguelen },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.HipolitoYrigoyen).Value.Key, new Dictionary<long, string>
            {
                { 392, LocalidadBuenosAires.Henderson },
                { 393, LocalidadBuenosAires.HerreraVegas },
                { 394, LocalidadBuenosAires.MariaLucila },
                { 395, LocalidadBuenosAires.Coraceros },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Hurlingham).Value.Key, new Dictionary<long, string>
            {
                { 396, LocalidadBuenosAires.Hurlingham },
                { 397, LocalidadBuenosAires.VillaTesei },
                { 398, LocalidadBuenosAires.WilliamCMorris },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ituzaingo).Value.Key, new Dictionary<long, string>
            {
                { 399, LocalidadBuenosAires.Ituzaingo },
                { 400, LocalidadBuenosAires.VillaUdaondo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.JoseCPaz).Value.Key, new Dictionary<long, string>
            {
                { 401, LocalidadBuenosAires.JoseCPaz },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Junin).Value.Key, new Dictionary<long, string>
            {
                { 402, LocalidadBuenosAires.Junin },
                { 403, LocalidadBuenosAires.Morse },
                { 404, LocalidadBuenosAires.AgustinRoca },
                { 405, LocalidadBuenosAires.FortinTiburcio },
                { 406, LocalidadBuenosAires.Saforcada },
                { 407, LocalidadBuenosAires.Agustina },
                { 408, LocalidadBuenosAires.Laplacette },
                { 409, LocalidadBuenosAires.BalnearioLagunaDeGomez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LaCosta).Value.Key, new Dictionary<long, string>
            {
                { 410, LocalidadBuenosAires.SanClementeDelTuyu },
                { 411, LocalidadBuenosAires.LasToninas },
                { 412, LocalidadBuenosAires.CostaChica },
                { 413, LocalidadBuenosAires.SantaTeresita },
                { 414, LocalidadBuenosAires.MarDelTuyu },
                { 415, LocalidadBuenosAires.CostaDelEste },
                { 416, LocalidadBuenosAires.AguasVerdes },
                { 417, LocalidadBuenosAires.LaLucilaDelMar },
                { 418, LocalidadBuenosAires.CostaAzul },
                { 419, LocalidadBuenosAires.SanBernardoDelTuyu },
                { 420, LocalidadBuenosAires.MarDeAjo },
                { 421, LocalidadBuenosAires.NuevaAtlantis },
                { 422, LocalidadBuenosAires.PuntaMedanos },
                { 423, LocalidadBuenosAires.PinarDelSol },
                { 424, LocalidadBuenosAires.CostaEsmeralda },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LaMatanza).Value.Key, new Dictionary<long, string>
            {
                { 425, LocalidadBuenosAires.SanJusto },
                { 426, LocalidadBuenosAires.20DeJunio },
                { 427, LocalidadBuenosAires.AldoBonzi },
                { 428, LocalidadBuenosAires.CiudadCelina },
                { 429, LocalidadBuenosAires.CiudadEvita },
                { 430, LocalidadBuenosAires.GonzalezCatan },
                { 431, LocalidadBuenosAires.GregorioDeLaferrere },
                { 432, LocalidadBuenosAires.IsidroCasanova },
                { 433, LocalidadBuenosAires.LaTablada },
                { 434, LocalidadBuenosAires.LomasDelMirador },
                { 435, LocalidadBuenosAires.RafaelCastillo },
                { 436, LocalidadBuenosAires.RamosMejia },
                { 437, LocalidadBuenosAires.Tapiales },
                { 438, LocalidadBuenosAires.VillaLuzuriaga },
                { 439, LocalidadBuenosAires.VillaMadero },
                { 440, LocalidadBuenosAires.VirreyDelPino },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LaPlata).Value.Key, new Dictionary<long, string>
            {
                { 441, LocalidadBuenosAires.CountryClubElRodeo },
                { 442, LocalidadBuenosAires.BarrioRutaSol },
                { 443, LocalidadBuenosAires.Abasto },
                { 444, LocalidadBuenosAires.AngelEtcheverry },
                { 445, LocalidadBuenosAires.Arana },
                { 446, LocalidadBuenosAires.ArturoSegui },
                { 447, LocalidadBuenosAires.BarrioElCarmen },
                { 448, LocalidadBuenosAires.BarrioGambier },
                { 449, LocalidadBuenosAires.BarrioLasMalvinas },
                { 450, LocalidadBuenosAires.BarrioLasQuintas },
                { 451, LocalidadBuenosAires.CityBell },
                { 452, LocalidadBuenosAires.ElRetiro },
                { 453, LocalidadBuenosAires.JoaquinGorina },
                { 454, LocalidadBuenosAires.JoseHernandez },
                { 455, LocalidadBuenosAires.JoseMelchorRomero },
                { 456, LocalidadBuenosAires.LaCumbre },
                { 457, LocalidadBuenosAires.CascoUrbano },
                { 458, LocalidadBuenosAires.LisandroOlmos },
                { 459, LocalidadBuenosAires.LosHornos },
                { 460, LocalidadBuenosAires.ManuelBGonnet },
                { 461, LocalidadBuenosAires.Ringuelet },
                { 462, LocalidadBuenosAires.AltosDeSanLorenzo },
                { 463, LocalidadBuenosAires.Tolosa },
                { 464, LocalidadBuenosAires.Transradio },
                { 465, LocalidadBuenosAires.VillaElisa },
                { 466, LocalidadBuenosAires.VillaElvira },
                { 467, LocalidadBuenosAires.VillaGaribaldi },
                { 468, LocalidadBuenosAires.VillaMontoro },
                { 469, LocalidadBuenosAires.VillaParqueSicardi },
                { 470, LocalidadBuenosAires.IgnacioCorreas },
                { 471, LocalidadBuenosAires.LomasDeCopello },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lanus).Value.Key, new Dictionary<long, string>
            {
                { 472, LocalidadBuenosAires.LanusOeste },
                { 473, LocalidadBuenosAires.LanusEste },
                { 474, LocalidadBuenosAires.RemediosDeEscalada },
                { 475, LocalidadBuenosAires.Gerli },
                { 476, LocalidadBuenosAires.ValentinAlsina },
                { 477, LocalidadBuenosAires.MonteChingolo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Laprida).Value.Key, new Dictionary<long, string>
            {
                { 478, LocalidadBuenosAires.Laprida },
                { 479, LocalidadBuenosAires.PuebloSanJorge },
                { 480, LocalidadBuenosAires.PuebloNuevo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LasFlores).Value.Key, new Dictionary<long, string>
            {
                { 481, LocalidadBuenosAires.LasFlores },
                { 482, LocalidadBuenosAires.Pardo },
                { 483, LocalidadBuenosAires.ElTrigo },
                { 484, LocalidadBuenosAires.CoronelBoerr },
                { 485, LocalidadBuenosAires.Rosas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LeandroNAlem).Value.Key, new Dictionary<long, string>
            {
                { 486, LocalidadBuenosAires.Vedia },
                { 487, LocalidadBuenosAires.JuanBautistaAlberdi },
                { 488, LocalidadBuenosAires.LeandroNAlem },
                { 489, LocalidadBuenosAires.AlberdiViejo },
                { 490, LocalidadBuenosAires.ElDorado },
                { 491, LocalidadBuenosAires.FortinAcha },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lezama).Value.Key, new Dictionary<long, string>
            {
                { 492, LocalidadBuenosAires.Lezama },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lincoln).Value.Key, new Dictionary<long, string>
            {
                { 493, LocalidadBuenosAires.Lincoln },
                { 494, LocalidadBuenosAires.Roberts },
                { 495, LocalidadBuenosAires.Pasteur },
                { 496, LocalidadBuenosAires.ElTriunfo },
                { 497, LocalidadBuenosAires.Arenaza },
                { 498, LocalidadBuenosAires.CoronelMartinezDeHoz },
                { 499, LocalidadBuenosAires.Bayauca },
                { 500, LocalidadBuenosAires.LasToscas },
                { 501, LocalidadBuenosAires.CarlosSalas },
                { 502, LocalidadBuenosAires.Triunvirato },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Loberia).Value.Key, new Dictionary<long, string>
            {
                { 503, LocalidadBuenosAires.Loberia },
                { 504, LocalidadBuenosAires.SanManuel },
                { 505, LocalidadBuenosAires.Tamangueyu },
                { 506, LocalidadBuenosAires.LicenciadoMatienzo },
                { 507, LocalidadBuenosAires.Pieres },
                { 508, LocalidadBuenosAires.ArenasVerdes },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lobos).Value.Key, new Dictionary<long, string>
            {
                { 509, LocalidadBuenosAires.AntonioCarboni },
                { 510, LocalidadBuenosAires.Elvira },
                { 511, LocalidadBuenosAires.JoseSantosArevalo },
                { 512, LocalidadBuenosAires.Lobos },
                { 513, LocalidadBuenosAires.EmpalmeLobos },
                { 514, LocalidadBuenosAires.LasChacras },
                { 515, LocalidadBuenosAires.SalvadorMaria },
                { 516, LocalidadBuenosAires.VillaLoguercio },
                { 517, LocalidadBuenosAires.Zapiola },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.LomasDeZamora).Value.Key, new Dictionary<long, string>
            {
                { 518, LocalidadBuenosAires.LomasDeZamora },
                { 519, LocalidadBuenosAires.Banfield },
                { 520, LocalidadBuenosAires.Temperley },
                { 521, LocalidadBuenosAires.Llavallol },
                { 522, LocalidadBuenosAires.Turdera },
                { 523, LocalidadBuenosAires.VillaCentenario },
                { 524, LocalidadBuenosAires.VillaFiorito },
                { 525, LocalidadBuenosAires.IngenieroBudge },
                { 526, LocalidadBuenosAires.VillaAlbertina },
                { 527, LocalidadBuenosAires.SanJose },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Lujan).Value.Key, new Dictionary<long, string>
            {
                { 528, LocalidadBuenosAires.CarlosKeen },
                { 529, LocalidadBuenosAires.Cortines },
                { 530, LocalidadBuenosAires.JoseMariaJauregui },
                { 531, LocalidadBuenosAires.Lujan },
                { 532, LocalidadBuenosAires.Olivera },
                { 533, LocalidadBuenosAires.OpenDoor },
                { 534, LocalidadBuenosAires.Torres },
                { 535, LocalidadBuenosAires.LezicaYTorrezuri },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Magdalena).Value.Key, new Dictionary<long, string>
            {
                { 536, LocalidadBuenosAires.Magdalena },
                { 537, LocalidadBuenosAires.GeneralMansilla },
                { 538, LocalidadBuenosAires.Atalaya },
                { 539, LocalidadBuenosAires.Vieytes },
                { 540, LocalidadBuenosAires.RobertoJPayro },
                { 541, LocalidadBuenosAires.LosNaranjos },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Maipu).Value.Key, new Dictionary<long, string>
            {
                { 542, LocalidadBuenosAires.Maipu },
                { 543, LocalidadBuenosAires.LasArmas },
                { 544, LocalidadBuenosAires.SantoDomingo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MalvinasArgentinas).Value.Key, new Dictionary<long, string>
            {
                { 545, LocalidadBuenosAires.AreaDePromocionElTriangulo },
                { 546, LocalidadBuenosAires.GrandBourg },
                { 547, LocalidadBuenosAires.IngenieroAdolfoSourdeaux },
                { 548, LocalidadBuenosAires.IngenieroPabloNogues },
                { 549, LocalidadBuenosAires.LosPolvorines },
                { 550, LocalidadBuenosAires.Tortuguitas },
                { 551, LocalidadBuenosAires.VillaDeMayo },
                { 552, LocalidadBuenosAires.TierrasAltas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MarChiquita).Value.Key, new Dictionary<long, string>
            {
                { 553, LocalidadBuenosAires.CoronelVidal },
                { 554, LocalidadBuenosAires.GeneralPiran },
                { 555, LocalidadBuenosAires.LaArmonia },
                { 556, LocalidadBuenosAires.MarChiquita },
                { 557, LocalidadBuenosAires.MarDeCobo },
                { 558, LocalidadBuenosAires.LaBaliza },
                { 559, LocalidadBuenosAires.LaCaleta },
                { 560, LocalidadBuenosAires.MarDeCobo },
                { 561, LocalidadBuenosAires.SantaClaraDelMar },
                { 562, LocalidadBuenosAires.Atlantida },
                { 563, LocalidadBuenosAires.CametNorte },
                { 564, LocalidadBuenosAires.FrenteMar },
                { 565, LocalidadBuenosAires.PlayaDorada },
                { 566, LocalidadBuenosAires.SantaClaraDelMar },
                { 567, LocalidadBuenosAires.SantaElena },
                { 568, LocalidadBuenosAires.Vivorata },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MarcosPaz).Value.Key, new Dictionary<long, string>
            {
                { 569, LocalidadBuenosAires.MarcosPaz },
                { 570, LocalidadBuenosAires.EliasRomero },
                { 571, LocalidadBuenosAires.SantaRosa },
                { 572, LocalidadBuenosAires.LisandroDeLaTorre },
                { 573, LocalidadBuenosAires.SantaMarta },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Mercedes).Value.Key, new Dictionary<long, string>
            {
                { 574, LocalidadBuenosAires.Agote },
                { 575, LocalidadBuenosAires.Altamira },
                { 576, LocalidadBuenosAires.Goldney },
                { 577, LocalidadBuenosAires.Gowland },
                { 578, LocalidadBuenosAires.JMGarcia },
                { 579, LocalidadBuenosAires.LaVerde },
                { 580, LocalidadBuenosAires.Mercedes },
                { 581, LocalidadBuenosAires.TomasJofre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Merlo).Value.Key, new Dictionary<long, string>
            {
                { 582, LocalidadBuenosAires.Merlo },
                { 583, LocalidadBuenosAires.SanAntonioDePadua },
                { 584, LocalidadBuenosAires.Libertad },
                { 585, LocalidadBuenosAires.MarianoAcosta },
                { 586, LocalidadBuenosAires.ParqueSanMartin },
                { 587, LocalidadBuenosAires.Pontevedra },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Monte).Value.Key, new Dictionary<long, string>
            {
                { 588, LocalidadBuenosAires.SanMiguelDelMonte },
                { 589, LocalidadBuenosAires.Abbott },
                { 590, LocalidadBuenosAires.ZenonVidelaDorna },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.MonteHermoso).Value.Key, new Dictionary<long, string>
            {
                { 591, LocalidadBuenosAires.MonteHermoso },
                { 592, LocalidadBuenosAires.BalnearioSauceGrande },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Moreno).Value.Key, new Dictionary<long, string>
            {
                { 593, LocalidadBuenosAires.Moreno },
                { 594, LocalidadBuenosAires.LaReja },
                { 595, LocalidadBuenosAires.FranciscoAlvarez },
                { 596, LocalidadBuenosAires.CuartelV },
                { 597, LocalidadBuenosAires.Trujui },
                { 598, LocalidadBuenosAires.PasoDelRey },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Moron).Value.Key, new Dictionary<long, string>
            {
                { 599, LocalidadBuenosAires.Moron },
                { 600, LocalidadBuenosAires.Castelar },
                { 601, LocalidadBuenosAires.ElPalomar },
                { 602, LocalidadBuenosAires.Haedo },
                { 603, LocalidadBuenosAires.VillaSarmiento },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Navarro).Value.Key, new Dictionary<long, string>
            {
                { 604, LocalidadBuenosAires.Navarro },
                { 605, LocalidadBuenosAires.VillaMoll },
                { 606, LocalidadBuenosAires.LasMarianas },
                { 607, LocalidadBuenosAires.JoseJuanAlmeyra },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Necochea).Value.Key, new Dictionary<long, string>
            {
                { 608, LocalidadBuenosAires.Necochea },
                { 609, LocalidadBuenosAires.Quequen },
                { 610, LocalidadBuenosAires.JuanNepomucenoFernandez },
                { 611, LocalidadBuenosAires.LaDulce },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.NueveDeJulio).Value.Key, new Dictionary<long, string>
            {
                { 612, LocalidadBuenosAires.NueveDeJulio },
                { 613, LocalidadBuenosAires.Dudignac },
                { 614, LocalidadBuenosAires.AlfredoDemarchi },
                { 615, LocalidadBuenosAires.ManuelBGonnet },
                { 616, LocalidadBuenosAires.Patricios },
                { 617, LocalidadBuenosAires.LaAurora },
                { 618, LocalidadBuenosAires.CarlosMariaNaon },
                { 619, LocalidadBuenosAires.VillaGeneralFournier },
                { 620, LocalidadBuenosAires.Morea },
                { 621, LocalidadBuenosAires.DoceDeOctubre },
                { 622, LocalidadBuenosAires.MarcelinoUgarte },
                { 623, LocalidadBuenosAires.Norumbega },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Olavarria).Value.Key, new Dictionary<long, string>
            {
                { 624, LocalidadBuenosAires.SierrasBayas },
                { 625, LocalidadBuenosAires.LomaNegra },
                { 626, LocalidadBuenosAires.SierraChica },
                { 627, LocalidadBuenosAires.Hinojo },
                { 628, LocalidadBuenosAires.ColoniaHinojo },
                { 629, LocalidadBuenosAires.ColoniaSanMiguel },
                { 630, LocalidadBuenosAires.Espigas },
                { 631, LocalidadBuenosAires.Recalde },
                { 632, LocalidadBuenosAires.VillaLaSerrania },
                { 633, LocalidadBuenosAires.SantaLuisa },
                { 634, LocalidadBuenosAires.BlancaGrande },
                { 635, LocalidadBuenosAires.ColoniaNievas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Patagones).Value.Key, new Dictionary<long, string>
            {
                { 636, LocalidadBuenosAires.CarmenDePatagones },
                { 637, LocalidadBuenosAires.Villalonga },
                { 638, LocalidadBuenosAires.Stroeder },
                { 639, LocalidadBuenosAires.BahiaSanBlas },
                { 640, LocalidadBuenosAires.JuanAPradere },
                { 641, LocalidadBuenosAires.CardenalCagliero },
                { 642, LocalidadBuenosAires.JoseBCasas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pehuajo).Value.Key, new Dictionary<long, string>
            {
                { 643, LocalidadBuenosAires.Pehuajo },
                { 644, LocalidadBuenosAires.JuanJosePaso },
                { 645, LocalidadBuenosAires.MonesCazon },
                { 646, LocalidadBuenosAires.FranciscoMadero },
                { 647, LocalidadBuenosAires.SanBernardoDePehuajo },
                { 648, LocalidadBuenosAires.Magdala },
                { 649, LocalidadBuenosAires.NuevaPlata },
                { 650, LocalidadBuenosAires.Chiclana },
                { 651, LocalidadBuenosAires.CapitanCastro },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pellegrini).Value.Key, new Dictionary<long, string>
            {
                { 652, LocalidadBuenosAires.Pellegrini },
                { 653, LocalidadBuenosAires.Bocayuva },
                { 654, LocalidadBuenosAires.DeBary },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pergamino).Value.Key, new Dictionary<long, string>
            {
                { 655, LocalidadBuenosAires.Pergamino },
                { 656, LocalidadBuenosAires.Acevedo },
                { 657, LocalidadBuenosAires.ManuelOcampo },
                { 658, LocalidadBuenosAires.VillaAngelica },
                { 659, LocalidadBuenosAires.JuanAnchorena },
                { 660, LocalidadBuenosAires.LaVioleta },
                { 661, LocalidadBuenosAires.MarianoHAlfonzo },
                { 662, LocalidadBuenosAires.Guerrico },
                { 663, LocalidadBuenosAires.Rancagua },
                { 664, LocalidadBuenosAires.Pinzon },
                { 665, LocalidadBuenosAires.Fontezuela },
                { 666, LocalidadBuenosAires.JADeLaPena },
                { 667, LocalidadBuenosAires.MarianoBenitez },
                { 668, LocalidadBuenosAires.VillaSanJose },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pila).Value.Key, new Dictionary<long, string>
            {
                { 669, LocalidadBuenosAires.Pila },
                { 670, LocalidadBuenosAires.Casalins },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pilar).Value.Key, new Dictionary<long, string>
            {
                { 671, LocalidadBuenosAires.DelViso },
                { 672, LocalidadBuenosAires.Fatima },
                { 673, LocalidadBuenosAires.LaLonja },
                { 674, LocalidadBuenosAires.Manzanares },
                { 675, LocalidadBuenosAires.DelPilar },
                { 676, LocalidadBuenosAires.PilarSur },
                { 677, LocalidadBuenosAires.Champagnat },
                { 678, LocalidadBuenosAires.SanFrancisco },
                { 679, LocalidadBuenosAires.PresidenteDerqui },
                { 680, LocalidadBuenosAires.VillaAstolfi },
                { 681, LocalidadBuenosAires.Manzone },
                { 682, LocalidadBuenosAires.ManuelAlberti },
                { 683, LocalidadBuenosAires.Lagomarsino },
                { 684, LocalidadBuenosAires.VillaRosa },
                { 685, LocalidadBuenosAires.Zelaya },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Pinamar).Value.Key, new Dictionary<long, string>
            {
                { 686, LocalidadBuenosAires.Montecarlo },
                { 687, LocalidadBuenosAires.Pinamar },
                { 688, LocalidadBuenosAires.MarDeOstende },
                { 689, LocalidadBuenosAires.Ostende },
                { 690, LocalidadBuenosAires.ValeriaDelMar },
                { 691, LocalidadBuenosAires.Carilo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.PresidentePeron).Value.Key, new Dictionary<long, string>
            {
                { 692, LocalidadBuenosAires.Guernica },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Puan).Value.Key, new Dictionary<long, string>
            {
                { 693, LocalidadBuenosAires.Azopardo },
                { 694, LocalidadBuenosAires.Bordenave },
                { 695, LocalidadBuenosAires.Darregueira },
                { 696, LocalidadBuenosAires.Estela },
                { 697, LocalidadBuenosAires.FelipeSola },
                { 698, LocalidadBuenosAires.LopezLecube },
                { 699, LocalidadBuenosAires.Puan },
                { 700, LocalidadBuenosAires.SanGerman },
                { 701, LocalidadBuenosAires.TresCuervos },
                { 702, LocalidadBuenosAires.Viboras },
                { 703, LocalidadBuenosAires.VillaCastelar },
                { 704, LocalidadBuenosAires.VillaDurcudoy },
                { 705, LocalidadBuenosAires.VillaIris },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.PuntaIndio).Value.Key, new Dictionary<long, string>
            {
                { 706, LocalidadBuenosAires.Veronica },
                { 707, LocalidadBuenosAires.Pipinas },
                { 708, LocalidadBuenosAires.PuntaDelIndio },
                { 709, LocalidadBuenosAires.AlvarezJonte },
                { 710, LocalidadBuenosAires.LasTahonas },
                { 711, LocalidadBuenosAires.MonteVeloz },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Quilmes).Value.Key, new Dictionary<long, string>
            {
                { 712, LocalidadBuenosAires.BernalEste },
                { 713, LocalidadBuenosAires.BernalOeste },
                { 714, LocalidadBuenosAires.DonBosco },
                { 715, LocalidadBuenosAires.Ezpeleta },
                { 716, LocalidadBuenosAires.EzpeletaOeste },
                { 717, LocalidadBuenosAires.Quilmes },
                { 718, LocalidadBuenosAires.QuilmesOeste },
                { 719, LocalidadBuenosAires.SanFranciscoSolano },
                { 720, LocalidadBuenosAires.VillaLaFlorida },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Ramallo).Value.Key, new Dictionary<long, string>
            {
                { 721, LocalidadBuenosAires.Ramallo },
                { 722, LocalidadBuenosAires.ElParaiso },
                { 723, LocalidadBuenosAires.PerezMillan },
                { 724, LocalidadBuenosAires.VillaRamallo },
                { 725, LocalidadBuenosAires.VillaGeneralSavio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Rauch).Value.Key, new Dictionary<long, string>
            {
                { 726, LocalidadBuenosAires.Rauch },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Rivadavia).Value.Key, new Dictionary<long, string>
            {
                { 727, LocalidadBuenosAires.America },
                { 728, LocalidadBuenosAires.GonzalezMoreno },
                { 729, LocalidadBuenosAires.FortinOlavarria },
                { 730, LocalidadBuenosAires.Sansinena },
                { 731, LocalidadBuenosAires.Roosevelt },
                { 732, LocalidadBuenosAires.Sundblad },
                { 733, LocalidadBuenosAires.MiraPampa },
                { 734, LocalidadBuenosAires.SanMauricio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Rojas).Value.Key, new Dictionary<long, string>
            {
                { 735, LocalidadBuenosAires.Rojas },
                { 736, LocalidadBuenosAires.LasCarabelas },
                { 737, LocalidadBuenosAires.RafaelObligado },
                { 738, LocalidadBuenosAires.LosIndios },
                { 739, LocalidadBuenosAires.VillaManuelPomar },
                { 740, LocalidadBuenosAires.LaBeba },
                { 741, LocalidadBuenosAires.VillaParqueCecir },
                { 742, LocalidadBuenosAires.RobertoCano },
                { 743, LocalidadBuenosAires.SolDeMayo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.RoquePerez).Value.Key, new Dictionary<long, string>
            {
                { 744, LocalidadBuenosAires.RoquePerez },
                { 745, LocalidadBuenosAires.CarlosBeguerie },
                { 746, LocalidadBuenosAires.SantiagoLarre },
                { 747, LocalidadBuenosAires.LaReforma },
                { 748, LocalidadBuenosAires.JuanTronconi },
                { 749, LocalidadBuenosAires.LaPaz },
                { 750, LocalidadBuenosAires.LaPazChica },
                { 751, LocalidadBuenosAires.Atucha },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Saavedra).Value.Key, new Dictionary<long, string>
            {
                { 752, LocalidadBuenosAires.Pigue },
                { 753, LocalidadBuenosAires.Saavedra },
                { 754, LocalidadBuenosAires.Espartillar },
                { 755, LocalidadBuenosAires.Goyena },
                { 756, LocalidadBuenosAires.ArroyoCorto },
                { 757, LocalidadBuenosAires.Dufaur },
                { 758, LocalidadBuenosAires.ColoniaSanMartin },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Saladillo).Value.Key, new Dictionary<long, string>
            {
                { 759, LocalidadBuenosAires.Saladillo },
                { 760, LocalidadBuenosAires.DelCarril },
                { 761, LocalidadBuenosAires.Polvaredas },
                { 762, LocalidadBuenosAires.Cazon },
                { 763, LocalidadBuenosAires.AlvarezDeToledo },
                { 764, LocalidadBuenosAires.JuanJoseBlaquier },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Salliquelo).Value.Key, new Dictionary<long, string>
            {
                { 765, LocalidadBuenosAires.Salliquelo },
                { 766, LocalidadBuenosAires.Quenuma },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Salto).Value.Key, new Dictionary<long, string>
            {
                { 767, LocalidadBuenosAires.Salto },
                { 768, LocalidadBuenosAires.ArroyoDulce },
                { 769, LocalidadBuenosAires.InesIndart },
                { 770, LocalidadBuenosAires.Gahan },
                { 771, LocalidadBuenosAires.Berdier },
                { 772, LocalidadBuenosAires.LaInvencible },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanAndresDeGiles).Value.Key, new Dictionary<long, string>
            {
                { 773, LocalidadBuenosAires.SanAndresDeGiles },
                { 774, LocalidadBuenosAires.Solis },
                { 775, LocalidadBuenosAires.VillaRuiz },
                { 776, LocalidadBuenosAires.Cucullu },
                { 777, LocalidadBuenosAires.Azcuenaga },
                { 778, LocalidadBuenosAires.VillaEspil },
                { 779, LocalidadBuenosAires.Franklin },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanAntonioDeAreco).Value.Key, new Dictionary<long, string>
            {
                { 780, LocalidadBuenosAires.SanAntonioDeAreco },
                { 781, LocalidadBuenosAires.VillaLia },
                { 782, LocalidadBuenosAires.Duggan },
                { 783, LocalidadBuenosAires.Vagues },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanCayetano).Value.Key, new Dictionary<long, string>
            {
                { 784, LocalidadBuenosAires.SanCayetano },
                { 785, LocalidadBuenosAires.Ochandio },
                { 786, LocalidadBuenosAires.BalnearioSanCayetano },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanFernando).Value.Key, new Dictionary<long, string>
            {
                { 787, LocalidadBuenosAires.SanFernando },
                { 788, LocalidadBuenosAires.Victoria },
                { 789, LocalidadBuenosAires.Virreyes },
                { 790, LocalidadBuenosAires.Islas },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanIsidro).Value.Key, new Dictionary<long, string>
            {
                { 791, LocalidadBuenosAires.VillaAdelina },
                { 792, LocalidadBuenosAires.BoulogneSurMer },
                { 793, LocalidadBuenosAires.Martinez },
                { 794, LocalidadBuenosAires.Acassuso },
                { 795, LocalidadBuenosAires.SanIsidro },
                { 796, LocalidadBuenosAires.Beccar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanMiguel).Value.Key, new Dictionary<long, string>
            {
                { 797, LocalidadBuenosAires.SanMiguel },
                { 798, LocalidadBuenosAires.BellaVista },
                { 799, LocalidadBuenosAires.CampoDeMayo },
                { 800, LocalidadBuenosAires.Muniz },
                { 801, LocalidadBuenosAires.SantaMaria },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanNicolas).Value.Key, new Dictionary<long, string>
            {
                { 802, LocalidadBuenosAires.CamposSalles },
                { 803, LocalidadBuenosAires.Conesa },
                { 804, LocalidadBuenosAires.Erezcano },
                { 805, LocalidadBuenosAires.GeneralRojo },
                { 806, LocalidadBuenosAires.LaEmilia },
                { 807, LocalidadBuenosAires.SanNicolasDeLosArroyos },
                { 808, LocalidadBuenosAires.VillaCampi },
                { 809, LocalidadBuenosAires.VillaCanto },
                { 810, LocalidadBuenosAires.VillaEsperanza },
                { 811, LocalidadBuenosAires.VillaHermosa },
                { 812, LocalidadBuenosAires.VillaRiccio },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanPedro).Value.Key, new Dictionary<long, string>
            {
                { 813, LocalidadBuenosAires.SanPedro },
                { 814, LocalidadBuenosAires.GobernadorCastro },
                { 815, LocalidadBuenosAires.SantaLucia },
                { 816, LocalidadBuenosAires.RioTala },
                { 817, LocalidadBuenosAires.PuebloDoyle },
                { 818, LocalidadBuenosAires.Obligado },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.SanVicente).Value.Key, new Dictionary<long, string>
            {
                { 819, LocalidadBuenosAires.SanVicente },
                { 820, LocalidadBuenosAires.AlejandroKorn },
                { 821, LocalidadBuenosAires.Domselaar },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Suipacha).Value.Key, new Dictionary<long, string>
            {
                { 822, LocalidadBuenosAires.Suipacha },
                { 823, LocalidadBuenosAires.GeneralRivas },
                { 824, LocalidadBuenosAires.RomanBaez },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tandil).Value.Key, new Dictionary<long, string>
            {
                { 825, LocalidadBuenosAires.Tandil },
                { 826, LocalidadBuenosAires.MariaIgnacia },
                { 827, LocalidadBuenosAires.Gardey },
                { 828, LocalidadBuenosAires.DeLaCanal },
                { 829, LocalidadBuenosAires.DesvioAguirre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tapalque).Value.Key, new Dictionary<long, string>
            {
                { 830, LocalidadBuenosAires.Tapalque },
                { 831, LocalidadBuenosAires.Altona },
                { 832, LocalidadBuenosAires.Crotto },
                { 833, LocalidadBuenosAires.EufemioUballes },
                { 834, LocalidadBuenosAires.Yerbas },
                { 835, LocalidadBuenosAires.SanBernardo },
                { 836, LocalidadBuenosAires.Covello },
                { 837, LocalidadBuenosAires.Velloso },
                { 838, LocalidadBuenosAires.LaPaloma },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tigre).Value.Key, new Dictionary<long, string>
            {
                { 839, LocalidadBuenosAires.Tigre },
                { 840, LocalidadBuenosAires.DonTorcuato },
                { 841, LocalidadBuenosAires.GeneralPacheco },
                { 842, LocalidadBuenosAires.ElTalar },
                { 843, LocalidadBuenosAires.TroncosDelTalar },
                { 844, LocalidadBuenosAires.Benavidez },
                { 845, LocalidadBuenosAires.DiqueLujan },
                { 846, LocalidadBuenosAires.RicardoRojas },
                { 847, LocalidadBuenosAires.RinconDeMilberg },
                { 848, LocalidadBuenosAires.Nordelta },
                { 849, LocalidadBuenosAires.DeltaDelTigre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tordillo).Value.Key, new Dictionary<long, string>
            {
                { 850, LocalidadBuenosAires.GeneralConesa },
                { 851, LocalidadBuenosAires.VillaRoch },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Tornquist).Value.Key, new Dictionary<long, string>
            {
                { 852, LocalidadBuenosAires.Tornquist },
                { 853, LocalidadBuenosAires.SierraDeLaVentana },
                { 854, LocalidadBuenosAires.Saldungaray },
                { 855, LocalidadBuenosAires.VillaVentana },
                { 856, LocalidadBuenosAires.Chasico },
                { 857, LocalidadBuenosAires.TresPicos },
                { 858, LocalidadBuenosAires.VillaSerranaLaGruta },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TrenqueLauquen).Value.Key, new Dictionary<long, string>
            {
                { 859, LocalidadBuenosAires.TrenqueLauquen },
                { 860, LocalidadBuenosAires.TreintaDeAgosto },
                { 861, LocalidadBuenosAires.Beruti },
                { 862, LocalidadBuenosAires.Girodias },
                { 863, LocalidadBuenosAires.LaCarreta },
                { 864, LocalidadBuenosAires.Garre },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TresArroyos).Value.Key, new Dictionary<long, string>
            {
                { 865, LocalidadBuenosAires.TresArroyos },
                { 866, LocalidadBuenosAires.Claromeco },
                { 867, LocalidadBuenosAires.Orense },
                { 868, LocalidadBuenosAires.Copetonas },
                { 869, LocalidadBuenosAires.MicaelaCascallares },
                { 870, LocalidadBuenosAires.SanFranciscoDeBellocq },
                { 871, LocalidadBuenosAires.Reta },
                { 872, LocalidadBuenosAires.BalnearioOrense },
                { 873, LocalidadBuenosAires.SanMayol },
                { 874, LocalidadBuenosAires.LinCalel },
                { 875, LocalidadBuenosAires.Barrow },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TresDeFebrero).Value.Key, new Dictionary<long, string>
            {
                { 876, LocalidadBuenosAires.Caseros },
                { 877, LocalidadBuenosAires.Churruca },
                { 878, LocalidadBuenosAires.CiudadJardinLomasDelPalomar },
                { 879, LocalidadBuenosAires.Ciudadela },
                { 880, LocalidadBuenosAires.ElLibertador },
                { 881, LocalidadBuenosAires.JoseIngenieros },
                { 882, LocalidadBuenosAires.LomaHermosa },
                { 883, LocalidadBuenosAires.MartinCoronado },
                { 884, LocalidadBuenosAires.OnceDeSeptiembre },
                { 885, LocalidadBuenosAires.PabloPodesta },
                { 886, LocalidadBuenosAires.RemediosDeEscalada },
                { 887, LocalidadBuenosAires.SaenzPena },
                { 888, LocalidadBuenosAires.SantosLugares },
                { 889, LocalidadBuenosAires.VillaBosch },
                { 890, LocalidadBuenosAires.VillaRaffo },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.TresLomas).Value.Key, new Dictionary<long, string>
            {
                { 891, LocalidadBuenosAires.TresLomas },
                { 892, LocalidadBuenosAires.IngenieroThompson },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.VeinticincoDeMayo).Value.Key, new Dictionary<long, string>
            {
                { 893, LocalidadBuenosAires.25DeMayo },
                { 894, LocalidadBuenosAires.NorbertoDeLaRiestra },
                { 895, LocalidadBuenosAires.Pedernales },
                { 896, LocalidadBuenosAires.DelValle },
                { 897, LocalidadBuenosAires.GobernadorUgarte },
                { 898, LocalidadBuenosAires.Valdes },
                { 899, LocalidadBuenosAires.SanEnrique },
                { 900, LocalidadBuenosAires.AgustinMosconi },
                { 901, LocalidadBuenosAires.Ernestina },
                { 902, LocalidadBuenosAires.LucasMonteverde },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.VicenteLopez).Value.Key, new Dictionary<long, string>
            {
                { 903, LocalidadBuenosAires.VicenteLopez },
                { 904, LocalidadBuenosAires.Olivos },
                { 905, LocalidadBuenosAires.Florida },
                { 906, LocalidadBuenosAires.LaLucila },
                { 907, LocalidadBuenosAires.VillaMartelli },
                { 908, LocalidadBuenosAires.FloridaOeste },
                { 909, LocalidadBuenosAires.Munro },
                { 910, LocalidadBuenosAires.Carapachay },
                { 911, LocalidadBuenosAires.VillaAdelina },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.VillaGesell).Value.Key, new Dictionary<long, string>
            {
                { 912, LocalidadBuenosAires.LasGaviotas },
                { 913, LocalidadBuenosAires.MarAzul },
                { 914, LocalidadBuenosAires.MarDeLasPampas },
                { 915, LocalidadBuenosAires.VillaGesell },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Villarino).Value.Key, new Dictionary<long, string>
            {
                { 916, LocalidadBuenosAires.PedroLuro },
                { 917, LocalidadBuenosAires.MayorBuratovich },
                { 918, LocalidadBuenosAires.Medanos },
                { 919, LocalidadBuenosAires.JuanCouste },
                { 920, LocalidadBuenosAires.HilarioAscasubi },
                { 921, LocalidadBuenosAires.TenienteOrigone },
                { 922, LocalidadBuenosAires.ColoniaSanAdolfo },
                { 923, LocalidadBuenosAires.Argerich },
                { 924, LocalidadBuenosAires.LagunaChasico },
                { 925, LocalidadBuenosAires.BalnearioLaChiquita },
            },
            dictionary.Add(fixturePartido.FindByNombre(PartidoBuenosAires.Zarate).Value.Key, new Dictionary<long, string>
            {
                { 926, LocalidadBuenosAires.Zarate },
                { 927, LocalidadBuenosAires.Lima },
                { 928, LocalidadBuenosAires.BarrioSaavedra },
                { 929, LocalidadBuenosAires.CountryClubElCasco },
                { 930, LocalidadBuenosAires.Escalada },
                { 931, LocalidadBuenosAires.ParajeOrtiz },
            });
        }
    }
}
