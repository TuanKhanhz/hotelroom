using Model.FE;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class OrderDao
    {
        StartHotellDBcontext db = null;

        public OrderDao()
        {
            db = new StartHotellDBcontext();
        }

        public List<Book> getListAllPaging()
        {
            return db.Books.ToList();
        }
        public bool Delete(int id)
        {
            var order = db.Books.Find(id);
            db.Books.Remove(order);
            db.SaveChanges();
            return true;
        }
    }
}
