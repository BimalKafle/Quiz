using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Exceptions
{
    public class DuplicateUserNameException : Exception
    {
        public DuplicateUserNameException(string? message = "Duplicate UserName.") : base(message)
        {
        }
    }
}
