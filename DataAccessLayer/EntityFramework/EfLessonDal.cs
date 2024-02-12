using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfLessonDal : GenericRepository<Option>, IOptionDal
    {
        public EfLessonDal(RingteyimContext context) : base(context)
        {
        }
    }
}