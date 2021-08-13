using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WindsorLagerLibrary.Models;

namespace WindsorUI.Models
{
    public class DisplayOrdreSalgModel : ILagerSalgModel
    {
        public int ID { get ; set ; }
        [Required (ErrorMessage ="Indtast venligst et telefon nummer")]
        public string KundeID { get; set; }
        public int OrdreNummer { get; set; }
        public decimal LinieTotal { get; set; }
        public decimal Moms { get; set; }
        public decimal FakturaTotal { get; set; }
        public string Betalingsfrist { get; set; }
        public string FakturaTekst { get; set; }
        [Required(ErrorMessage ="Indtast mængde")]
        public double IndkoebMaengde { get; set; }
        [Required(ErrorMessage = "Varenummer kræves")]
        public string VareNummer { get; set; }
        [Required(ErrorMessage = "Indtast en værdi")]
        public decimal IndkobsPris { get; set; }
        public DateTime OrdreOprettet { get; set; }
    }
}
