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
        Task OpretSalgsOrdre(ILagerSalgModel linier);
        Task<ILagerModel> HentVarenummer(string vn);
        Task<List<ILagerSalgModel>> HentOrdreData();
        Task OpretOrdreNummer(IOrdreModel ordrenummer);
        Task<IOrdreModel> HentOrdrenummer(int id);
        Task OpdaterOrdreNummer(IOrdreModel ordrenr);
        Task OpdaterLagerSalgsOrdre(ILagerSalgModel ol);
        Task<ILagerSalgModel> HenteenOrdreData(int id);
        Task SletSalgsordre(int id);
        Task OpretKunde(IKunder adr);
        Task<List<IKunder>> HentKundeData();
        Task<IKunder> HentEenKunde(int id);
        Task OpdaterKunde(IKunder kunde);
        Task SletKunde(int id);
    }
}