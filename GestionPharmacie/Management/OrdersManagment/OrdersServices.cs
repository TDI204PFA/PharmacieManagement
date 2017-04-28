using GestionPharmacie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Management.OrdersManagment
{
    public class OrdersServices
    {
        public Model_GestionPharmacie Db = new Model_GestionPharmacie();

        public bool Add(Order order)
        {
            Db.Orders.Add(order);
            return Db.SaveChanges() > 0;
        }

        public bool Update(Order order)
        {
            Order Origine = Db.Orders.Find(order.NumCmd);
            if (Origine != null)
            {
                Db.Entry(Origine).CurrentValues.SetValues(order);
                return Db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Order> OrdersList()
        {
            var query = from order in Db.Orders select order;
            return query.ToList();
        }

        public bool Delete(int id)
        {
            Db.Orders.Remove(Db.Orders.Find(id));
            return Db.SaveChanges() > 0;
        }

        public Order FindExisted(int id)
        {
            Order order = Db.Orders.Find(id);
            Db.Entry(order).State = System.Data.Entity.EntityState.Modified;
            return order;
        }
    }
}
