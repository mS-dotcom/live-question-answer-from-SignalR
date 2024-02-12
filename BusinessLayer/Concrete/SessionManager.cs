using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class SessionManager:ISessionService
	{
        private readonly ISessionDal _sessionDal;
		public SessionManager(ISessionDal sessionDal)
		{
            _sessionDal = sessionDal;
		}

        public void TAdd(Session entity)
        {
            _sessionDal.Add(entity);
        }

        public void TDelete(Session entity)
        {
            _sessionDal.Delete(entity);
        }

        public Session TGetById(int id)
        {
            return _sessionDal.GetById(id);
        }

        public List<Session> TGetListAll()
        {
            return _sessionDal.GetListAll();
        }

        public void TUpdate(Session entity)
        {
            _sessionDal.Update(entity);
        }
    }
}

