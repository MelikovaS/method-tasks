namespace MethodMinimum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 3, 5, 8, 11, 1, 12 };
			Console.WriteLine(Minimum(numbers));
		}
		public static int Minimum(int[] nums)
		{
			int min = nums[0];
			foreach (int num in nums)
			{
				if (num < min)
				{
					min = num;
				}
			}
			return min;
		}
	}
}