using Project.BusinessLayer.Abstact;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);
        void TBookingStatusChangeApproved2(int id);
        void TBookingStatusChangeApproved3(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);
    }
}
