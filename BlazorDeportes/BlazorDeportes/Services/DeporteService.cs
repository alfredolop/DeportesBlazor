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
            return _deporterepository.GetAllDeportes();
        }
        public Task<Deporte> GetDetails(int id)
        {
            return _deporterepository.GetDeporteDetails(id);
        }
        public Task<bool> DeleteDeporte(int id)
        {
            return _deporterepository.DeleteDeporte(id);
        }
        public Task<bool> SaveDeporte(Deporte deporte)
        {
            if (deporte.id == 0)
                return _deporterepository.InsertDeporte(deporte);
            else
                return _deporterepository.UpdateDeporte(deporte);
        }
    }
}
