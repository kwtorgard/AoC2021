using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace AoC2021
{
	internal class Program
	{
		
		
		
		public static void Main(string[] args)
		{
			
			Day2_2();
		}

		private static void Day1_1()
		{
			Console.Write(GetInput(1));
			
		}


		private static void Day2_2()
		{
			IEnumerable<string[]> input = GetInput(2).Select(s => s.Split(' '));

			int depth = 0;
			int horizontal = 0;
			int aim = 0;
			foreach (string[] c in input)
			{
				int param = int.Parse(c[1]);

				switch (c[0])
				{
					case "up":
						aim -= param;
						break;
					case "down":
						aim += param;
						break;
					case "forward":
						horizontal += param;
						depth += aim * param;
						break;
				}
			}
			Console.Write(":: " + (horizontal * depth));	
		}
		
		

		private static string[] GetInput(int day)
		{
			return File.ReadAllLines($"{day}.txt");
		}
	}
}