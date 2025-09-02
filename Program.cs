using Poo.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Kauê";
p1.Sobrenome = "Silva";

Pessoa p2 = new Pessoa();
p2.Nome = "Jhessica";
p2.Sobrenome = "Isabel";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();














//p1.Apresentar();