using SegurosGAP.Entities;

namespace SegurosGAP.Model.Interfaces
{
    public interface ITiposCubrimientoRepository : IGenericRepository<TiposCubrimiento>
    {
        TiposCubrimiento GetSingle(int idTipoCubrimiento);
    }
}
