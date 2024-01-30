using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class AnswerManager:IAnswerService
	{
        private readonly IAnswerDal _aboutDal;
		public AnswerManager(IAnswerDal answerDal)
		{
            _aboutDal = answerDal;
		}

        public void TAdd(Answer entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(Answer entity)
        {
            _aboutDal.Delete(entity);
        }

        public Answer TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<Answer> TGetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public void TUpdate(Answer entity)
        {
            _aboutDal.Update(entity);
        }
    }
}

