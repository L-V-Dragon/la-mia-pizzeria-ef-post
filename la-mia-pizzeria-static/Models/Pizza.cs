using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int ID { get; set; }

		[Column(TypeName = "varchar(100)")]
		public string Nome{ get; set; }

		[Column(TypeName = "varchar(300)")]
		public string Foto { get; set; }

		[Column(TypeName = "text")]
		public string Descrizione { get; set; }

		[Column(TypeName = "varchar(10)")]
		public string Prezzo { get; set; }

        public Pizza()
        {

        }

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
