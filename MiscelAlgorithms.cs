using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class MiscelAlgorithms
	{
		#region Roate Vector
		public static int[] RotateVector(int[] source, int rotatingIndex)
		{
			int[] res = new int[source.Length];
			source.CopyTo(res, 0);

			int currRotIndex = 0;
			int len = res.Length;
			bool[] movedArray = new bool[res.Length];
			for (int i = 0; i < movedArray.Length; i++)
				movedArray[i] = false;

			//for (currRotIndex = 0; currRotIndex <= 0; currRotIndex++)
			for (currRotIndex = 0; currRotIndex <= rotatingIndex; currRotIndex++)
			{
				int val = res[currRotIndex];
				//int mul = 0;
				int leftSwapIndex = currRotIndex;
				int rightSwapIndex = (leftSwapIndex + rotatingIndex) % len;//(currRotIndex + mul * rotatingIndex) % len;
				while (rightSwapIndex != currRotIndex)
				{
					res[leftSwapIndex] = res[rightSwapIndex];
					movedArray[leftSwapIndex] = true;
					//mul++;
					leftSwapIndex = rightSwapIndex;
					rightSwapIndex = (rightSwapIndex + rotatingIndex) % len;//(currRotIndex + mul * rotatingIndex) % len;
				}
				res[leftSwapIndex] = val;
				movedArray[leftSwapIndex] = true;
				if (CheckRotateVectorFinished(movedArray)) break;
			}
			return res;
		}

		private static bool CheckRotateVectorFinished(bool[] movedArray)
		{
			bool res = true;
			for (int i = 0; i < movedArray.Length; i++)
			{
				if (movedArray[i] == false)
				{
					res = false;
					return res;
				}
			}
			return res;
		}
		#endregion

		public static void RunCPU()
		{
			while (true)
			{
				for (int i = 0; i < 9600000; i++) ;
				System.Threading.Thread.Sleep(10);
			}
		}

		/// <summary>
		/// Number of 1s in the range of 0 to n.
		/// Number 311 contains 2 1s.
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static ulong Sum1s(ulong n)
		{
			ulong iCount = 0;
			ulong iFactor = 1;

			ulong iLowerNum = 0;
			ulong iCurrNum = 0;
			ulong iHigherNum = 0;

			while (n / iFactor != 0)
			{
				iLowerNum = n - (n / iFactor) * iFactor;
				iCurrNum = (n / iFactor) % 10;
				iHigherNum = n / (iFactor * 10);

				if (iCurrNum < 1)
					iCount += iHigherNum * iFactor;
				else if (iCurrNum == 1)
					iCount += iHigherNum * iFactor + iLowerNum + 1;
				else // >1
					iCount += (iHigherNum + 1) * iFactor;
				#region "Commmented Out"
				//switch (iCurrNum)
				//{
				//    case 0:
				//        iCount += iHigherNum * iFactor;
				//        break;
				//    case 1:
				//        iCount += iHigherNum * iFactor + iLowerNum + 1;
				//        break;
				//    default:
				//        iCount += (iHigherNum + 1) * iFactor;
				//        break;
				//}
				#endregion
				iFactor *= 10;
			}

			return iCount;
		}

		public static int Count2sFrom1ToN(int n)
		{
			return 0;
		}

		public static int Addition(int a, int b)
		{
			int sum = 0;
			int carry = 0;

			while (b != 0)
			{
				sum = (a ^ b);
				carry = (a & b) << 1;
				a = sum;
				b = carry;
			}

			return sum;
		}

		public static int BinarySearchRegular(int[] array, int T)
		{
			int l = 0;
			int u = array.Length - 1;
			int mid = 0;
			while (l <= u)
			{
				mid = (l + u) / 2;
				if (array[mid] == T)
					return mid;
				else if (array[mid] < T)
					l = mid + 1;
				else
					u = mid - 1;
			}

			return -1;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="array"></param>
		/// <param name="T"></param>
		/// <param name="?"></param>
		/// <returns>Returns the index of the first occurrence of T in array or -1
		/// if it doesn't exist</returns>
		public static int BinarySearchFirstOccurrence(int[] array, int T)
		{
			int index = -1;
			int l = -1, u = array.Length;
			int mid = 0;

			while (l + 1 != u)
			{
				mid = (l + u) / 2;
				if (array[mid] < T)
					l = mid;
				else
					u = mid;
			}

			index = u;
			if (index >= array.Length || array[index] != T)
				index = -1;
			return index;
		}

		public static int FibIterVer(int n)
		{
			if (n <= 0)
				return 0;

			int a = 1;
			int b = 1;
			int c = 0;
			for (int i = 3; i <= n; i++)
			{
				c = a + b;
				a = b;
				b = c;
			}
			return b;
		}

		public static int FibRecurVer(int n)
		{
			if (n <= 0)
				return 0;
			if (n == 1)
				return 1;
			return FibRecurVer(n - 1) + FibRecurVer(n - 2);
		}
	}
}
