using NetCoreAPIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Data.Repositories
{
    public interface IGameRepository
    {
        Task<bool> InsertGameTry(int appid, int appscore, int vacancyid);
        Task<IEnumerable<Game>> UpdateGameTry(Game gamer);
    }
}
