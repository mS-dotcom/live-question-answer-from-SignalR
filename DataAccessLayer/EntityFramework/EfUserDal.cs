using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        private static readonly RingteyimContext _context;
        public EfUserDal(RingteyimContext context) : base(_context)
        {
            context = _context;
        }

        public User GetUser(int userId)
        {
            var user=_context.users.FirstOrDefault(x => x.UserId == userId);
            return user;
        }
    }
}

