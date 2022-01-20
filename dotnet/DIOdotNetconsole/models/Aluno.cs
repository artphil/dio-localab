namespace DIOdotNetconsole.models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
		public override void Apresentar()
		{
			Console.WriteLine($"Olá, meu nome é {Nome}. Eu sou aluno e minha nota é {Nota} pontos");
		}
    }
}