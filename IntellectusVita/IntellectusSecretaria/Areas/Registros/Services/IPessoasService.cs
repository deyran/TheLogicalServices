
using IntellectusSecretaria.Areas.HorarioAula.MVVM.Models;

namespace IntellectusSecretaria.Areas.Registros.Services
{
    public interface IPessoasService
    {
        Task InitializeAsync();
        Task<List<Pessoas>> GetPessoas();
        Task<Pessoas> GetPessoa(int IdPessoa);
        Task<int> AddPessoa(Pessoas pessoas);
        Task<int> UpdatePessoa(Pessoas pessoas);
        Task<int> DeletePessoa(Pessoas pessoas);
    }
}
