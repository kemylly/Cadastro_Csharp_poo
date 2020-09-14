using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_poo
{
	public class Pessoa
	{
		//construtores
		public Pessoa()
		{
			this.Nome = "";
			this.Cidade = "";
			this.Idade = 0;
			this.Telefone = 0;
		}

		public Pessoa(String nome, String cidade, int idade, int telefone)  //sobrecarga 
		{
			this.Nome = nome;
			this.Cidade = cidade;
			this.Idade = idade;
			this.Telefone = telefone;
		}

		/*public Pessoa(string @string, string nome)
		{
			this.nome = nome;
		}*/

		//propriedades
		private String nome;

		public String Nome
		{
			get { return nome; }
			set { this.nome = value.ToUpper(); } //deixar tudo em maiusculo
		}

		private String cidade;

		public String Cidade
		{
			get { return cidade; }
			set { this.cidade = value.ToLower(); } //deixar tudo em minusculo
		}

		private int idade;

		public int Idade
		{
			get { return idade; }
			set { this.idade = value; }
		}

		private int telefone;

		public int Telefone
		{
			get { return telefone; }
			set { this.telefone = value; }
		}

		//metodos
		public void ExibirDados()  //exibindo dados cadastrados
		{
			Console.WriteLine("Os dados cadastrados foram: ");
			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Cidade: " + this.Cidade);
			Console.WriteLine("Idade: " + this.Idade);
			Console.WriteLine("Telefone: " + this.Telefone);
		}

		/*public void ExibirIdade() //calculo de idade sem heranca
		{
			if (Idade >= 18)
			{
				Console.WriteLine(" ");
				Console.WriteLine("Esse usuario é maior de idade");
			}
			else
			{
				Console.WriteLine(" ");
				Console.WriteLine("Esse usuario é menor de idade");
			}
		}*/
	}
}

