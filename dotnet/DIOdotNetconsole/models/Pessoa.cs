using System;

namespace DIOdotNetconsole.models
{
	public class Pessoa
	{
		public Pessoa()
		{
			this.Nome = string.Empty;
			this.Sobrenome = string.Empty;
			this.Idade = 0;
			this.Documento = string.Empty;
		}
		public Pessoa(string nome, string sobrenome)
		{
			this.Nome = nome;
			this.Sobrenome = sobrenome;
			this.Idade = 0;
			this.Documento = string.Empty;
		}
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public int Idade { get; set; }
		public string Documento { get; set; }
		public virtual void Apresentar()
		{
			Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome} e tenho {Idade} anos");
		}
	}
}