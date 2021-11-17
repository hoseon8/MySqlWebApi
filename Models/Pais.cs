using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace MySqlWebApi.Models
{
    [Table("GLB_Pais")]
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public ICollection<Uf>? Ufs { get; set; }
    }
}