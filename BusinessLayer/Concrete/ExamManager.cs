using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class ExamManager:IExamService
	{
        private readonly IExamDal _examDal;
		public ExamManager(IExamDal examDal)
		{
            _examDal = examDal;
		}

        public void TAdd(Exam entity)
        {
            _examDal.Add(entity);
        }

        public void TDelete(Exam entity)
        {
            _examDal.Delete(entity);
        }

        public Exam TGetById(int id)
        {
           return _examDal.GetById(id);
        }

        public List<Exam> TGetListAll()
        {
            return _examDal.GetListAll();
        }

        public void TUpdate(Exam entity)
        {
            _examDal.Update(entity);
        }
    }
}

