using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WindsorLagerLibrary.Models
{
    public class LagerModel : ILagerModel
    {
        public int ID { get; set; }
       
        public string VareNummer { get; set; }
        public String VareTekst { get; set; }
        public double Maengde { get; set; }
        public string Enhed { get; set; }
        public decimal IndkobsPris { get; set; }

        public DateTime OprDT { get; set; }
    }
}
