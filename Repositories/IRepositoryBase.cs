using MySqlWebApi.Models;
using System.Collections.Generic;

namespace MySqlWebApi.Repositories
{
    internal interface IRepositoryBase
    {
        List<Cidade> SearchCidades(string nome);

        List<Uf> SearchUfs(string nome);

        List<Pais> SearchPaises(string nome);
    }
}
