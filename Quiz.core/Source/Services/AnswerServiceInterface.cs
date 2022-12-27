using Quiz.core.Source.Dto.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Services
{
    public interface AnswerServiceInterface
    {
        Task Create(AnswerCreateDto dto);
        Task Update(AnswerUpdateDto dto);
        Task Remove(int id);
        
    }
}
