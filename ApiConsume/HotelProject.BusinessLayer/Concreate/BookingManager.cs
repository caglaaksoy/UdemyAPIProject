using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Migrations;
using HotelProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concreate
{
    public class BookingManager : IBookingService
    {
        private readonly IBokkingDal _bokkingDal;

        public BookingManager(IBokkingDal bokkingDal)
        {
            _bokkingDal = bokkingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bokkingDal.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _bokkingDal.BookingStatusChangeApproved2(id);
        }

        public void TBookingStatusChangeApproved3(int id)
        {
            _bokkingDal.BookingStatusChangeApproved3(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bokkingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
            _bokkingDal.BookingStatusChangeWait(id);
        }

        public void TDelete(Booking t)
        {
            _bokkingDal.Delete(t);
        }

        public int TGetBookingCount()
        {
            return _bokkingDal.GetBookingCount();
        }

        public Booking TGetByID(int id)
        {
           return _bokkingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
           return _bokkingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _bokkingDal.Insert(t);
        }

        public List<Booking> TLast6Bookings()
        {
            return _bokkingDal.Last6Bookings();
        }

        public void TUpdate(Booking t)
        {
            _bokkingDal.Update(t);
        }
    }
}
