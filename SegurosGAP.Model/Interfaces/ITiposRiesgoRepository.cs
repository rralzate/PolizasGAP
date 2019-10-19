using SegurosGAP.Entities;

namespace SegurosGAP.Model.Interfaces
{
    public interface ITiposRiesgoRepository : IGenericRepository<TiposRiesgo>
    {
        TiposRiesgo GetSinlge(int idTipoRiesgo);
    }
}
