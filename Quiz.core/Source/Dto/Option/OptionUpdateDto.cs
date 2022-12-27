using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Dto.Option
{
    public class OptionUpdateDto : OptionCreateDto
    {
        public int Id { get; set; }
        public OptionUpdateDto(int id,string description) : base(description)
        {
            Id = id;
        }
    }
}
