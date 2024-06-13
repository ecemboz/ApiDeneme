using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Abstract
{
    public interface IBookingDal: IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);
        void BookingStatusChangeApproved3(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
    }
}
