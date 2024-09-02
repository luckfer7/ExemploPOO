using ExemploPOO.Interfaces;
using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.nome = "Lucas";
// p1.Idade = 26;

// p1.Apresentar();



// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();

// Aluno a1 = new Aluno();

// a1.nome = "Lucas";
// a1.Idade = 26;
// a1.Nota = 8.0;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.nome = "Renan";
// p1.Idade = 41;
// p1.Salario = 5000m;
// p1.Apresentar();

// Corrente c = new Corrente();

// c.Creditar(500);
// c.ExibirSaldo();

// Pessoa p1 = new Pessoa("Lucas");
// Aluno a1 = new Aluno("Lucas");
// p1.Apresentar();
// a1.Apresentar();

//Computador cp = new Computador();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(4,2));
Console.WriteLine(calc.Subtrair(4,2));
Console.WriteLine(calc.Multiplicar(4,2));
Console.WriteLine(calc.Dividir(4,2));

