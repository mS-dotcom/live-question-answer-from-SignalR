using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class LessonAndExamManager:ILessonAndExamService
	{
        private readonly ILessonAndExamDal _lessonAndExamDal;
		public LessonAndExamManager(ILessonAndExamDal lessonAndExamDal)
		{
            _lessonAndExamDal = lessonAndExamDal;
		}
        public void TAdd(LessonAndExam entity)
        {
            _lessonAndExamDal.Add(entity);
        }

        public void TDelete(LessonAndExam entity)
        {
            _lessonAndExamDal.Delete(entity);
        }

        public LessonAndExam TGetById(int id)
        {
            return _lessonAndExamDal.GetById(id);
        }

        public List<LessonAndExam> TGetListAll()
        {
            return _lessonAndExamDal.GetListAll();
        }

        public void TUpdate(LessonAndExam entity)
        {
            _lessonAndExamDal.Update(entity);
        }
    }
}