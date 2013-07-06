using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	class PermutationClass
	{
		public static string Perm(int[] arr, int l, int u)
		{
			string result = "";
			if (l == u)
			{
				result = arr[l].ToString() + "\n";
				return result;
			}
			else
			{
				for (int i = l; i <= u; i++)
				{
					int tmp = arr[i];
					Swap(ref arr[i], ref arr[l]);
					string tmpResult = Perm(arr, l + 1, u);
					string[] splitArr = tmpResult.Split(new char[] { '\n' });
					for (int j = 0; j < splitArr.Length; j++)
					{
						if(splitArr[j].Trim() != "")
							result = result + tmp.ToString() + " " + splitArr[j] + "\n";
					}
					Swap(ref arr[i], ref arr[l]);
				}
				return result;
			}
		}

		public static void Swap(ref int val1, ref int val2)
		{
			int tmp = val1;
			val1 = val2;
			val2 = tmp;
		}
	}
}
