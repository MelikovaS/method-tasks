namespace MethodOverload
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Chevrenin sahesi: " + Area(5));
			Console.WriteLine("Duzbucaqlinin sahesi: " + Area(4, 5));
			Console.WriteLine("Paralelepipedin sahesi: " + Area(4, 6, 7));
			Console.WriteLine("Daxile chekilmish chevrenin sahesi: " + Area(2, 4, 8, 11));
		}

		public static int Area(int r) 
		{
			int p = 3;
			int chevreninSahesi = p * r * r;
			return chevreninSahesi;
		}

		public static int Area(int a, int b)
		{
			int duzbucaqSahesi = a * b;
			return duzbucaqSahesi;
		}

		public static int Area(int a, int b, int c)
		{
			int paralelepipedinSahesi = 2*(a*b+a*c+b*c);
			return paralelepipedinSahesi;
		}

		public static int Area(int a, int b, int c, int r)
		{
			int p = (a+b+c)/2;
			int daxiliChevreSahesi = p*r;
			return daxiliChevreSahesi;
		}
	}
}