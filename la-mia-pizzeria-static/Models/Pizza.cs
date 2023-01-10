namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Nome{ get; set; }
        public string Foto { get; set; }
        public string Descrizione { get; set; }
        public string Prezzo { get; set; }

        public Pizza(int id, string nome, string foto, string descrizione, string prezzo)
        {
            ID = id; 
            Nome = nome;
            Foto = foto;
            Descrizione = descrizione;
            Prezzo = prezzo;
        }
    }
}
