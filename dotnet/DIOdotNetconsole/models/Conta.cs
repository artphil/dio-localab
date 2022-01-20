namespace DIOdotNetconsole.models
{
    public abstract class Conta
    {
        protected double Saldo;
		public abstract void Creditar(double valor);
		public void ExibirSaldo()
		{
			System.Console.WriteLine($"O saldo da conta é: {Saldo}");
		}
    }
}