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
    public class ApplicantRepository : IApplicantRepository
    {
        private MySQLConfiguration _connectionString;
        public ApplicantRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public async Task<IEnumerable<Applicant>> GetAllApplicants()
        {
            var db = dbConnection();

            //var sql = @"SELECT applicantID, first_name FROM applicant"; 
            var sql = @"SELECT applicantID, first_name, last_names, dateOfBirth, email, photo FROM applicant";

            return await db.QueryAsync<Applicant>(sql, new { });
        }

        public Task<IEnumerable<Applicant>> DeleteApplicant(Applicant applicant)
        {
            throw new NotImplementedException();
        }

        public async Task<Applicant> GetApplicantsDetails(int id)
        {
            var db = dbConnection();

            //var sql = @"SELECT applicantID, first_name FROM applicant"; 
            var sql = @"
                        SELECT applicantID, first_name, last_names, dateOfBirth, email, photo
                        FROM applicant
                        WHERE applicantID = @Id";

            return await db.QueryFirstOrDefaultAsync<Applicant>(sql, new { Id = id });
        }

        public Task<IEnumerable<Applicant>> InsertApplicant(Applicant applicant)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Applicant>> UpdateApplicant(Applicant applicant)
        {
            throw new NotImplementedException();
        }

        public async Task<Applicant> GetApplicantByEmail(string megam1)
        {
            var db = dbConnection();

            //var sql = @"SELECT applicantID, first_name FROM applicant"; 
            var sql = @"
                       SELECT applicantID, first_name, last_names, dateOfBirth, email, photo
                       FROM applicant
                       WHERE email = @Megam1";

            return await db.QueryFirstOrDefaultAsync<Applicant>(sql, new { Megam1 = megam1 });
        }
    }
}
