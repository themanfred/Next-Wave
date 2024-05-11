using NetCoreAPIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> GetAllAdmins();
        Task<IEnumerable<Admin>> GetAdminsDetails(int id);
        Task<IEnumerable<Admin>> InsertAdmins(Admin admin);
        Task<IEnumerable<Admin>> UpdateAdmins(Admin admin);
        Task<IEnumerable<Admin>> DeleteAdmins(Admin admin);
    }
}
