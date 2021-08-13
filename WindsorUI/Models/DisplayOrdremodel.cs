using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindsorLagerLibrary.Models;

namespace WindsorUI.Models
{
    public class DisplayOrdremodel : IOrdreModel
    {
        public int ID { get ; set ; }
        public int Ordrenummer { get; set; }
    }
}
