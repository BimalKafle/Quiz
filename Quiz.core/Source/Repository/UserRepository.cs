using Microsoft.EntityFrameworkCore;
using Quiz.core.Base;
using Quiz.core.DbContextConfig;
using Quiz.core.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Repository
{
    public class UserRepository : BaseRepository<ApplicationUser>, UserRepositoryInterface
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<ApplicationUser?> GetByIdString(string id)
        {
            return await GetQueryable().Where(a => a.Id == id).SingleOrDefaultAsync().ConfigureAwait(false);
        }
    }
}
