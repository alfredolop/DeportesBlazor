using BlazorDeportes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDeportes.Interfaces
{
    public interface IDeporteService
    {
        Task<IEnumerable<Deporte>> GetAllDeportes();
        Task<Deporte> GetDetails(int id);
        Task<bool> DeleteDeporte(int id);
        Task<bool> SaveDeporte(Deporte deporte);
    }
}
