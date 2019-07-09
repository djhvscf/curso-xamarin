using SQLite;

namespace AgendaContacto.Model
{
    [Table("ContactoInfo")]
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Nombre { get; set; }

        [Column("Tel")]
        public string Telefono { get; set; }

        [Ignore]
        public string Direccion { get; set; }
    }
}
