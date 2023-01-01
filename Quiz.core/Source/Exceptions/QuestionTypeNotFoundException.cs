using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Exceptions
{
    public class QuestionTypeNotFoundException : Exception
    {
        public QuestionTypeNotFoundException(string? message="Question type not found") : base(message)
        {
        }
    }
}
