using System;
using System.Collections.Generic;
using System.Text;

namespace WindsorLagerLibrary.Models
{
    public class LagerSalgModel : ILagerSalgModel
    {
        public int ID { get; set; }
        public string KundeID { get; set; }  // Hent Kunde adresse fra database
        public int OrdreNummer { get; set; }  //
        public decimal LinieTotal { get; set; }
        public decimal Moms { get; set; }
        public decimal FakturaTotal { get; set; }
        public string Betalingsfrist { get; set; } // dage eller mdr
        public string FakturaTekst { get; set; }
        public double IndkoebMaengde { get; set; }
        public string VareNummer { get; set; }
        public decimal IndkobsPris { get; set; }
        public DateTime OrdreOprettet { get; set; }

        /*
         * KundeID,OrdreNummer,LinieTotal,Moms,FakturaTotal,BetalingsFrist,FakturaTekst,IndkoebMaengde,VareNummer,IndkobsPris,OrdreOprettet
         */


    }
}
