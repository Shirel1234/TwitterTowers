using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTowers
{
	public class Triangle
	{
		private int height;
		private int width;

		public Triangle(int height, int width)
		{
			this.height = height;
			this.width = width;
		}

		public void Perimeter()
		{
			// calculate the others sides by: height^2 + (width/2)^2 = side^2
			double temp = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width / 2, 2));
			// print the Perimeter
			Console.WriteLine("The perimeter is: " + (temp + temp + this.width));
		}

		public void PrintTriangle()
		{

			int numOdd = (width-3)/2;
			int countForRow=(height-2)/numOdd;
			int countUpGroup = countForRow + (height - 2) % numOdd;
			int numSpace = numOdd +1;
			Console.WriteLine("The Triangle");
			//The first row
			for (int i = 0; i < numSpace; i++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
			numSpace--;

			//The up group
			for (int i = 1; i <= countUpGroup; i++)
			{
				for (int j = 0; j < numSpace; j++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("***");
			}
			numSpace--;

			//The other group
			for (int i = 5; i < width; i+=2)
			{
				for (int j = 1; j <= countForRow; j++)
				{
					for (int k = 1; k <= numSpace; k++)
					{
						Console.Write(" ");
					}
					for (int k = 1; k <= i; k++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
				numSpace--;
			}

			//The last row
			for (int i = 1;i <= width; i++)
			{
				Console.Write("*");
			}
			Console.WriteLine() ;
		}
	}
}
