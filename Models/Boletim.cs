namespace SGestorEscola.Models
{
    public class Boletim
    {
        private string PastaSecretaria = "SecretariaNotas";
        private int PastaBaseAno = DateTime.Now.Year;
        private string path = @"C:\";

        private string[] Turmas = new string[]
        {
            "Ensino-Infantil/Maternal-2",
            "Ensino-Infantil/Jardim-1",
            "Ensino-Infantil/Jardim-2",
            "Anos-Iniciais/1-Ano",
            "Anos-Iniciais/2-Ano",
            "Anos-Iniciais/3-Ano",
            "Anos-Iniciais/4-Ano",
            "Anos-Iniciais/5-Ano",
            "Anos-Finais/6-Ano",
            "Anos-Finais/7-Ano",
            "Anos-Finais/8-Ano",
            "Anos-Finais/9-Ano",
            "Ensino-Médio/1-Ano",
            "Ensino-Médio/2-Ano",
            "Ensino-Médio/3-Ano"
        };

        private void CreateFolder(string pasta)
        {
            string pathAux = path + pasta;

            try
            {
                if (!Directory.Exists(pathAux))
                {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(pathAux);
                    Console.WriteLine($"A pasta foi criada com sucesso em {directoryInfo.FullName}.");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Falhou");
            }
        }
        public void CreateEnviroment()
        {
            CreateFolder(PastaSecretaria);

            //Secretária + Ano
            CreateFolder(PastaSecretaria + "\\" + PastaBaseAno);

            //Secretária + Ano + turmas
            foreach (string turma in Turmas)
            {
                CreateFolder(
                    PastaSecretaria + "\\" +
                    PastaBaseAno + "\\" +
                    turma);
            }
        }

        public void CreatePDF()
        {
            string ModeloMapaNota = path + PastaSecretaria + @"\ModeloMapaNotas.pdf";

            Console.WriteLine(ModeloMapaNota);
            Console.WriteLine("---------------------------");
        }
    }
}
