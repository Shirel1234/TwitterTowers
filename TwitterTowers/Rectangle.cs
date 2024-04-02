using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTowers
{
	public class Rectangle
	{
		private int height;
		private int width;

		public Rectangle(int height, int width)
		{
			this.height = height;
			this.width = width;
		}
		public int GetHeight()
		{
			return this.height;
		}
		public int GetWidth()
		{
			return this.width;
		}
		//Print area of this rectangle
		public void Area()
		{
			Console.WriteLine("The area is: " + this.height * this.width);
		}
		//Print area of this rectangle
		public void Perimeter()
		{
			Console.WriteLine("The perimeter is: " +(this.height + this.width)*2);
		}
	}
}
