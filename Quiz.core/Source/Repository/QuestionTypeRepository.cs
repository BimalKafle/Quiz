using Quiz.core.Base;
using Quiz.core.DbContextConfig;
using Quiz.core.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Source.Repository
{
    public class QuestionTypeRepository : BaseRepository<QuestionType>, QuestionTypeRepositoryInterface
    {
        public QuestionTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
