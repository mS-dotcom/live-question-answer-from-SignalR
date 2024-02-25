using System;
using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
	public interface IUserDal:IGenericDal<User>
	{
		User GetUser(int userId);
	}
}

