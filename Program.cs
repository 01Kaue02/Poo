using Poo.Models;
try
{

    string[] linhas = File.ReadAllLines("Arquivo/ArquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}




//Pessoa p1 = new Pessoa(nome: "Kauê", sobrenome: "Silva");
//
//
//Pessoa p2 = new Pessoa(nome: "Jhessica", sobrenome: "Isabel");
//
//
//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();
//
//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();














//p1.Apresentar();