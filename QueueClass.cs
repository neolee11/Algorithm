using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class QueueClass
	{
		private int mMaxSlot;
		private int[] mQueue;
		private int head;
		private int count;

		public QueueClass():this(5)
		{
		}

		public QueueClass(int size)
		{
			mMaxSlot = size;
			mQueue = new int[mMaxSlot];
			head = 0;
			count = 0;
		}

		public bool IsEmpty()
		{
			return count == 0;
		}

		public bool IsFull()
		{
			return count == mMaxSlot;
		}

		public int HeadValue()
		{
			return IsEmpty() ? -100 : mQueue[head];
		}

		public int HeadIndex()
		{
			return head;
		}

		public int TailValue()
		{
			return IsEmpty() ? -100 : mQueue[TailIndex()];
		}

		public int TailIndex()
		{
			return (head + count - 1) % mMaxSlot;
		}

		public bool Enqueue(int val)
		{
			if (IsFull()) return false;
			mQueue[(TailIndex() + 1) % mMaxSlot] = val;
			count++;
			return true;
		}

		public bool Dequeue(ref int retVal)
		{
			if (IsEmpty()) return false;
			retVal = mQueue[head];
			head = (head + 1) % mMaxSlot;
			count--;
			return true;
		}

		public string Print()
		{
			string content = "";
			int i = 0;
			while (i < count)
			{
				content = content + " " + mQueue[(head + i) % mMaxSlot];
				i++;
			}
			return content;
		}

		public string PrintArray()
		{
			string msg = "Index : \t";
			for (int i = 0; i < mMaxSlot; i++)
				msg = msg + i.ToString() + "\t";

			msg = msg + "\nArray : \t";
			for (int i = 0; i < mMaxSlot; i++)
				msg = msg + mQueue[i].ToString() + "\t";

			msg = msg + "\n       \t";
			for (int i = 0; i < mMaxSlot; i++)
				if (i == HeadIndex())
					msg = msg + "h\t";
				else
					msg = msg + "\t";

			msg = msg + "\n       \t";
			for (int i = 0; i < mMaxSlot; i++)
				if (i == TailIndex())
					msg = msg + "t\t";
				else
					msg = msg + "\t";

			return msg;
		}
	}
}
