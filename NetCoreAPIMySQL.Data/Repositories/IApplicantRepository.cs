using NetCoreAPIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public interface IApplicantRepository
    {
        Task<IEnumerable<Applicant>> GetAllApplicants();
        Task<Applicant> GetApplicantsDetails(int id);
        Task<Applicant> GetApplicantByEmail(string email);
        Task<IEnumerable<Applicant>> InsertApplicant(Applicant applicant);
        Task<IEnumerable<Applicant>> UpdateApplicant(Applicant applicant);
        Task<IEnumerable<Applicant>> DeleteApplicant(Applicant applicant);
    }
}