using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WindsorLagerLibrary.Models;

namespace WindsorUI.Models
{
    public class DisplayLagerModel : ILagerModel
    {
        public int ID { get; set; }
        [Required]   
        public string VareNummer { get; set; }
        public String VareTekst { get; set; }
        public double Maengde { get; set; }
        public string Enhed { get; set; }
        public decimal IndkobsPris { get; set; }
        public DateTime OprDT { get; set; }
    }
}
