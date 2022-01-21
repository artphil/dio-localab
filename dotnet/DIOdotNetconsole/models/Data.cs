namespace DIOdotNetconsole.models
{
	public class Data
	{
		private int mes;
		private bool mesValido;
		public int Mes
		{
			get => mes;
			set
			{
				if(value > 0 && value <= 12)
				{
					mes = value;
					mesValido = true;
				}
			}
		}

		public void ApresentarMes()
		{
			if(mesValido)
			{
				System.Console.WriteLine($"Mês: {mes}");
			}
			else
			{
				System.Console.WriteLine("Mês inválido");
			}
		}
	}
}