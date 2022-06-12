using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Test.Services
{

    public class AlbumDBService : IAlbumDbService
    {
        private readonly IConfiguration _configuration;
        public AlbumDBService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> DoesAlbumExists(int IdAlbum)
        {
            using SqlConnection connection = new(_configuration.GetConnectionString("DefaultDatabaseConnection"));
            SqlCommand sqlCommand = new(
                            "SELECT 1 FROM Album WHERE IdAlbum = @IdAlbum",
                            connection
                        );
            using SqlCommand command = sqlCommand;

            command.Parameters.AddWithValue("@IdAlbum", IdAlbum);

            await connection.OpenAsync();

            try
            {
                using SqlDataReader reader = await command.ExecuteReaderAsync();

                return reader.HasRows;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<bool> GetAlbums(int IdAlbum)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetAlbums()
        {
            throw new NotImplementedException();
        }
    }

}

