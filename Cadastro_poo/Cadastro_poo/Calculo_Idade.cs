using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_poo
{
    public class Calculo_Idade : Pessoa //herança
    {
         public Calculo_Idade() : base()
        {
            this.Teste = 0;
        } 

        public Calculo_Idade(String nome, String cidade, int idade, int telefone, int teste) : base(nome, cidade, idade, telefone)
        {
            this.Teste = teste;
            //this.Idade = idade;
        }
        
        /*public Calculo_Idade(String nome, String cidade, int idade, int telefone) : base(nome, cidade, idade, telefone)
        {
            //this.Teste = teste;
            //this.Idade = idade;
        }*/

        private int teste;

        public int Teste
        {
            get { return teste; }
            set { teste = value; }
        }


        public void ExibirIdade()
        {
            //this.Teste = this.Idade;
            //Pessoa c = new Pessoa();

           if (this.Idade >= 18)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Esse usuario é maior de idade");
            }
           else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Esse usuario é menor de idade");
            }

            //this.Teste = (this.Idade * 10);
            Console.WriteLine("Idade multiplicada por 10 é: " + this.Idade * 10);
            //return (0);

            Console.WriteLine("Nome: " + this.Nome);

            this.Teste = 5;
        }
    }
}
