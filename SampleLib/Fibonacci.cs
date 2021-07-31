using System;

namespace SampleLib
{
	public class Fibonacci
	{
		public int[] Generate(int count)
		{
			int[] result = new int[count];			
			int first = 0, second = 1;			
			result[0] = first;

			if (count == 1)
			{
				return result;
			}
			
			result[1] = second; // 0 1 1 2 3 

			for (int n=2; n < count; n++)
			{
				int temp = second;
				second = first + second;
				result[n] = second;
				first = temp;
			}
			
			return result;
		}
	}
}
