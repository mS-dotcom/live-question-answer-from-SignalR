using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfSessionDal : GenericRepository<Session>, ISessionDal
    {
        public EfSessionDal(RingteyimContext context) : base(context)
        {
        }
    }
}

