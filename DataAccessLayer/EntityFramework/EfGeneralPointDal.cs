using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;

namespace DataAccessLayer.EntityFramework
{
	public class EfGeneralPointDal:GenericRepository<GeneralPoint>,IGeneralPointDal
	{
		public EfGeneralPointDal(RingteyimContext context) : base(context)
        {
		}
	}
}

