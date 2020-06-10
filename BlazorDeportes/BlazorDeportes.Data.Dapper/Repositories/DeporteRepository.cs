using BlazorDeportes.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDeportes.Data.Dapper.Repositories
{
    public class DeporteRepository : IDeporteRepository
    {
        private string ConnectionString;
        public DeporteRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
        public Task<IEnumerable<Deporte>> GetAllDeportes()
        {
            throw new NotImplementedException();
        }
        public Task<Deporte> GetDeporteDetails(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> InsertDeporte(Deporte deporte)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Deportes (Name, NumJugadores)
                        VALUES (@Name, @NumJugadores)";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { deporte.Name, deporte.NumJugadores });
            return result > 0;
        }
        public Task<bool> UpdateDeporte(Deporte deporte)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteDeporte(int id)
        {
            throw new NotImplementedException();
        }

    }
}
