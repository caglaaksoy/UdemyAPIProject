using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Concreate
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
            throw new System.NotImplementedException();
        }

        public Contact TGetByID(int id)
        {
           return _contactDal.GetByID(id);
        }

        public int TGetContactCount()
        {
           return _contactDal.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            throw new System.NotImplementedException();
        }
    }
}
