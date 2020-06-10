using BlazorDeportes.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDeportes.Data.Dapper.Repositories
{
    public interface IDeporteRepository
    {
        Task<IEnumerable<Deporte>> GetAllDeportes();
        Task<Deporte> GetDeporteDetails(int id);
        Task<bool> InsertDeporte(Deporte deporte);
        Task<bool> UpdateDeporte(Deporte deporte);
        Task<bool> DeleteDeporte(int id);
    }
}
