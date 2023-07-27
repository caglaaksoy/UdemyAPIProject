using HotelProject.EntityLayer.Concreate;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IContactService :IGenericServise<Contact>
    {
        public int TGetContactCount();
    }
}
