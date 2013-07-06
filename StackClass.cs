using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class StackClass
	{
		private int mMaxSlot = 5;
		private int[] mStack;
		private int nextAvailSlot = 0;

		public StackClass()
		{
			mStack = new int[mMaxSlot];
		}

		public StackClass(int size)
		{
			mMaxSlot = size;
			mStack = new int[mMaxSlot];
		}

		public bool IsEmpty()
		{
			return nextAvailSlot == 0;
		}

		public bool IsFull()
		{
			return nextAvailSlot == mMaxSlot;
		}

		public bool Push(int value)
		{
			if (IsFull()) return false;
			mStack[nextAvailSlot++] = value;
			return true;
		}

		public bool Pop(ref int retVal)
		{
			if (IsEmpty()) return false;
			retVal = mStack[--nextAvailSlot];
			return true;
		}

		public string Print()
		{
			string content = "";
			for (int i = 0; i < nextAvailSlot; i++)
				content = content + " " + mStack[i];
			return content;
		}
	}
}
