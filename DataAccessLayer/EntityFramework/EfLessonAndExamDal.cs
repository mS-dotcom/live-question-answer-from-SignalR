using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfLessonAndExamDal : GenericRepository<LessonAndExam>, ILessonAndExamDal
    {
        public EfLessonAndExamDal(RingteyimContext context) : base(context)
        {
        }
    }
}