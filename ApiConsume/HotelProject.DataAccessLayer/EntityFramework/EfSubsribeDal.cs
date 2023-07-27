using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concreate;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfSubsribeDal:GenericRepository<Subscribe>,ISubsribeDal
    {
        public EfSubsribeDal(Context context):base(context)
        {
            
        }
    }
}
