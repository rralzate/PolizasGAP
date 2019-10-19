using SegurosGAP.Entities;

namespace SegurosGAP.Model.Interfaces
{
    /// <summary>
    /// Interface that contains the CRUD policy administration
    /// </summary>
    public interface IPolizasRepository : IGenericRepository<PolizasSeguro>
    {
        PolizasSeguro GetSingle(int idPoliza);
    }
}
