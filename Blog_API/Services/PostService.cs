using Blog_API.Models;
using Dapper;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;
using System.Data;

namespace Blog_API.Services
{
    public class PostService
    {
        private IConfiguration _configuration;

        public PostService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<PostModel>> GetAll()
        {
            IEnumerable<PostModel> _postList;
            string connectionString = _configuration["Blog:ConnectionString"];
            string procedure = "Select_Posts";

            using (var connection = new MySqlConnection(connectionString))
            {
                _postList = await connection.QueryAsync<PostModel>(procedure, commandType: CommandType.StoredProcedure);
            }

            return _postList;
        }
    }
}
