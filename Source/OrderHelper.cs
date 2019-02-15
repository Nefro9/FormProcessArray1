using System;

class OrderHelper
{
	public int[] RikiuokD(int[] array)
	{
		int[] result = array;
		
		Array.Sort(result);
		
		return result;
	}
	
	public int[] RikiuokM(int[] array)
	{
		int[] result = array;
		
		Array.Sort(result);
		Array.Reverse(result);
		
		return result;
	}
}
