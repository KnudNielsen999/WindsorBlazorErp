using System;
using System.Collections.Generic;
using System.Text;

namespace WindsorLagerLibrary.Models
{
    public class OrdreModel : IOrdreModel
    {
        public int ID { get; set; }
        public int Ordrenummer { get; set; }
    }
}
