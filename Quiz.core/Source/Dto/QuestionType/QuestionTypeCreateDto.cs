using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Dto.QuestionType
{
    public class QuestionTypeCreateDto
    {
        public QuestionTypeCreateDto(string title)
        {
            Title = title;
        }

        public string Title { get; protected set; }
    }
    public class QuestionTypeUpdateDto : QuestionTypeCreateDto
    {
        public int Id { get; protected set; }
        public QuestionTypeUpdateDto(int id, string title) : base(title)
        {
            Id = id;
        }
    }
}
