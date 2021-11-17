using Dapper.Contrib.Extensions;

namespace MySqlWebApi.Models
{
    [Table("GLB_Cidade")]
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        public int Id_GLB_UF { get; set; }
        public string Nome { get; set; } = string.Empty;
        public Uf Uf { get; set; } = new Uf();
    }
}
