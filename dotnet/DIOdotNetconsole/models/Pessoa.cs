using System;

namespace DIOdotNetconsole.models
{
	public class Pessoa
	{
		public Pessoa()
		{
			this.Nome = "";
			this.Idade = 0;

		}
		public string Nome { get; set; }
		public int Idade { get; set; }
		public void Apresentar()
		{
			Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
		}
	}
}