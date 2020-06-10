using BlazorDeportes.Data;
using BlazorDeportes.Data.Dapper.Repositories;
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
        private readonly SqlConfiguration _configuration;
        private IDeporteRepository _deporterepository;
        public DeporteService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _deporterepository = new DeporteRepository(configuration.ConnectionString);
        }
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
            if (deporte.id == 0)
                return _deporterepository.InsertDeporte(deporte);
            else
                return null;
        }
    }
}
