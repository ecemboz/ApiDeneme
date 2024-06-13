using Project.DataAccessLayer.Abstract;
using Project.DataAccessLayer.Concrete;
using Project.DataAccessLayer.Respositories;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRespository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved3(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Müşteri Aranacak";
            context.SaveChanges();
        }
    }
}
