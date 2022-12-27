using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Entity
{
    public  class Option
    {
        public Option(string description)
        {
            Description = description;
        }

        public virtual int Id { get;protected set; }
        public virtual string Description { get; protected set; }
    }
}
