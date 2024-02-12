using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class GeneralPointManager:IGeneralPointService
	{
        private readonly IGeneralPointDal _generalPointDal;
		public GeneralPointManager(IGeneralPointDal generalPointDal)
		{
            _generalPointDal = generalPointDal;
		}

        public void TAdd(GeneralPoint entity)
        {
            _generalPointDal.Add(entity);
        }

        public void TDelete(GeneralPoint entity)
        {
            _generalPointDal.Delete(entity);
        }

        public GeneralPoint TGetById(int id)
        {
            return _generalPointDal.GetById(id);
        }

        public List<GeneralPoint> TGetListAll()
        {
            return _generalPointDal.GetListAll();
        }

        public void TUpdate(GeneralPoint entity)
        {
            _generalPointDal.Update(entity);
        }
    }
}
