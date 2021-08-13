using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WindsorLagerLibrary.Models;

namespace WindsorUI.Models
{
    public class DisplayLagerSalgModel : ILagerSalgModel
    {
        public int ID { get; set; }
        [Required]
        public string KundeID { get; set; }  
        public int OrdreNummer { get; set; }  
        public decimal LinieTotal { get; set; }
        public decimal Moms { get; set; }
        public decimal FakturaTotal { get; set; }
        public string Betalingsfrist { get; set; } 
        public string FakturaTekst { get; set; }
        public double IndkoebMaengde { get; set; }
        public string VareNummer { get; set; }
        public decimal IndkobsPris { get; set; }
        public DateTime OrdreOprettet { get; set; }
    }
}
