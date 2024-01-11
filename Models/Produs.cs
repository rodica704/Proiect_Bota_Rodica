namespace Proiect_Bota_Rodica.Models
{
    public class Produs
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public decimal Pret { get; set; }
        public DateTime DataCreare { get; set; }
        public string Descriere { get; set; }
        public int? ClientID { get; set; }
        public Client? Clienti { get; set; } } //navigation property
    }


