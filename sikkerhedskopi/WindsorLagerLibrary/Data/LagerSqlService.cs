using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindsorLagerLibrary.DataAccess;
using WindsorLagerLibrary.Models;

namespace WindsorLagerLibrary.Data
{
    public class LagerSqlService : ILagerSqlService
    {
        private readonly ISqlDataAccess _dataAccess;
        public LagerSqlService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task OpretVareNummer(ILagerModel produkt)
        {
            var p = new
            {
                produkt.VareNummer,
                produkt.VareTekst,
                produkt.Maengde,
                produkt.Enhed,
                produkt.IndkobsPris, 
                produkt.OprDT,
            };
          

            await _dataAccess.SaveData("dbo.spLager_CreateProdukt", p, "WindsorSQLBase");
        }

        public async Task<List<ILagerModel>> HentLagerData()
        {
            var produkt = await _dataAccess.LoadData<LagerModel, dynamic>("dbo.spLager_HentproduktData",
                                                                           new { },
                                                                           "WindsorSQLBase");

            return produkt.ToList<ILagerModel>();
        }

        public async Task<ILagerModel> HentETProdukt(int id)
        {
            var produkt = await _dataAccess.LoadData<LagerModel, dynamic>("dbo.spLager_HentETProdukt",
                                                                           new { Id = id },
                                                                           "WindsorSQLBase");

            return produkt.FirstOrDefault();
        }

        public async Task OpdaterProdukt(ILagerModel produkt)
        {
            await _dataAccess.SaveData("dbo.spLager_UpdateProdukt", produkt, "WindsorSQLBase");
        }

        public async Task SletProdukt(int id)
        {
            await _dataAccess.SaveData("dbo.spLager_DeleteProdukt", new { Id = id }, "WindsorSQLBase");
        }
    }
}
