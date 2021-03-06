﻿using SiMaVehProcesadorConstantes.Constantes;
using SiMaVehProcesadorConstantes.Procesadores;
using SiMaVehProcesadorConstantes.Procesadores.Builders;
using SiMaVehProcesadorConstantes.Procesadores.Interfaces;
using System.IO;

namespace SiMaVehProcesadorConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region config

            long startID = 1;
            string baseDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            string inputDirectory = Path.Combine(baseDirectory, Procesamiento.SubdirectorioProcesamiento);

            #endregion

            #region dependencias

            IProcesadorNombreConstante procesadorConstante = new ProcesadorNombreConstante();
            IProcesadorBuilder<ProcesadorLocalidades> procesadorLocalidadesBuilder = new ProcesadorLocalidadesBuilder(procesadorConstante);
            IProcesadorBuilder<ProcesadorPartidos> procesadorPartidosBuilder = new ProcesadorPartidosBuilder(procesadorConstante);
            IProcesadorBuilder<ProcesadorMonedas> procesadorMonedasBuilder = new ProcesadorMonedasBuilder(procesadorConstante);
            IProcesadorBuilder<ProcesadorMarcas> procesadorMarcasBuilder = new ProcesadorMarcasBuilder(procesadorConstante);

            var procesadorLocalidades = procesadorLocalidadesBuilder.BuildProcesador();
            var procesadorPartidos = procesadorPartidosBuilder.BuildProcesador();
            var procesadorMonedas = procesadorMonedasBuilder.BuildProcesador();
            var procesadorMarcas = procesadorMarcasBuilder.BuildProcesador();

            #endregion

            //TODO: agregar en la generacion de constantes, antes de agregar una, el chequeo de que no exista.

            #region procesamiento

            var currentPartidoId = startID;
            var currentLocalidadId = startID;

            //foreach (var subdirectorio in Directory.GetDirectories(inputDirectory))
            //{
            //    var nombreProvincia = Path.GetFileName(subdirectorio);
            //    var resultadoPartidos = procesadorPartidos.ProcesarPartidos(baseDirectory, nombreProvincia, currentPartidoId);
            //    currentPartidoId = resultadoPartidos.FinishId;
            //    var resultadoLocalidades = procesadorLocalidades.ProcesarLocalidades(baseDirectory, nombreProvincia, currentLocalidadId);
            //    currentLocalidadId = resultadoLocalidades.FinishId;
            //}

            //procesadorMonedas.ProcesarMonedas(baseDirectory);

            procesadorMarcas.ProcesarMarcas(baseDirectory);

            #endregion
        }
    }
}
