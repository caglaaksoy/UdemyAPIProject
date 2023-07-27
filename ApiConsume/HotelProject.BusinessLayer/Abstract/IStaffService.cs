using HotelProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IStaffService:IGenericServise<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLast4Staff();
    }
}
