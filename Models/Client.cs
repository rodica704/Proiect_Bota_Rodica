namespace Proiect_Bota_Rodica.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string NumeClient { get; set; }
        public int NumarComanda { get; set; }
        public ICollection<Client> Clienti { get; set;} // navigation property
    }
}
