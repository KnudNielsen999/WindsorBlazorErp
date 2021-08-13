namespace WindsorLagerLibrary.Models
{
    public interface IKunder
        {
            int Id { get; set; }
            string KundeID { get; set; }
            string Firmanavn { get; set; }
            string Adresse { get; set; }
             string Bynavn { get; set; }
        }
}