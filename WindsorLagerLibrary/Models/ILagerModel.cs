using System;
using System.ComponentModel.DataAnnotations;

namespace WindsorLagerLibrary.Models
{
    public interface ILagerModel
    {
         int ID { get; set; }
        
        string VareNummer { get; set; }
        string VareTekst { get; set; }
         double Maengde { get; set; }
         string Enhed { get; set; }
         decimal IndkobsPris { get; set; }

         DateTime OprDT { get; set; }
    }
}