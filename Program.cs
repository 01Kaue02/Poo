using Poo.Models;

Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento:{ fila.Dequeue()}"); 


foreach (var item in fila)
{
    Console.WriteLine(item);
}














//new ExemploExcecao().Metodo1();















//try
//{
//
//    string[] linhas = File.ReadAllLines("Aruivo/ArquivoLeitura.txt");
//
//    foreach (string linha in linhas)
//    {
//        Console.WriteLine(linha);
//    }
//
//}
//catch (FileNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
//}
//catch (DirectoryNotFoundException ex)
//{
//    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Chegou até aqui");
//}




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