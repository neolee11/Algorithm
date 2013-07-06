using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    #region "Find Equilibrum index in an array"
    public class FindEquiSolution
    {
        public int equi(int[] A)
        {
            if (A == null || A.Length == 0) return -1;
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            int currLeft = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int currRight = sum - currLeft - A[i];
                //currTotal += A[i];
                if (currLeft == currRight)
                    return i;
                currLeft += A[i];
            }
            return -1;
        }
    }
    #endregion

    #region "Find Extreme"
    public class FindExtreme
    {
        public int extreme(int[] A)
        {
            if (A == null || A.Length == 0)
                return -1;

            float mean = 0;
            bool extremeExists = false;
            for (int i = 0; i < A.Length; i++)
            {
                if(!extremeExists && i > 0){
                    if(A[i] != A[i - 1]) extremeExists = true; //extreme exists only when not all numbers are equal
                }
                mean = mean + A[i] / A.Length; //To Avoid overflow of adding up all the numbers in the array
            }

            if(!extremeExists) return -1;
                
            float extreme = 0;
            int extremIndex = 0;
            float currDeviation;
            for (int i = 0; i < A.Length; i++)
            {
                currDeviation = Math.Abs(A[i] - mean);
                if (currDeviation > extreme)
                {
                    extreme = currDeviation;
                    extremIndex = i;
                }
            }
            return extremIndex;
        }
    }
    #endregion

    #region "Find Distinct Elemetn"
    //PROBLEM STATEMENT
    //Write a function
    //    class Solution { int distinct(int[] A); } 
    //that, given a zero-indexed array A consisting of N integers, returns the number of distinct values in array A.
    //Assume that:
    //        N is an integer within the range [0..100,000];
    //        each element of array A is an integer within the range [?1,000,000..1,000,000].
    //For example, given array A consisting of six elements such that:
    //    A[0] = 2    A[1] = 1    A[2] = 1
    //    A[3] = 2    A[4] = 3    A[5] = 1
    //the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.
    //Complexity:
    //        expected worst-case time complexity is O(N*log(N));
    //        expected worst-case space complexity is O(1), beyond input storage (not counting the storage required for input arguments).
    //Elements of input arrays can be modified.
    public class FindDistinct
    {
        public int distinct(int[] A)
        {
            if (A == null || A.Length == 0) return 0;
            
            HeapSort(A);
            int numDistnct = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1]) numDistnct++;
            }
            return numDistnct;
        }

        //Heap Sort: nlog(n) in-place sorting algorithm
        private int HeapSize;
        private void HeapSort(int[] array)
        {
            BuildMaxHeap(array);
            for (int i = (array.Length - 1); i > 0; i--)
            {
                Swap(ref array[i], ref array[0]);
                HeapSize--;
                MaxHeapify(array, 0);
            }
        }

        private void BuildMaxHeap(int[] array)
        {
            HeapSize = array.Length;
            for (int i = (array.Length - 1) / 2; i >= 0; i--)
                MaxHeapify(array, i);
        }

        private void MaxHeapify(int[] array, int i)
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

        private int MaxHeapLeft(int i)
        {
            return (i + 1) * 2 - 1;
        }

        private int MaxHeapRight(int i)
        {
            return (i + 1) * 2;
        }

        private void Swap(ref int val1, ref int val2)
        {
            int tmp = val1;
            val1 = val2;
            val2 = tmp;
        }
    }
    #endregion

    #region "Determin String Properly Nested"
    //PROBLEM STATEMENT
//    A string S consisting of N characters is called properly nested if:
//        S is empty;
//        S has the form "(U)" where U is a properly nested string;
//        S has the form "VW"
//where V and W are properly nested strings.
//For example, string "(()(())())" is properly nested but string "())" isn't.
//Write a function
//    class Solution { int nesting(string S); } 
//that, given a string S consisting of N characters, returns 1 if string S is properly nested and 0 otherwise.
//Assume that:
//        N is an integer within the range [0..1,000,000];
//        string S consists only of the following characters: ( and/or ).
//For example, given S = "(()(())())", the function should return 1 and given S = "())", the function should return 0, as explained above.
//Complexity:
//        expected worst-case time complexity is O(N);
//        expected worst-case space complexity is O(1) (not counting the storage required for input arguments).
    public class ProperlyNestedString
    {
        public int nesting(string S)
        {
            if (S == null || S.Length == 0) return 1;

            int level = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (level < 0) return 0;

                if (S[i] == '(') level++;
                else if (S[i] == ')') level--;
                else return 0; //invalid character
            }

            return level == 0 ? 1 : 0; 
        }
    }
    #endregion

    #region "Tree Height"
//PROBLEM STATEMENT
//    A pointer is called a binary tree if:
//        it is an empty pointer (it is then called a leaf or an empty tree); or
//        it points to a structure (called a node or the root) that contains a value and two binary trees (called the left subtree and the right subtree).
//A path of length K in a binary tree is a sequence of nodes P[0], P[1], ..., P[K] such that node P[L + 1] is pointed to by a subtree of node P[L] for 0 ¡Ü L < K.
//The height of a binary tree is defined as the length of the longest possible path in the tree. In particular, a tree consisting only of a root node has height 0 and the height of an empty tree is undefined.

//For example, consider the following tree:
//Node A is the root of the tree. Subtrees of nodes D, E and F are empty trees. Sequence A, B, E is a path of length 2. 
//Sequence C, F is a path of length 1. Sequence E, B, D is not a valid path. The height of this tree is 2.

//Write a function:
//    class Tree {
//      public int x;
//      public Tree l;
//      public Tree r;
//    }
//    class Solution { public int treeHeight(Tree T); } 
//that, given a non-empty binary tree T consisting of N nodes, returns its height.

//For example, given tree T shown in the example above, the function should return 2.

//Assume that:
//        N is an integer within the range [1..1,000,000].
//Complexity:
//        expected worst-case time complexity is O(N);
//        expected worst-case space complexity is O(N).

    public class Tree
    {
        public int x;
        public Tree left;
        public Tree right;
    }

    public class TreeHeight
    {
        public int treeHeight(Tree T)
        {

            if (T == null) return 0;
            int leftHeight = 0;
            if (T.left != null)
                leftHeight = 1 + treeHeight(T.left);
            int rightHeight = 0;
            if (T.right != null)
                rightHeight = 1 + treeHeight(T.right);

            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }
    }
    #endregion 

    #region "Magnitude Pole"
    public class MagnitudePole
    {
        public int magnitubePole(int[] A)
        {
            if (A == null || A.Length == 0) return -1;

            int poleIndex = 0;
            int maxIndex = 0;
            bool havePole = true;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < A[poleIndex])
                    havePole = false;

                if (A[i] >= A[maxIndex])
                {
                    maxIndex = i;
                    if (!havePole)
                    {
                        poleIndex = i;
                    }
                    havePole = true;
                }
            }

            return havePole ? poleIndex : -1;
        }
    }

    #endregion

    public class CycleLengthSolution
    {
        public int cycle_length(int[] A)
        {
            if (A == null || A.Length == 0)
                return 0;

            int indexFast = 0;
            int indexSlow = 0;
            int cycleLen = 0;
            int loopStartIndex = 0;

            do
            {
                indexFast = A[indexFast];
                indexFast = A[indexFast];
                indexSlow = A[indexSlow];
            } while (indexFast != indexSlow);

            indexFast = 0;
            while (indexFast != indexSlow)
            {
                indexFast = A[indexFast];
                indexSlow = A[indexSlow];                
            }
            loopStartIndex = indexFast;

            do
            {
                loopStartIndex = A[loopStartIndex];
                cycleLen++;
            } while (loopStartIndex != indexFast);

            return cycleLen;
        }
    }
}
