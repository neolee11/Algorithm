using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
	public partial class SortingForm : Form
	{
		private int arrayLen = 10;

		public SortingForm()
		{
			InitializeComponent();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonBubble_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.BubbleSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Bubble Sort");
		}

		private void buttonInsertion_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.InsertionSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Insertion Sort");
		}

		private void buttonSelection_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.SelectionSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Selection Sort");
		}

		private void buttonHeap_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.HeapSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Heap Sort");
		}

		private void buttonMerge_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.MergeSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Merge Sort");
		}

		private void buttonQuick_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.QuickSort(sortedArr);
			//MessageBox.Show("Done");
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Quick Sort");
		}

		private void buttonCounting_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.CountingSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Counting Sort");
		}

		private void buttonRadix_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.RadixSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Radix Sort");
		}

		private void buttonBucket_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.BucketSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Bucket Sort");
		}

		private void buttonBitmap_Click(object sender, EventArgs e)
		{
			int[] origArr = MiscelHelperClass.RandomGenUniqueIntArray(arrayLen);
			int[] sortedArr = new int[arrayLen];
			origArr.CopyTo(sortedArr, 0);
			SortingClass.BitmapSort(sortedArr);
			SortingClass.DisplaySortingResults(origArr, sortedArr, "Bitmap Sort");
		}

		private void buttonAll_Click(object sender, EventArgs e)
		{
			string msg = "***********Sorting**************\n";

			int[] origArr = MiscelHelperClass.RandomGenerateIntArray(arrayLen);
			msg = msg + "Original Array: \n" + SortingClass.DisplayArray(origArr) + "\n";
			msg = msg + "---------------------------------------- \n\n";

			int[] sortedArr = new int[origArr.Length];
			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.BubbleSort(sortedArr);
			msg = msg + "<Bubble Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.InsertionSort(sortedArr);
			msg = msg + "<Insertion Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.SelectionSort(sortedArr);
			msg = msg + "<Selection Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.HeapSort(sortedArr);
			msg = msg + "<Heap Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.MergeSort(sortedArr);
			msg = msg + "<Merge Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.QuickSort(sortedArr);
			msg = msg + "<Quick Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.CountingSort(sortedArr);
			msg = msg + "<Counting Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.RadixSort(sortedArr);
			msg = msg + "<Radix Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			Array.Copy(origArr, sortedArr, origArr.Length);
			SortingClass.BucketSort(sortedArr);
			msg = msg + "<Bucket Sort>: \n" + SortingClass.DisplayArray(sortedArr) + "\n\n";

			MessageBox.Show(msg);
		}
	}
}