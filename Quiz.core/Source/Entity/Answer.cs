using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Entity
{
    public class Answer
    {
        protected Answer()
        {
        }

        public Answer(string description,Question question)
        {
            Question = question;
            Description = description;
        }

        public virtual int Id { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual Question Question { get; protected set; }
        public virtual int QuestionId { get; protected set; }
    }
}
