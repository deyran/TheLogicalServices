using SQLite;

namespace IntellectusSecretaria.Areas.HorarioAula.MVVM.Models
{
    [Table("REG_PESSOAS")]
    public class Pessoas
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string? Nome { get; set; }
    }
}
