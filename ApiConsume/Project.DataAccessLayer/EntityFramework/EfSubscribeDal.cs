using Project.DataAccessLayer.Abstract;
using Project.DataAccessLayer.Concrete;
using Project.DataAccessLayer.Respositories;
using Project.EntityLayer.Concrete;
using Project.DataAccessLayer.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal:GenericRespository<Subscribe>,ISubscribeDal
    {
        public EfSubscribeDal(Context context):base(context) 
        {

        }
    }
}
