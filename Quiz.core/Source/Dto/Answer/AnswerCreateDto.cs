using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Dto.Answer
{
    public class AnswerCreateDto
    {
        public AnswerCreateDto(int questionId, string description)
        {
            QuestionId = questionId;
            Description = description;
        }

        public int QuestionId { get; protected set; }
        public string Description { get; protected set; }
    }
    public class AnswerUpdateDto : AnswerCreateDto
    {
        public int Id { get; protected set; }
        public AnswerUpdateDto(int id,int questionId, string description) : base(questionId, description)
        {
            Id = id;
        }
    }
}
