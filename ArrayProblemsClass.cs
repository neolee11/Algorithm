using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class ArrayProblemsClass
	{
		#region Max Contiguous Subset Sum Problem
		/// <summary>
		/// Max contiguous subset sum problem
		/// Simple Implementation
		/// </summary>
		/// <param name="array"></param>
		/// <param name="maxL"></param>
		/// <param name="maxR"></param>
		/// <returns></returns>
		public int MaxSubsetSumSimple(int[] array, ref int maxL, ref int maxR)
		{
			int maxSum = 0;
			maxL = -1;
			maxR = -1;

			int n = array.Length;
			if (n <= 0) return 0;

			int currSum = 0;
			for (int i = 0; i < n; i++)
			{
				currSum = array[i];
				for (int j = i + 1; j < n; j++)
				{
					currSum += array[j];
					if (currSum > maxSum)
					{
						maxSum = currSum;
						maxL = i;
						maxR = j;
					}
				}
			}

			return maxSum;
		}

		/// <summary>
		/// Divide and Conquer implementation
		/// </summary>
		/// <param name="array"></param>
		/// <param name="maxL"></param>
		/// <param name="maxR"></param>
		/// <returns></returns>
		public int MaxSubsetSumDC(int[] array, ref int maxL, ref int maxR)
		{
			int maxSum = 0;
			maxSum = MaxSubsetSumDCHelper(array, ref maxL, ref maxR, 0, array.Length - 1);
			return maxSum;
		}

		private int MaxSubsetSumDCHelper(int[] array, ref int maxL, ref int maxR, int left, int right)
		{
			int maxSum = 0;

			if (left >= right) 
			{
				if (left == right)
				{
					if (array[left] > 0)
					{
						maxL = left;
						maxR = right;
						return array[left];
					}
				}
				else
				{
					maxL = -1;
					maxR = -1;
					return 0;
				}
			}

			int mid = (left + right) / 2;

			int sumLeftMaxL = -1, sumLeftMaxR = -1;
			int sumLeft = MaxSubsetSumDCHelper(array, ref sumLeftMaxL, ref sumLeftMaxR, left, mid - 1);

			int sumRightMaxL = -1, sumRightMaxR = -1;
			int sumRight = MaxSubsetSumDCHelper(array, ref sumRightMaxL, ref sumRightMaxR, mid + 1, right);

			int tmpMax = 0;
			int tmpMaxLeft = -1, tmpMaxRight = -1;

			int currSum = array[mid];
			if (currSum > tmpMax) 
			{
				tmpMax = currSum;
				tmpMaxLeft = mid;
				tmpMaxRight = mid;
			}
			for (int i = mid - 1; i >= 0; i--)
			{
				currSum += array[i];
				if (currSum > tmpMax)
				{
					tmpMax = currSum;
					tmpMaxLeft = i;
					tmpMaxRight = mid;
				}
			}

			currSum = tmpMax;
			for (int j = mid + 1; j <= right; j++)
			{
				currSum += array[j];
				if (currSum > tmpMax)
				{
					tmpMax = currSum;
					tmpMaxRight = j;
				}
			}

			if (sumLeft >= sumRight)
			{
				maxSum = sumLeft;
				maxL = sumLeftMaxL;
				maxR = sumLeftMaxR;
			}
			else
			{
				maxSum = sumRight;
				maxL = sumRightMaxL;
				maxR = sumRightMaxR;
			}

			if (tmpMax > maxSum)
			{
				maxSum = tmpMax;
				maxL = tmpMaxLeft;
				maxR = tmpMaxRight;
			}

			return maxSum;
		}

		/// <summary>
		/// DP implementation
		/// </summary>
		/// <param name="array"></param>
		/// <param name="maxL"></param>
		/// <param name="maxR"></param>
		/// <returns></returns>
		public int MaxSubsetSumDP(int[] array, ref int maxL, ref int maxR)
		{
			int n = array.Length;
			if (n <= 0) return 0;

			int maxSum = 0;

			int maxSumSoFar = 0;
			int maxSofarL = -1;
			int maxSofarR = -1;

			for (int i = 0; i < n; i++)
			{
				if (maxSumSoFar > 0)
				{
					maxSumSoFar += array[i];
					maxSofarR = i;
				}
				else
				{
					maxSumSoFar = array[i];
					maxSofarL = i;
				}

				if (maxSumSoFar > maxSum)
				{
					maxSum = maxSumSoFar;
					maxL = maxSofarL;
					maxR = maxSofarR;
				}
			}
			return maxSum;
		}

        public int MaxSubsetSumDP2(int[] array)
        {
            int n = array.Length;
            if (n <= 0) return 0;

            int maxSum = 0;
            int maxSumSoFar = 0;
          
            for (int i = 0; i < n; i++)
            {
                if (maxSumSoFar > 0)
                    maxSumSoFar += array[i];
                else
                    maxSumSoFar = array[i];

                if (maxSumSoFar > maxSum)
                    maxSum = maxSumSoFar;
            }
            return maxSum;
        }

		public int CalcSums(int[] array, int left, int right)
		{
			int res = 0;
			for (int i = left; i <= right; i++)
				res += array[i];
			return res;
		}
		#endregion

		#region Print Array
		public string PrintArray(int[] array)
		{
			string msg = "";
			for (int i = 0; i < array.Length; i++)
				msg = msg + array[i].ToString() + "  ";
			return msg;
		}

		public string PrintArray(int[] array, int l, int r)
		{
			string msg = "";
			for (int i = 0; i < array.Length; i++)
				msg = msg + array[i].ToString() + "\t";

			msg += "\n";
			for (int i = 0; i < array.Length; i++)
				if (i == l)
					msg = msg + "L_" + i.ToString() + "\t";
				else if(i == r)
					msg = msg + "R_" + i.ToString() + "\t";
				else
					msg += "\t";

			return msg;
		}

		public static string PrintArrayWithIndexAbove(int[] array)
		{
			string msg = "Index:\t";
			for(int i =0; i< array.Length; i++)
				msg += "[" + i.ToString() + "]" + "\t";

			msg += "\nContent:\t";
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].ToString().Length == 1)
					msg += " ";
				msg += array[i].ToString() + "\t";
			}
			msg += "\n";
			return msg;
		}

		public static string PrintArrayWithIndexBelow(int[] array)
		{
			string msg = "";
			msg += "Content:\t";
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].ToString().Length == 1)
					msg += " ";
				msg += array[i].ToString() + "\t";
			}

			msg += "\nIndex:\t";
			for (int i = 0; i < array.Length; i++)
				msg += "[" + i.ToString() + "]" + "\t";

			
			msg += "\n";
			return msg;
		}
		#endregion

		#region Array Element Interlace Problem
		public void Interlace(int[] array)
		{

		}

		public void InterlaceHelper(int[] array, int lower, int upper)
		{
			if (lower >= upper)
				return;

			if (upper - lower == 1)
				return;

			int mid = (upper - lower) / 2;
			int exchangeSize = (upper - lower + 1) / 4;
			Exchange(array, mid - exchangeSize, mid + exchangeSize + 1, exchangeSize);

		}
		#endregion

		#region Array Rotation and Exchange
		public void Rotate(int[] array, int l, int u)
		{
			while(l <= u){
				int tmp = array[l];
				array[l] = array[u];
				array[u] = tmp;
				l++;
				u--;
			}
		}

		public void Exchange(int[] array, int idx1, int idx2, int n)
		{
			for (int i = 0; i < n; i++)
			{
				int tmp = array[idx1 + i];
				array[idx1 + i] = array[idx2 + i];
				array[idx2 + i] = tmp;
			}
		}
		#endregion
	}
}
