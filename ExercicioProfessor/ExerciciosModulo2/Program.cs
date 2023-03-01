using System;

class Pessoa
{
    public string nome;
    public int idade;

    public void Cumprimentar()
    {
        Console.WriteLine($"Olá, meu nome é {nome}!");
    }

    public void DizerIdade()
    {
        Console.WriteLine($"Eu tenho {idade} anos.");
    }
}

class Aluno : Pessoa
{
    public void IrParaEscola()
    {
        Console.WriteLine($"estou indo para a escola .");
    }
}

class Professor : Pessoa
{
    public void Explicar(string assunto)
    {
        Console.WriteLine($"{nome} está explicando sobre {assunto}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        pessoa.nome = "João";
        pessoa.idade = 15;
        pessoa.Cumprimentar();
        pessoa.DizerIdade();

        Aluno aluno = new Aluno();
        aluno.nome = "Maria";
        aluno.idade = 10;
        aluno.Cumprimentar();
        aluno.DizerIdade();
        aluno.IrParaEscola();

        Professor professor = new Professor();
        professor.nome = "Pedro";
        professor.idade = 40;
        professor.Cumprimentar();
        professor.DizerIdade();
        professor.Explicar("matemática");
    }
}
