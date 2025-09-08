using Poo.Models;
using Newtonsoft.Json;

Vendas v1 = new Vendas(1, "Caneta", 3.45M);

string serializado = JsonConvert.SerializeObject(v1);




//if (numero % 2 == 0)
//{
//    Console.WriteLine($"O número {numero} é par");
//}
//else
//{
//    Console.WriteLine($"O número {numero} é ímpar");
//}















//Pessoa p1 = new Pessoa(nome: "Kauê", sobrenome: "Silva");
//
//(string nome, string sobrenome) = p1;
//
//Console.WriteLine($"Nome: {nome} {sobrenome}");
//
//












//LeituraArquivo arquivo = new LeituraArquivo();
//var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/ArquivoLeitura.txt");
//
//if (sucesso)
//{
//    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//    foreach (string linha in linhasArquivo)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possível ler o arquivo");
//}









//(int, string, string, decimal) tupla = (1, "Kauê", "Silva", 10.5M);
////ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Jhessica", "Isabel", 1.65M);
////var outroExemploTuplaCreate = Tuple.Create(3, "Ana", "Beatriz", 1.70M);
//
//Console.WriteLine($"Id: {tupla.Item1}");
//Console.WriteLine($"Nome: {tupla.Item2}");
//Console.WriteLine($"Sobrenome: {tupla.Item3}");
//Console.WriteLine($"Altura: {tupla.Item4}");
























//Dictionary<string, string> estados = new Dictionary<string, string>();
//estados.Add("SP", "São Paulo");
//estados.Add("RJ", "Rio de Janeiro");
//estados.Add("MG", "Minas Gerais");
//
//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}
//Console.WriteLine($"-------------------");
//estados.Remove("MG");
//estados["SP"] = "São Paulo - Atualizado";
//foreach (var item in estados)
//{
//    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
//}
//string chave = "MG";
//Console.WriteLine("Verificando se o dicionário contém a chave: " + chave);
//if (estados.ContainsKey(chave))
//{
//    Console.WriteLine("Dicionário contém a chave: " + chave);
//}
//else
//{
//    Console.WriteLine("Dicionário não contém a chave: " + chave);
//}
















//Stack<int> pilha = new Stack<int>();
//pilha.Push(2);
//pilha.Push(4);
//pilha.Push(6);
//pilha.Push(8);
//foreach (var item in pilha)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine($"Removendo o elemento:{pilha.Pop()}");
//pilha.Push(10);
//foreach (var item in pilha)
//{
//    Console.WriteLine(item);
//}

















//Queue<int> fila = new Queue<int>();
//fila.Enqueue(2);
//fila.Enqueue(4);
//fila.Enqueue(6);
//fila.Enqueue(8);
//
//foreach (var item in fila)
//{
//    Console.WriteLine(item);
//}
//
//Console.WriteLine($"Removendo o elemento:{fila.Dequeue()}"); 
//fila.Enqueue(10);
//
//
//foreach (var item in fila)
//{
//    Console.WriteLine(item);
//}














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