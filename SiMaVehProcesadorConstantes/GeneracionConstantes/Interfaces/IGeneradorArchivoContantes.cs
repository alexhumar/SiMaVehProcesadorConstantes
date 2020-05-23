namespace SiMaVehProcesadorConstantes.GeneracionConstantes.Interfaces
{
    public interface IGeneradorArchivoContantes<T>
    {
        void GenerarArchivo(string directorioBase, string tipoEntidad,
            string descripcionEntidad, string agrupacionEntidades, T infoEstructura);
    }
}
