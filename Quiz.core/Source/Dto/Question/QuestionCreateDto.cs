using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Dto.Question
{
    public class QuestionCreateDto
    {
        public QuestionCreateDto(int questionTypeId, int answerTypeId, string descripton)
        {
            QuestionTypeId = questionTypeId;
            AnswerTypeId = answerTypeId;
            Descripton = descripton;
        }

        public int QuestionTypeId { get; protected set; }
        public int AnswerTypeId { get; protected set; }
        public string Descripton { get; protected set; }
    }
    public class QuestionUpdateDto : QuestionCreateDto
    {
        public int Id { get; protected set; }
        public QuestionUpdateDto(int id, int questionTypeId, int answerTypeId, string descripton) : base(questionTypeId, answerTypeId, descripton)
        {
            Id = id;
        }
    }
}
