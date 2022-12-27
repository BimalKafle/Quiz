using Quiz.core.Source.Dto.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Services
{
    public interface QuestionServiceInterface
    {
        Task Create(QuestionCreateDto dto);
        Task Update(QuestionUpdateDto dto);
        Task Remove(int id);
    }
}
