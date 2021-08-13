using System;
using System.Collections.Generic;
using System.Text;

namespace WindsorLagerLibrary.Models
{
    public class Kunder : IKunder
    {
        public int Id { get; set; }
        public string KundeID { get; set; }
        public string Firmanavn { get; set; }
        public string Adresse { get; set; }
        public string Bynavn { get; set; }

    }
}
