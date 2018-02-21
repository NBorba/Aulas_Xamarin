using System;

namespace PrimeiroProjeto
{
	class MainClass
	{
		private const double PI = 3.14;

		public static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Digite abaixo o exercício desejado: ");
				try
				{
					int idExercicio = 0;
					if (int.TryParse(Console.ReadLine(), out idExercicio))
					{
						ResolverExercicio(idExercicio);
					}
					else
					{
						Console.WriteLine("Digite um número válido!");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Erro: " + ex.Message.Trim());
				}
			}
		}

		private static void ResolverExercicio(int idExercicio)
		{
			switch (idExercicio)
			{
				case 1:
					ExercicioUm();
					break;
				case 2:
					ExercicioDois();
					break;
				case 3:
					ExercicioTres();
					break;
				case 4:
					ExercicioQuatro();
					break;
				case 5:
					ExercicioCinco();
					break;
				case 6:
					ExercicioSeis();
					break;
				default:
					Console.WriteLine("Nenhum exercício com este número encontrado!");
					break;
			}
		}

		#region Resolução Ex. 1
		private static void ExercicioUm()
		{
			int qtdNotas = 4;
			double[] notas = new double[qtdNotas];

			Console.Clear();
			Console.WriteLine("--- Exercício 1 ---");
			Console.WriteLine("Digite " + qtdNotas + " notas para calcular a média");
			for (int i = 0; i < qtdNotas; i++)
			{
				Console.WriteLine("Nota " + (i + 1) + ": ");
				while (!double.TryParse(Console.ReadLine(), out notas[i]))
				{
					Console.WriteLine("Digite uma nota válida para a nota " + (i + 1) + "!");
				}
			}

			Console.Clear();
			double mediaNotas = 0;
			for (int i = 0; i < qtdNotas; i++)
			{
				mediaNotas += notas[i];
			}
			mediaNotas = mediaNotas / qtdNotas;

			Console.WriteLine("Média das " + qtdNotas + " notas: " + mediaNotas);
		}
		#endregion

		#region Resolução Ex. 2
		private static void ExercicioDois()
		{
			Console.Clear();
			Console.WriteLine("--- Exercício 2 ---");
			Console.WriteLine("Converter Fahrenheit para Celsius: ");
			double temperaturaFahrenheit = 0;
			while (!double.TryParse(Console.ReadLine(), out temperaturaFahrenheit))
			{
				Console.WriteLine("Digite uma temperatura válida!");
			}

			double temperaturaCelsius = (temperaturaFahrenheit - 32) / 1.8;
			Console.WriteLine("Temperatura " + Math.Round(temperaturaFahrenheit, 2) + "F igual a " + Math.Round(temperaturaCelsius, 2) + "C");
		}
		#endregion

		#region Resolução Ex. 3
		private static void ExercicioTres()
		{
			Console.Clear();
			Console.WriteLine("--- Exercício 3 ---");
			Console.WriteLine("Forneça o raio da esfera e descubra sua área e volume: ");
			double raio = 0;
			while (!double.TryParse(Console.ReadLine(), out raio))
			{
				Console.WriteLine("Digite um valor válido para o raio!");
			}

			double area = 4 * PI * Math.Pow(raio, 2);
			double volume = (4 * PI * Math.Pow(raio, 3)) / 3;

			Console.WriteLine("Raio: " + Math.Round(raio, 2));
			Console.WriteLine("Área: " + Math.Round(area, 2));
			Console.WriteLine("Volume: " + Math.Round(volume,2));
		}
		#endregion

		#region Resolução Ex. 4
		private static void ExercicioQuatro()
		{
			Console.Clear();
			Console.WriteLine("--- Exercício 4 ---");
			Console.WriteLine("Digite um número: ");

			int numero = 0;
			while (!int.TryParse(Console.ReadLine(), out numero))
			{
				Console.WriteLine("Digite um número válido!");
			}

			bool multiploDeCinco = numero % 5 == 0;
			bool positivo = numero > 0;

			if (multiploDeCinco && positivo)
			{
				Console.WriteLine("OK");
			}
			else if (multiploDeCinco || positivo)
			{
				Console.WriteLine("PARCIAL");
			}
			else
			{
				Console.WriteLine("INCORRETO");
			}
		}
		#endregion

		#region ExercicioCinco 
		private static void ExercicioCinco()
		{
			Console.Clear();
			Console.WriteLine("--- Exercício 5 ---");
			Console.WriteLine("Digite um número inteiro para calcular Fibonacci: ");

			int numero = 0;
			while (!int.TryParse(Console.ReadLine(), out numero))
			{
				Console.WriteLine("Digite um número válido!");
			}

			int[] numerosFibonacci = new int[numero];
			for (int i = 0; i < numero; i++)
			{
				if (i <= 1)
				{
					numerosFibonacci[i] = numero;
				}
				else
				{
					numerosFibonacci[i] = Fibonacci(numerosFibonacci[i - 1], numerosFibonacci[i - 2]);
				}
			}

			Console.WriteLine("Fibonacci de " + numero);
			for (int i = 0; i < numero; i++)
			{
				Console.WriteLine(numerosFibonacci[i]);
			}
		}

		private static int Fibonacci(int numero, int numeroAnterior)
		{
			return numero + numeroAnterior;
		}
		#endregion

		#region Resolução Ex. 6 
		private static void ExercicioSeis()
		{
			const double PRECO_LATA = 50;
			const double LITROS_LATA = 5;
			const double LITRO_PINTA_M2 = 3;
			double alturaTanque = 0;
			double raioTanque = 0;

			Console.Clear();
			Console.WriteLine("--- Exercício 6 ---");
			Console.WriteLine("Digite os dados do tanque de combustível para calcular o custo da tinta: ");

			Console.WriteLine("Digite a altura do tanque: ");
			while (!double.TryParse(Console.ReadLine(), out alturaTanque))
			{
				Console.WriteLine("Digite uma altura válida!");
			}

			Console.WriteLine("Digite o raio do tanque: ");
			while (!double.TryParse(Console.ReadLine(), out raioTanque))
			{
				Console.WriteLine("Digite um raio válido!");
			}

			double comprimento = 2 * PI * raioTanque;
			double areaBase = PI * Math.Pow(raioTanque, 2);
			double areaLateral = alturaTanque * comprimento; 
			double areaCilindro = areaBase + areaLateral;
			double qtdLitrosTotais = (areaCilindro / LITRO_PINTA_M2);
			double qtdLatasNecessarias = qtdLitrosTotais / LITROS_LATA;
			double precoTotal = qtdLatasNecessarias * PRECO_LATA;

			string mensagem = "Irá custar R$" + Math.Round(precoTotal, 2) + " para comprar " + Math.Round(qtdLatasNecessarias, 2) 
                + " latas que iram pintar " + areaCilindro + " metros quadrados do cilindro.";
			Console.WriteLine(mensagem);
		}
		#endregion
	}
}
