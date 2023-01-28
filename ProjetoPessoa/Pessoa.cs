using System;
class Pessoa
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public int Cpf { get; set; }
    public string Email { get; set; }
    public Pessoa(string nome, int cpf, string email)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
    }
    public void ImprimirInformacoes()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("CPF: " + Cpf);
        Console.WriteLine("Email: " + Email);
    }
}


