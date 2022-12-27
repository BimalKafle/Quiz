using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Entity
{
    public class QuestionType
    {
        public readonly string StatusActive = "Active";
        public readonly string StatusInactive = "Inactive";

        public QuestionType(string title)
        {
            Title = title;
            Status = StatusActive;
        }

        public virtual int Id { get; protected set; }
        public virtual string Title { get; protected set; } 
        public virtual string Status { get; protected set; }
        public IList<Question> Questions = new List<Question>();
        public void Activate()
        {
            Status = StatusActive;
        }
        public void DeActivate()
        {
            Status = StatusInactive;
        }

        public bool IsActive()
        {
            return Status == StatusActive;
        }
    }
}
