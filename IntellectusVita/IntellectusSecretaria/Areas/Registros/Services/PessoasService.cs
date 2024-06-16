using IntellectusSecretaria.Areas.HorarioAula.MVVM.Models;
using SQLite;

namespace IntellectusSecretaria.Areas.Registros.Services
{
    class PessoasService : IPessoasService
    {
        private SQLiteAsyncConnection _dbConnection;

        public Task InitializeAsync()
        {
            await SetUpDb();
        }

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "dbSecretaria.db3"
                 );

                _dbConnection = new SQLiteAsyncConnection(dbPath);
            }
        }

        public Task<int> AddPessoa(Pessoas pessoas)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletePessoa(Pessoas pessoas)
        {
            throw new NotImplementedException();
        }

        public Task<Pessoas> GetPessoa(int IdPessoa)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pessoas>> GetPessoas()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePessoa(Pessoas pessoas)
        {
            throw new NotImplementedException();
        }
    }
}
