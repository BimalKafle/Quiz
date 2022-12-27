using Quiz.core.Source.Dto.QuestionType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Services
{
    public interface QuestionTypeServiceInterface
    {
        Task Create(QuestionTypeCreateDto dto);
        Task Update(QuestionTypeUpdateDto dto);
        Task Activate(int id);
        Task Deactivate(int id);
    }
}
