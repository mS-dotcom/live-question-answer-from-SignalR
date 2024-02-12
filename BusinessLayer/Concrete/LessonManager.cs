using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
namespace BusinessLayer.Concrete
{
	public class LessonManager:ILessonService
	{
        private readonly ILessonDal _lessonDal;
		public LessonManager(ILessonDal lessonDal)
		{
            _lessonDal = lessonDal;
		}
        public void TAdd(Lesson entity)
        {
            _lessonDal.Add(entity);
        }

        public void TDelete(Lesson entity)
        {
            _lessonDal.Delete(entity);
        }

        public Lesson TGetById(int id)
        {
            return _lessonDal.GetById(id);
        }

        public List<Lesson> TGetListAll()
        {
            return _lessonDal.GetListAll();
        }

        public void TUpdate(Lesson entity)
        {
            _lessonDal.Update(entity);
        }
    }
}

