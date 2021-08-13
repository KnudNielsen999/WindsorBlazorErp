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
            await _dataAccess.SaveData("dbo.spLager_OpdaterProdukt", produkt, "WindsorSQLBase");
        }

        public async Task SletProdukt(int id)
        {
            await _dataAccess.SaveData("dbo.spLager_DeleteProdukt", new { Id = id }, "WindsorSQLBase");
        }

        public async Task OpretSalgsOrdre(ILagerSalgModel linier)
        {
            var p = new
            {   
                linier.KundeID,
                linier.OrdreNummer,
                linier.LinieTotal,           
                linier.Moms,
                linier.FakturaTotal, 
                linier.Betalingsfrist,
                linier.FakturaTekst,
                linier.IndkoebMaengde,
                linier.VareNummer,
                linier.IndkobsPris,               
                linier.OrdreOprettet
            };
           


            await _dataAccess.SaveData("dbo.spSalgs_OpretOrdre", p, "WindsorSQLBase");
        }


        public async Task<ILagerModel> HentVarenummer(string vareNummer)
        {
            var produkt = await _dataAccess.LoadData<LagerModel, dynamic>("dbo.spLager_HentVarenummer",
                                                                           new { VareNummer = vareNummer },
                                                                           "WindsorSQLBase");


            return produkt.FirstOrDefault();
        }

        public async Task<List<ILagerSalgModel>> HentOrdreData()
        {
            var linier = await _dataAccess.LoadData<LagerSalgModel, dynamic>("dbo.spHent_SalgsOrdre",
                                                                           new { },
                                                                           "WindsorSQLBase");
           


            return linier.ToList<ILagerSalgModel>();
        }

        public async Task<ILagerSalgModel> HenteenOrdreData(int id)
        {
            var linie = await _dataAccess.LoadData<LagerSalgModel, dynamic>("dbo.spHent_eenSalgsOrdre",
                                                                           new { Id = id },
                                                                           "WindsorSQLBase");



            return linie.FirstOrDefault();
        }

        public async Task OpretOrdreNummer(IOrdreModel ordrenummer)
        {
           
            var p = new
            {
                ordrenummer.Ordrenummer
            };
        await _dataAccess.SaveData("dbo.spOpretSalgsOrdre", p, "WindsorSQLBase");

    }


        public async Task<IOrdreModel> HentOrdrenummer(int id)
        {
            var ordrenummer = await _dataAccess.LoadData<OrdreModel, dynamic>("dbo.spHent_Salgsordrenummer",
                                                                           new { Id=id },
                                                                           "WindsorSQLBase");


            return ordrenummer.FirstOrDefault();
        }


        public async Task OpdaterOrdreNummer(IOrdreModel ordrenr)
        {

           
            await _dataAccess.SaveData("dbo.spOpdater_salgsOrdreNummer", ordrenr, "WindsorSQLBase");

        }

        public async Task OpdaterLagerSalgsOrdre(ILagerSalgModel ol )
        {
            await _dataAccess.SaveData("dbo.spLager_UpdateOrdre", ol, "WindsorSQLBase");
        }

        public async Task SletSalgsordre(int id)
        {
            await _dataAccess.SaveData("dbo.spSlet_SalgsOrdre", new { Id = id }, "WindsorSQLBase");
        }


        public async Task OpretKunde(IKunder adr)
        {
            var a = new
            {
                adr.KundeID,
                adr.Firmanavn,
                adr.Adresse,
                adr.Bynavn
            };



            await _dataAccess.SaveData("dbo.spOpretkunder", a, "WindsorSQLBase");
        }

        public async Task<List<IKunder>> HentKundeData()
        {
            var Kunder = await _dataAccess.LoadData<Kunder, dynamic>("dbo.spKunder_hentkunder",
                                                                           new { },
                                                                           "WindsorSQLBase");

            return Kunder.ToList<IKunder>();
        }

        public async Task<IKunder> HentEenKunde(int id)
        {
            var Kunde = await _dataAccess.LoadData<Kunder, dynamic>("dbo.spKunde_HentEenKunde",
                                                                           new { Id = id },
                                                                           "WindsorSQLBase");

            return Kunde.FirstOrDefault();
        }


        public async Task OpdaterKunde(IKunder kunde)
        {
            await _dataAccess.SaveData("dbo.spKunder_update", kunde , "WindsorSQLBase");
        }


        public async Task SletKunde(int id)
        {
            await _dataAccess.SaveData("dbo.spSlet_Kunde", new { Id = id }, "WindsorSQLBase");
        }
    }
}
