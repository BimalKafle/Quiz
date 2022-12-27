using Quiz.core.Source.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Services
{
    public interface UserServiceInterface
    {
        Task Create(UserDto dto);
    }
}
