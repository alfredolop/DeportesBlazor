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
        public async Task<IEnumerable<Deporte>> GetAllDeportes()
        {
            var db = dbConnection();

            var sql = @"SELECT id, Name, NumJugadores FROM [dbo].[Deportes]";

            return await db.QueryAsync<Deporte>(sql.ToString(), new { });
        }
        public async Task<Deporte> GetDeporteDetails(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT id, Name, NumJugadores FROM [dbo].[Deportes] where id = @id";

            return await db.QueryFirstOrDefaultAsync<Deporte>(sql.ToString(), new { id = id });
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
        public async Task<bool> UpdateDeporte(Deporte deporte)
        {
            var db = dbConnection();

            var sql = @"UPDATE Deportes SET Name = @Name, NumJugadores = @NumJugadores where id = @id";

            var result = await db.ExecuteAsync(sql.ToString(), new { deporte.id, deporte.Name, deporte.NumJugadores });

            return result > 0;
        }
        public Task<bool> DeleteDeporte(int id)
        {
            throw new NotImplementedException();
        }

    }
}
