using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class LinkedList
	{
		private ListNode mHead;
		public ListNode Head
		{
			get { return mHead; }
		}

		public LinkedList()
		{
			mHead = null;
		}

		public void Insert(int value)
		{
			if (mHead == null)
			{
				mHead = new ListNode(value);
				return;
			}

			ListNode newNode = new ListNode(value);
			ListNode curr = mHead;
			while (curr.Next != null)
			{
				curr = curr.Next;
			}
			curr.Next = newNode;
		}

		public ListNode Search(int value)
		{
			ListNode curr = mHead;
			while (curr != null)
			{
				if (curr.Value == value)
					return curr;
				curr = curr.Next;
			}
			return curr;
		}

		public void Delete(int value)
		{
			if (mHead == null)
				return;

			ListNode curr = mHead;
			ListNode prev = null;

			while (curr != null)
			{
				if (curr.Value == value)
				{
					if (curr == mHead)
						mHead = mHead.Next;
					else
						prev.Next = curr.Next;
					return;
				}

				prev = curr;
				curr = curr.Next;
			}
		}

		public void Sort()
		{
			if (mHead == null || mHead.Next == null)
				return;

			ListNode newHead = null;
			ListNode curr = mHead;

			while (curr != null)
			{
				InsertIntoSortedList(ref newHead, curr.Value);
				curr = curr.Next;
			}

			mHead = newHead;
		}

		public void InsertIntoSortedList(ref ListNode headNode, int value)
		{
			if (headNode == null)
			{
				headNode = new ListNode(value);
				return;
			}

			ListNode newNode = new ListNode(value);
			if (value < headNode.Value)
			{
				newNode.Next = headNode;
				headNode = newNode;
				return;
			}

			ListNode curr = headNode;
			while (curr.Next != null)
			{
				if (value < curr.Next.Value)
				{
					newNode.Next = curr.Next;
					curr.Next = newNode;
					return;
				}
				curr = curr.Next;
			}
			curr.Next = newNode;
		}

		public void Reverse()
		{
			if (mHead == null || mHead.Next == null)
				return;

			ListNode prev = null;
			ListNode tmp = null;
			while(mHead != null)
			{
				tmp = mHead.Next;
				mHead.Next = prev;
				prev = mHead;
				mHead = tmp;
			}
			mHead = prev;
		}

		public void Clear()
		{
			mHead = null;
		}

		public string PrintList()
		{
			string msg = "";
			ListNode curr = mHead;
			while (curr != null)
			{
				msg = msg + curr.Value.ToString() + "  ";
				curr = curr.Next;
			}
			return msg;
		}
	}

	public class ListNode
	{
		private int mValue;
		private ListNode mNext;

		public int Value
		{
			get { return mValue; }
			set { mValue = value; }
		}

		public ListNode Next
		{
			get { return mNext; }
			set { mNext = value; }
		}

		public ListNode()
		{
			mValue = 0;
			mNext = null;
		}

		public ListNode(int val)
		{
			mValue = val;
			mNext = null;
		}

		public ListNode(int val, ListNode next)
		{
			mValue = val;
			mNext = next;
		}
	}
}
