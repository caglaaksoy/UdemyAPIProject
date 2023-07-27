using HotelProject.EntityLayer.Concreate;
using System.Collections.Generic;

namespace HotelProject.WebUI.Dtos.MessageCategoryDto
{
    public class ResultMessageCategoryDto
    {
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
