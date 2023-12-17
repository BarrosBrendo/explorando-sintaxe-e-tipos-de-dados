using System;
using System.Globalization;
using explorando_sintaxe_e_tipos_de_dados;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Email:");
        string Email = Console.ReadLine();

        System.Console.WriteLine("Nome:");
        string Nome = Console.ReadLine();

        System.Console.WriteLine("Senha:");
        string Senha = Console.ReadLine();

        CadastroPessoa cadastroPessoa = new CadastroPessoa(Email, Nome, Senha);

        System.Console.WriteLine(cadastroPessoa);

    }
}