using GestionPharmacie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPharmacie.Management.ProviderManagment
{
    public class ProviderServices
    {
        public Model_GestionPharmacie Db = new Model_GestionPharmacie();

        public bool Add(Provider provider)
        {
            Db.Provider.Add(provider);
            return Db.SaveChanges() > 0;
        }

        public bool Update(Provider provider)
        {
            Provider Origine = Db.Provider.Find(provider.ProviderID);
            if (Origine != null)
            {
                Db.Entry(Origine).CurrentValues.SetValues(provider);
                return Db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Provider> ProvidersList()
        {
            var query = from provider in Db.Provider select provider;
            return query.ToList();
        }

        public bool Delete(int id)
        {
            Db.Provider.Remove(Db.Provider.Find(id));
            return Db.SaveChanges() > 0;
        }

        public Provider FindExisted(int id)
        {
            Provider provider = Db.Provider.Find(id);
            Db.Entry(provider).State = System.Data.Entity.EntityState.Modified;
            return provider;
        }
    }
}
