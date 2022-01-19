using System;
namespace DIOdotNetconsole.models
{
	public class Retangulo
	{
		private double comprimento;
		private double largura;
		private bool valido;

		public void DefinirMedidas(double comprimento, double largura)
		{
			if (comprimento <= 0 || largura <= 0)
			{
				Console.WriteLine("Valores inválidos");
				this.valido = false;
				return;
			}
			this.comprimento = comprimento;
			this.largura = largura;
			this.valido = true;
		}

		public double ObterArea()
		{
			if (this.valido)
			{
				return comprimento * largura;
			}
			Console.WriteLine("Preencha valores válidos");
			return 0;
		}
	}
}