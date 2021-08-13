using System;

namespace WindsorLagerLibrary.Models
{
    public interface ILagerSalgModel
    {
         int ID { get; set; }
         string KundeID { get; set; }  // Hent Kunde adresse fra database
         int OrdreNummer { get; set; }  //
         decimal LinieTotal { get; set; }
         decimal Moms { get; set; }
         decimal FakturaTotal { get; set; }
         string Betalingsfrist { get; set; } // dage eller mdr
         string FakturaTekst { get; set; }
         double IndkoebMaengde { get; set; }
         string VareNummer { get; set; }
         decimal IndkobsPris { get; set; }
         DateTime OrdreOprettet { get; set; }

    }
}