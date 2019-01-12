using System.Collections.Generic;
using BalanceWebApp.Model.Domain;

namespace BalanceWebApp.Model.Dao
{
    public interface IProviderDao
    {
        List<Provider> GetAll();
        List<Provider> GetByCountry(string country);
        Provider GetById(long id);
        Provider FindProvider(string name, string country);
        long New(string name, string country);
        int Delete(long id);
        Provider Update(Provider provider);
    }
}