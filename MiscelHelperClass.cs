using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Algorithms
{
	public class MiscelHelperClass
	{
		public static int[] RandomGenerateIntArray(int length)
		{
			int maxVal = 20;
			return RandomGenerateIntArray(length, maxVal);
		}

		public static int[] RandomGenerateIntArray(int length, int maxVal)
		{			
			int[] newArray = new int[length];

			Random a = new Random();
			for (int i = 0; i < length; i++)
			{
				int n = a.Next(maxVal);
				newArray[i] = n;
			}
			return newArray;
		}

		public static int[] RandomGenUniqueIntArray(int length)
		{
			int maxVal = 30;
			int[] newArray = new int[length];

			ArrayList existingNum = new ArrayList();
			
			Random a = new Random();
			int i = 0;
			while (i < length)
			{
				int n = a.Next(maxVal);
				if (existingNum.Contains(n) == false)
				{
					existingNum.Add(n);
					newArray[i] = n;
					i++;
				}
			}
			
			return newArray;
		}

		public static int[] GenOrderedIntArray(int length, int startingVal, int increment)
		{
			int[] newArray = new int[length];

			for (int i = 0; i < length; i++)
			{
				newArray[i] = startingVal + i * increment;
			}
			return newArray;
		}

		public static string PrintArray(int[] arr)
		{
			string msg ="";
			for (int i = 0; i < arr.Length; i++)
			{
				msg = msg + arr[i].ToString() + "\t";
			}
			return msg;
		}

	}
}
