using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    
    public class AnswerManager:IAnswerService
	{
        private readonly IAnswerDal _answerDal;

		public AnswerManager(IAnswerDal answerDal)
		{
            _answerDal = answerDal;
		}

        public void TAdd(Answer entity)
        {
            _answerDal.Add(entity);
        }

        public void TDelete(Answer entity)
        {
            _answerDal.Delete(entity);
        }

        public Answer TGetById(int id)
        {
            return _answerDal.GetById(id);
        }

        public List<Answer> TGetListAll()
        {
            return _answerDal.GetListAll();
        }

        public void TUpdate(Answer entity)
        {
            _answerDal.Update(entity);
        }
    }
}

