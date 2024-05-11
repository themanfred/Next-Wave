using Dapper;
using MySql.Data.MySqlClient;
using NetCoreAPIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public class GameRepository : IGameRepository
    {
        private MySQLConfiguration _connectionString;
        public GameRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> InsertGameTry(/*Game gamer*/int id, int score, int vacancy)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO game (applicantID2, game_score, vacancy_option) VALUES (@Id, @Score, @Vacancy)";

            var result = await db.ExecuteAsync(sql, new { /*gamer.Applicantid2, gamer.Game_score, gamer.Vacancy_option*/ Id = id, Score = score, Vacancy = vacancy });

            return result > 0;

        }

        public Task<IEnumerable<Game>> UpdateGameTry(Game gamer)
        {
            throw new NotImplementedException();
        }
    }
}
