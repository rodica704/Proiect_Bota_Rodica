namespace Proiect_Bota_Rodica.Models
{
    public class Distribuitor
    {
        public int ID { get; set; }
        public string NumeDistribuitor { get; set; }
        public int Telefon {  get; set; }
        public string Email { get; set; }
        public ICollection<Distribuitor> Distribuitori { get; set;} //navigation property
    }
}
