using System.Collections.Generic;
using System.Threading.Tasks;
using WindsorLagerLibrary.Models;

namespace WindsorLagerLibrary.Data
{
    public interface ILagerSqlService
    {
        Task OpretVareNummer(ILagerModel produkt);
        Task<List<ILagerModel>> HentLagerData();
        Task<ILagerModel> HentETProdukt(int id);
        Task OpdaterProdukt(ILagerModel produkt);
        Task SletProdukt(int id);

    }
}