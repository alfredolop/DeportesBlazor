using BlazorDeportes.Interfaces;
using BlazorDeportes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDeportes.Services
{
    public class DeporteService : IDeporteService
    {
        public Task<IEnumerable<Deporte>> GetAllDeportes()
        {
            throw new NotImplementedException();
        }
        public Task<Deporte> GetDetails(int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteDeporte(int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> SaveDeporte(Deporte deporte)
        {
            throw new NotImplementedException();
        }
    }
}
