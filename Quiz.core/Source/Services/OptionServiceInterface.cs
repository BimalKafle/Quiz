using Quiz.core.Source.Dto.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Services
{
    public interface OptionServiceInterface
    {
        Task Create(OptionCreateDto dto);
        Task Update(OptionUpdateDto dto);
        Task Remove(int id);
    }
}
