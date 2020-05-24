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

            long currentID = 1;
            string baseDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;

            #endregion

            #region dependencias

            IProcesadorNombreConstante procesadorConstante = new ProcesadorNombreConstante();
            IProcesadorBuilder<ProcesadorLocalidades> procesadorLocalidadesBuilder = new ProcesadorLocalidadesBuilder(procesadorConstante);
            IProcesadorBuilder<ProcesadorPartidos> procesadorPartidosBuilder = new ProcesadorPartidosBuilder(procesadorConstante);

            var procesadorLocalidades = procesadorLocalidadesBuilder.BuildProcesador();
            var procesadorPartidos = procesadorPartidosBuilder.BuildProcesador();

            #endregion

            #region procesamiento

            //Aca queda el valor 136
            var resultadoPartidos = procesadorPartidos.ProcesarPartidos(baseDirectory, "Buenos Aires", currentID);

            //Y aca el 932
            var resultadoLocalidades = procesadorLocalidades.ProcesarLocalidades(baseDirectory, "Buenos Aires", currentID);

            #endregion
        }
    }
}
