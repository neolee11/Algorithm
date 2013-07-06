using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class SortingClass
	{
		#region Bubble Sort
		/// <summary>
		/// Bubble-like swap the largest element to the end of the array at every loop
		/// </summary>
		/// <param name="array"></param>
		public static void BubbleSort(int[] array)
		{
			int n = array.Length;
			for (int i = n - 1; i >= 0; i--)
			{
				for (int j = 0; j < i; j++)
					if (array[j] > array[j + 1])
						Swap(ref array[j], ref array[j + 1]);
			}
		}
		#endregion

		#region Insertion Sort
		/// <summary>
		/// Insert the next unsorted element from the unsorted portion into the sorted portion
		/// </summary>
		/// <param name="array"></param>
		public static void InsertionSort(int[] array)
		{
			int n = array.Length;
			int insertVal;
			int j;

			for (int i = 1; i < n; i++)
			{
				insertVal = array[i];
				j = i;
				while (j > 0 && array[j - 1] > insertVal)
				{
					array[j] = array[j - 1];
					j--;
				}
				array[j] = insertVal;
			}
		}
		#endregion

		#region Selection Sort
		/// <summary>
		/// Select the min element in each loop and place it to the starting index of the loop
		/// </summary>
		/// <param name="array"></param>
		public static void SelectionSort(int[] array)
		{
			int n = array.Length;
			int minIndex;
			for (int i = 0; i < n; i++)
			{
				minIndex = i;
				for (int j = i + 1; j < n; j++)
					if (array[j] < array[minIndex]) minIndex = j;
				if (minIndex != i)
					Swap(ref array[i], ref array[minIndex]);
			}
		}
		#endregion

		#region Heap Sort
		/// <summary>
		/// Uses max-heap. First build-max-heap from an unrodered input array, then extract max,
		/// and max-heapify.
		/// </summary>
		/// <param name="array"></param>
		public static void HeapSort(int[] array)
		{
			BuildMaxHeap(array);
			for (int i = (array.Length - 1); i > 0; i--)
			{
				Swap(ref array[i], ref array[0]);
				HeapSize--;
				MaxHeapify(array, 0);
			}
		}

		private static int HeapSize;

		/// <summary>
		/// It is assumed that the binary trees rooted at LEFT(i) and RIGHT(i) are max-heaps,
		/// but that array[i] may be smaller than its children, thus violating the max-heap
		/// property. This function is to let the value at A[i] floats down in the max-heap so
		/// that the subtreee rooted at index i becomes a max-heap.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="i"></param>
		private static void MaxHeapify(int[] array, int i)
		{
			int leftIndex = MaxHeapLeft(i);
			int rightIndex = MaxHeapRight(i);
			int largestIndex;
			int n = HeapSize;

			if (leftIndex < n && array[leftIndex] > array[i])
				largestIndex = leftIndex;
			else
				largestIndex = i;

			if (rightIndex < n && array[rightIndex] > array[largestIndex])
				largestIndex = rightIndex;

			if (i != largestIndex)
			{
				Swap(ref array[i], ref array[largestIndex]);
				MaxHeapify(array, largestIndex);
			}
		}

		private static void BuildMaxHeap(int[] array)
		{
			HeapSize = array.Length;
			for (int i = (array.Length - 1) / 2; i >= 0; i--)
				MaxHeapify(array, i);
		}

		/// <summary>
		/// i is 0 based.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		private static int MaxHeapParent(int i)
		{
			return (i + 1) / 2 + 1;
		}

		private static int MaxHeapLeft(int i)
		{
			return (i + 1) * 2 - 1;
		}

		private static int MaxHeapRight(int i)
		{
			return (i + 1) * 2;
		}
		#endregion

		#region Merge Sort
		public static void MergeSort(int[] array)
		{
			//MergeSortWithOneMoreArray(array);
			MergeSortSimplerMain(array);
		}

		#region Simpler version
		public static void MergeSortSimplerMain(int[] array)
		{
			int[] result = MergeSortSimpler(array);
			CopyPartialArray(array, result, 0, array.Length);
		}

		public static int[] MergeSortSimpler(int[] array)
		{
			if (array == null || array.Length == 0 || array.Length == 1)
				return array;
			
			int mid = (array.Length - 1) / 2;
			int[] arrayL = new int[mid + 1];
			CopyPartialArray(arrayL, array, 0, mid + 1);
			int[] arrayR = new int[array.Length - mid - 1];
			CopyPartialArray(arrayR, array, mid + 1, array.Length - mid - 1);

			arrayL = MergeSortSimpler(arrayL);
			arrayR = MergeSortSimpler(arrayR);

			return MergeSimpler(arrayL, arrayR);
		}

		private static int[] MergeSimpler(int[] arrayL, int[] arrayR)
		{
			if (arrayL == null || arrayL.Length == 0)
				return arrayR;
			if (arrayR == null || arrayR.Length == 0)
				return arrayL;

			int[] result = new int[arrayL.Length + arrayR.Length];
			int i = 0;
			int j = 0;
			int k = 0;
			while (i < arrayL.Length && j < arrayR.Length)
			{
				if (arrayL[i] < arrayR[j])
					result[k++] = arrayL[i++];
				else
					result[k++] = arrayR[j++];
			}

			while (i < arrayL.Length)
				result[k++] = arrayL[i++];
			while (j < arrayR.Length)
				result[k++] = arrayR[j++];

			return result;
		}

		private static void CopyPartialArray(int[] CopyTo, int[] origArray, int startIndex, int len)
		{
			for (int i = startIndex, j = 0; i < startIndex + len; i++, j++)
			{
				CopyTo[j] = origArray[i];
			}
		}
		#endregion

		#region With only one additional array
		public static void MergeSortWithOneMoreArray(int[] array)
		{
			int n = array.Length;
			int[] workingArray = new int[n];
			int s = 1;
			while (s < n)
			{
				MergePass(array, workingArray, s, n);
				s += s;
				MergePass(workingArray, array, s, n);
				s += s;
			}
		}

		/// <summary>
		/// Merge two arrays of size s
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="s"></param>
		/// <param name="n"></param>
		private static void MergePass(int[] x, int[] y, int s, int n)
		{
			int i = 0;
			while (i <= n - 2 * s)
			{
				Merge(x, y, i, i + s - 1, i + 2 * s - 1);
				i = i + 2 * s;
			}

			if (i + s < n)
				Merge(x, y, i, i + s - 1, n - 1);
			else
				for (int j = i; j < n; j++)
					y[j] = x[j];
		}

		/// <summary>
		/// Merge c[l:m] and c[m+1:r] to d[l:r]
		/// </summary>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <param name="l"></param>
		/// <param name="m"></param>
		/// <param name="r"></param>
		private static void Merge(int[] c, int[] d, int l, int m, int r)
		{
			int i = l,
				j = m + 1,
				k = l;

			while (i <= m && j <= r)
			{
				if (c[i] <= c[j])
					d[k++] = c[i++];
				else
					d[k++] = c[j++];
			}
			if (i > m)
				for (int q = j; q <= r; q++)
					d[k++] = c[q];
			else
				for (int q = i; q <= m; q++)
					d[k++] = c[q];
		}
		#endregion
		#endregion

		#region Quick Sort
		public static void QuickSort(int[] array)
		{
			QuickSortMain(array, 0, array.Length - 1);
		}

		private static void QuickSortMain(int[] array, int l, int u)
		{
			if (l < u)
			{
				int M = QSortPartition(array, l, u);
				QuickSortMain(array, l, M - 1);
				QuickSortMain(array, M+1, u);
			}
		}

		private static int QSortPartition(int[] array, int l, int u)
		{
			//Randomly choose an element and swap it with the one with lowest index
			Random ran = new Random();
			int ranIdx = ran.Next(u - l) + l;
			Swap(ref array[l], ref array[ranIdx]);

			int M = l;
			int val = array[M];
			for (int i = l + 1; i <= u; i++)
			{
				if (array[i] < val)
				{
					M++;
					Swap(ref array[i], ref array[M]);
				}
			}
			Swap(ref array[l], ref array[M]);
			return M;
		}
		#endregion

		#region Counting Sort
		/// <summary>
		/// For each input element x, the functions determins the number of elements 
		/// less or equal than x. This information can be used to place element x directly
		/// into its position in the output array.
		/// </summary>
		/// <param name="array"></param>
		public static void CountingSort(int[] array)
		{
			int n = array.Length;
			int rangeUpperBound = 20;
			int[] countsArray = new int[rangeUpperBound + 1];//0...20
			int[] sortedArray = new int[array.Length];

			for(int i = 0; i <= rangeUpperBound; i++)
				countsArray[i] = 0;

			for (int i = 0; i < n; i++)
				countsArray[array[i]] += 1;

			for (int i = 1; i <= rangeUpperBound; i++)
				countsArray[i] += countsArray[i - 1];

			for (int i = n - 1; i >= 0; i--)
			{
				sortedArray[countsArray[array[i]]-1] = array[i];
				countsArray[array[i]]--;
			}

			for(int i = 0; i < n; i++)
				array[i] = sortedArray[i];
		}
		#endregion

		#region Radix Sort
		private class RadixSortElement
		{
			public int OrigNum;
			public int CurrDigit;
			public int TotalDigits;

			public RadixSortElement(int num)
			{
				OrigNum = num;
				
				if (OrigNum == 0)
					TotalDigits = 1;
				else
				{
					TotalDigits = 0;
					while (num != 0)
					{
						TotalDigits++;
						num /= 10;
					}
				}

				SetCurrDigit(1);
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="digitPlace">starts from 1 for the least significant digit</param>
			public void SetCurrDigit(int digitPlace)
			{
				if (digitPlace < 1) 
				{
					throw new Exception("Incorrect digit place. It must be greater than or equal to 1");
				}
				if (digitPlace > TotalDigits)
				{
					CurrDigit = 0;
					return;
				}
				int divider = Convert.ToInt32(Math.Pow(10, digitPlace));
				CurrDigit = (OrigNum % divider) / (divider / 10);
			}
		}

		public static void RadixSort(int[] array)
		{
			int n = array.Length;
			int maxDigits = -1;

			RadixSortElement[] sortedArray = new RadixSortElement[n];
			for (int i = 0; i < n; i++)
			{
				sortedArray[i] = new RadixSortElement(array[i]);
				if (sortedArray[i].TotalDigits > maxDigits)
					maxDigits = sortedArray[i].TotalDigits;
			}

			for (int i = 1; i <= maxDigits; i++)
			{
				for(int j = 0; j < n; j++)
					sortedArray[j].SetCurrDigit(i);

				CountingSortForRadixSortElement(sortedArray);
			}

			for (int i = 0; i < n; i++)
			{
				array[i] = sortedArray[i].OrigNum;
			}
		}

		private static void CountingSortForRadixSortElement(RadixSortElement[] array)
		{
			int n = array.Length;
			int rangeUpperBound = 10;
			int[] countsArray = new int[rangeUpperBound + 1];//0...10
			RadixSortElement[] sortedArray = new RadixSortElement[n];

			for (int i = 0; i <= rangeUpperBound; i++)
				countsArray[i] = 0;

			for (int i = 0; i < n; i++)
				countsArray[array[i].CurrDigit] += 1;

			for (int i = 1; i <= rangeUpperBound; i++)
				countsArray[i] += countsArray[i - 1];

			for (int i = n - 1; i >= 0; i--)
			{
				sortedArray[countsArray[array[i].CurrDigit] - 1] = array[i];
				countsArray[array[i].CurrDigit]--;
			}

			for (int i = 0; i < n; i++)
				array[i] = sortedArray[i];
		}
		#endregion

		#region Bucket Sort
		public static void BucketSort(int[] array)
		{
			int numOfBuckets = 5;
			LinkedList[] buckets = new LinkedList[numOfBuckets];
			for (int i = 0; i < numOfBuckets; i++)
				buckets[i] = new LinkedList();

			int n = array.Length;

			for (int i = 0; i < n; i++)
			{
				int bucketIdx = array[i] / 10;
				buckets[bucketIdx].Insert(array[i]);
			}

			for (int i = 0; i < numOfBuckets; i++)
				buckets[i].Sort();

			int next = 0;
			for (int i = 0; i < numOfBuckets; i++)
			{
				ListNode curr = buckets[i].Head;
				
				while (curr != null)
				{
					array[next] = curr.Value;
					curr = curr.Next;
					next++;
				}
			}
		}
		#endregion

		#region Bitmap Sort
		private static int BITSPERWORD = 32;
		private static int BITMAPMAXVAL = 320;
		private static int SHIFT = 5; //2 ^ 5 = 32
		private static int MASK = 0x1F; //11111 in binary(for the last 5 bits in an integer). 31 in decimal
		private static int[] bitmap = new int[BITMAPMAXVAL / BITSPERWORD];

		public static void BitmapSort(int[] array)
		{
			int n = array.Length;
			for (int i = 0; i < BITMAPMAXVAL; i++)
				clr(i);

			for (int i = 0; i < n; i++)
				set(array[i]);

			int next = 0;
			for (int i = 0; i < BITMAPMAXVAL; i++)
			{
				if (test(i))
				{
					array[next] = i;
					next++;
				}
			}
		}

		private static void set(int i)
		{
			bitmap[i >> SHIFT] |= (1 << (i & MASK));
		}

		private static void clr(int i)
		{
			bitmap[i >> SHIFT] &= ~(1 << (i & MASK));
		}

		private static bool test(int i)
		{
			return ((bitmap[i >> SHIFT] & (1 << (i & MASK))) != 0);
		}
		#endregion

		#region Helpers
		/// <summary>
		/// Swap two array elements
		/// </summary>
		/// <param name="val1"></param>
		/// <param name="val2"></param>
		private static void Swap(ref int val1, ref int val2)
		{
			int tmp = val1;
			val1 = val2;
			val2 = tmp;
		}

		public static string DisplayArray(int[] array)
		{
			StringBuilder strBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				strBuilder.Append(array[i].ToString() + " ");
			}
			return strBuilder.ToString();
		}

		public static void DisplaySortingResults(int[] origArr, int[] sortedArr, string sortMethod)
		{
			StringBuilder strBuilder = new StringBuilder();

			strBuilder.Append("****" + sortMethod + "****\n");
			strBuilder.Append("Original Array : \n");
			for (int i = 0; i < origArr.Length; i++)
			{
				strBuilder.Append(origArr[i].ToString() + " ");
			}

			strBuilder.Append("\nSorted Array : \n");
			for (int j = 0; j < sortedArr.Length; j++)
			{
				strBuilder.Append(sortedArr[j].ToString() + " ");
			}

			System.Windows.Forms.MessageBox.Show(strBuilder.ToString());
		}

		#endregion

	}
}
