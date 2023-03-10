using Quiz.core.Base;
using Quiz.core.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Repository
{
    public interface UserRepositoryInterface:BaseRepositoryInterface<ApplicationUser>
    {
        Task<ApplicationUser?> GetByIdString(string id);
    }
}
