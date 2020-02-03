using System;
using System.Collections.Generic;

namespace EPAMTestTasks
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mas = new int[] { 3, 7, 4, 8, 5, 4, 6, 3, 2, 5, 1, 6, 4, 1, 9, 7, 8, 3, 7, 0, 3, 2, 1, 6, 7, 4, 0, 6, 9, 9, 9, 9, 9 };

			mas = Sort(mas);

			Console.WriteLine("Задание 1.Сортировка (пузырьком)");
			foreach (var x in mas)
			{
				Console.Write($"{x} ");
			}

			Console.WriteLine();

			Console.WriteLine($"Задание 2.Поиск {IsValueExist(mas, 6)}");

			Console.WriteLine($"Задание 3.Строки");
			foreach (var x in OnceTimeWord("aa bb a b aa b c cc d dd d"))
			{
				Console.Write($"{x} ");
			}

			Console.WriteLine();

			Console.WriteLine($"Задание 4.Факториал {Factorial(5)}");

		}

		//Задание 1.Сортировка (пузырьком)
		public static int[] Sort(int[] mas)
		{
			for (int i = 0; i < mas.Length - 1; i++)
			{
				bool sorted = true;
				int min = i;

				for (int j = i; j < mas.Length - i - 1; j++)
				{
					if (mas[j] > mas[j + 1])
					{
						int temporary = mas[j];
						mas[j] = mas[j + 1];
						mas[j + 1] = temporary;
						sorted = false;
					}

					if (mas[j] < mas[min])
					{
						min = j;
					}
				}

				if (sorted)
					break;

				if (min != i)
				{
					int temporary = mas[i];
					mas[i] = mas[min];
					mas[min] = temporary;
				}
			}

			return mas;
		}

		//Задание 2.Поиск
		public static bool IsValueExist(int[] mas, int value)
		{
			for (int i = 0; i < mas.Length; i++)
			{
				if (mas[i] == value)
				{
					return true;
				}
			}

			return false;
		}

		//Задание 3.Строки
		public static List<string> OnceTimeWord(string s)
		{
			var words = s.Split(' ');

			Dictionary<string, int> d = new Dictionary<string, int>();

			foreach (var word in words)
			{
				if (d.ContainsKey(word))
				{
					d[word]++;
				}
				else
				{
					d.Add(word, 1);
				}
			}

			List<string> once = new List<string>();

			foreach (var x in d)
			{
				if (x.Value == 1)
				{
					once.Add(x.Key);
				}
			}

			return once;
		}

		//Задание 4.Факториал
		public static int Factorial(int n)
		{
			var fac = 1;

			for (int i = 2; i <= n; i++)
			{
				fac = fac * i;
			}

			return fac;
		}
	}
}
