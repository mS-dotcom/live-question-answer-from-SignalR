using System;
using BusinessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class SessionManager:ISessionService
	{
		public SessionManager()
		{
		}

        public void TAdd(Session entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Session entity)
        {
            throw new NotImplementedException();
        }

        public Session TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Session> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Session entity)
        {
            throw new NotImplementedException();
        }
    }
}

