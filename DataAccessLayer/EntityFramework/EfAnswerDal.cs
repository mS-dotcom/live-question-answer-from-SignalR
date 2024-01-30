using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
	public class EfAnswerDal:GenericRepository<Answer>,IAnswerDal
	{
		public EfAnswerDal(RingteyimContext context) : base(context)
        {

		}
	}
}

