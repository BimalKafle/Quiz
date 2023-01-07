using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Entity
{
    public  class Question
    {
        protected Question()
        {

        }
        public virtual int Id { get; protected set; }
        public virtual string Description { get; protected set; }

        public virtual QuestionType Type { get; protected set; }
        public virtual int QuestionTypeId { get; protected set; }

        public virtual Answer Answer { get; protected set; }
        public virtual int AnswerId { get; protected set; }

        public  IList<Option> Options = new List<Option>();

        public Question(string description, QuestionType type,Answer answer)
        {
            Description = description;
            Type = type;
           
            Answer = answer;
        }
    }
}
