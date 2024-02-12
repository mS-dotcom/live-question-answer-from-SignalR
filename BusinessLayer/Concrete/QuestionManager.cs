using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class QuestionManager:IQuestionService
	{
        private readonly IQuestionDal _questionDal;
		public QuestionManager(IQuestionDal questionDal)
		{
            _questionDal = questionDal;
		}
        public void TAdd(Question entity)
        {
            _questionDal.Add(entity);
        }

        public void TDelete(Question entity)
        {
            _questionDal.Delete(entity);
        }

        public Question TGetById(int id)
        {
            return _questionDal.GetById(id);
        }

        public List<Question> TGetListAll()
        {
            return _questionDal.GetListAll();
        }

        public void TUpdate(Question entity)
        {
            _questionDal.Update(entity);
        }
    }
}