using ExemploPOO.Interfaces;
using ExemploPOO.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(123);
c1.ExibirSaldo();

Pessoa p1 = new Pessoa("Valar");
Aluno a1 = new Aluno("Luis");
a1.Apresentar();


Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(1, 1));