using HotelProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IAppUserService :IGenericServise<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
        List<AppUser> TUsersListWithWorkLocations();
        int TAppUserCount();
    }
}
