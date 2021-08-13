using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WindsorLagerLibrary.Models;

namespace WindsorUI.Models
{
    public class DisplayKunder : IKunder
    {
        public int Id { get; set; }
        [Required]
        public string KundeID { get; set; }
        [Required]
        public string Firmanavn { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string Bynavn { get; set; }

    }
}
