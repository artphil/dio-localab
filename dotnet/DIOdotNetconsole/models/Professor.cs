namespace DIOdotNetconsole.models
{
	public class Professor : Pessoa
	{
		public double Salario { get; set; }
		public override void Apresentar()
		{
			Console.WriteLine($"Olá, meu nome é {Nome}. Eu sou professor e meu salário é R$ {Salario}");
		}
	}
}