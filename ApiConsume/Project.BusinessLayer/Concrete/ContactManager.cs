using Project.BusinessLayer.Abstract;
using Project.DataAccessLayer.Abstract;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TDelete(Contact t)
		{
			throw new NotImplementedException();
		}

		public Contact TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TInsert(Contact t)
		{
			_contactDal.Insert(t);
		}

		public void TUpdate(Contact t)
		{
			throw new NotImplementedException();
		}
	}
}
