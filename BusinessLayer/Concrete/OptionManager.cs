using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
	public class OptionManager:IOptionService
	{
            private readonly IOptionDal _optionDal;
		public OptionManager(IOptionDal optionDal)
		{
            _optionDal = optionDal;
		}
        public void TAdd(Option entity)
        {
            _optionDal.Add(entity);
        }

        public void TDelete(Option entity)
        {
            _optionDal.Delete(entity);
        }

        public Option TGetById(int id)
        {
            return _optionDal.GetById(id);
        }

        public List<Option> TGetListAll()
        {
            return _optionDal.GetListAll();
        }

        public void TUpdate(Option entity)
        {
            _optionDal.Update(entity);
        }
    }
}

