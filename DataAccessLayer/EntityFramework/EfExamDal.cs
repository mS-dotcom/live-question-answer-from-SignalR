using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
	public class EfExamDal:GenericRepository<Exam>,IExamDal
	{
		public EfExamDal(RingteyimContext context) : base(context)
        {
		}
	}
}

