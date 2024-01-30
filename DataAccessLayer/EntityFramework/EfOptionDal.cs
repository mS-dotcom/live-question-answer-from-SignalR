using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfOptionDal : GenericRepository<Option>, IOptionDal
    {
        public EfOptionDal(RingteyimContext context) : base(context)
        {

        }
    }
}