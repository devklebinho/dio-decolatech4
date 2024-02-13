using System.Security.AccessControl;
using exemplo_explorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
OlhaData dateiro = new OlhaData();

dateiro.MostraDataHora();
dateiro.MostraData();
dateiro.MostraHora();
dateiro.MostrarDataPersonalizada();

// Pessoa p1 = new Pessoa();
// p1.Nome = "Ana Julia";
// p1.Sobrenome = "Marcarenhas";

// Pessoa p2 = new Pessoa();
// p2.Nome = "Pedro";
// p2.Sobrenome = "Cabral";
/*
Pessoa p1 = new Pessoa(nome:"Morgana", sobrenome:"Lacoste");//escrever o nome do parâmetro
Pessoa p2 = new Pessoa("Lux", "Tchevtchenko");

Curso cursoDeJapones = new Curso();
cursoDeJapones.Nome = "Japonês";
cursoDeJapones.Alunos = new List<Pessoa>();//É necessário instanciar a lista
cursoDeJapones.AdicionarAluno(p1);
cursoDeJapones.AdicionarAluno(p2);
cursoDeJapones.ListarAlunos();
*/

