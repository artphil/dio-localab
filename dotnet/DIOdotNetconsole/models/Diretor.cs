namespace DIOdotNetconsole.models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
		{
			Console.WriteLine($"Olá, meu nome é {Nome}. Eu sou diretor e meu salário é R$ {Salario}");
		}
    }
}