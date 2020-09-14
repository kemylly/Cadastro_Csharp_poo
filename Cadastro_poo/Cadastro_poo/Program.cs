using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(); //puxar uma classe
            Calculo_Idade c = new Calculo_Idade();

            Console.WriteLine("Efetue o cadastro: "); //exibir texto
            Console.Write("Digite seu nome: ");
            p.Nome = Console.ReadLine(); //pegando o que foi digitado / string

            Console.Write("Digite sua cidade: ");
            p.Cidade = Console.ReadLine();

            Console.Write("Digite sua dade: ");
            p.Idade = Convert.ToInt32(Console.ReadLine());  //pegando o que foi digitado / int

            Console.Write("Digite seu telefone: ");
            p.Telefone = Convert.ToInt32(Console.ReadLine());

            Console.Clear();  //limpar tela

            p.ExibirDados(); //exibe metodo

           
            c.ExibirIdade();

            Console.ReadKey();  //parar programa
        }
    }
}
