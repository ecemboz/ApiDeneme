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
    public class EfStuffDal:GenericRespository<Staff>,IStaffDal
    {
        public EfStuffDal(Context context):base(context) 
        {
            
        }
    }
}
