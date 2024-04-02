using TwitterTowers;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Choose 1-Rectangle 2-Triangular and 3-Exit");
		string num =Console.ReadLine();
		while (num != "3")
		{
			switch (num)
			{
				case "1":
					Console.WriteLine("Please enter height and width");
					int heightR = int.Parse(Console.ReadLine());
					int widthR = int.Parse(Console.ReadLine());
					Rectangle rectangle = new Rectangle(heightR, widthR);
					if((rectangle.GetHeight() - rectangle.GetWidth())> 5  || (rectangle.GetHeight() - rectangle.GetWidth())< -5)
					{
						rectangle.Area();
					}
					else
					{
						rectangle.Perimeter();
					}
					break;
				case "2":
					Console.WriteLine("Please enter height and width");
					int heightT = int.Parse(Console.ReadLine());
					int widthT = int.Parse(Console.ReadLine());
					Triangle triangle = new Triangle(heightT, widthT);
					Console.WriteLine("Choose: 1-Perimeter and 2-Print");
					int ch = int.Parse(Console.ReadLine());
					if(ch == 1) 
					{
						triangle.Perimeter();
					}
					else
					{
						if(widthT%2 == 0 || widthT > 2 * heightT)
						{
							Console.WriteLine("The triangle cannot be printed.");
						}
						else
						{
							triangle.PrintTriangle();
						}
					}
					break;
				case "3":
					Console.WriteLine("The program is over");
					return;

			}
			Console.WriteLine("Choose 1-Rectangle 2-Triangular and 3-Exit");
		    num = Console.ReadLine();
		}
	}
}
