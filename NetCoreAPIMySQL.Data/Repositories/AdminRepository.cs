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
    public class AdminRepository : IAdminRepository
    {
        private MySQLConfiguration _connectionString;
        public AdminRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<Admin>> GetAllAdmins()
        {
            var db = dbConnection();

            //var sql = @"SELECT applicantID, first_name FROM applicant;";
            var sql = @"SELECT adminid, adminName, adminLastName, adminPassword, adminEmail FROM administrador";

            return await db.QueryAsync<Admin>(sql, new { });
        }

        public async Task<IEnumerable<Admin>> GetAdminsDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Admin>> InsertAdmins(Admin admin)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Admin>> UpdateAdmins(Admin admin)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Admin>> DeleteAdmins(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
