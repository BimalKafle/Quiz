using Quiz.core.Source.Dto.QuestionType;
using Quiz.core.Source.Entity;
using Quiz.core.Source.Exceptions;
using Quiz.core.Source.Helper;
using Quiz.core.Source.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Quiz.core.Source.Services
{
    public class QuestionTypeService : QuestionTypeServiceInterface
    {
        private readonly QuestionTypeRepositoryInterface _questionTypeRepositoryInterface;

        public QuestionTypeService(QuestionTypeRepositoryInterface questionTypeRepositoryInterface)
        {
            _questionTypeRepositoryInterface = questionTypeRepositoryInterface;
        }

        public async Task Activate(int id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var questionType = await _questionTypeRepositoryInterface.GetByIdAsync(id).ConfigureAwait(false) ?? throw new QuestionTypeNotFoundException();
            questionType.Activate();
            scope.Complete();
        }

        public async Task Create(QuestionTypeCreateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var questionType = new QuestionType(dto.Title);
            await _questionTypeRepositoryInterface.AddAsync(questionType);
            scope.Complete();
        }

        public async Task Deactivate(int id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var questionType = await _questionTypeRepositoryInterface.GetByIdAsync(id).ConfigureAwait(false) ?? throw new QuestionTypeNotFoundException();
            questionType.DeActivate();
            scope.Complete();
        }

        public Task Update(QuestionTypeUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
