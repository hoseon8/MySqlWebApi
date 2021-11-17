using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace MySqlWebApi.Models
{
    [Table("GLB_UF")]
    public class Uf
    {
        [Key]
        public int Id { get; set; }
        public int Id_GLB_Pais { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sigla { get; set; } = string.Empty;
        public Pais? Pais { get; set; }
        public ICollection<Cidade>? Cidades { get; set; }
    }
}
