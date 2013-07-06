using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
    class CombinatoricsClass
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
                        if (splitArr[j].Trim() != "")
                            result = result + tmp.ToString() + " " + splitArr[j] + "\n";
                    }
                    Swap(ref arr[i], ref arr[l]);
                }
                return result;
            }
        }

        public static string[] Comb(string[] arr)
        {
            int n = arr.Length;
            string[] result = CombHelper(arr, 0, n - 1);
            MessageBox.Show("Total Subset: " + result.Length);
            return result;
        }

        private static string[] CombHelper(string[] arr, int l, int u)
        {
            string[] result;

            if (arr == null || l > u)
                return null;

            if (l == u)
            {
                result = new string[2];
                result[0] = arr[l];
                result[1] = "";
                return result;
            }

            string[] tmpWithout = CombHelper(arr, l + 1, u);

            string[] tmpWith = new string[tmpWithout.Length];
            for (int i = 0; i < tmpWithout.Length; i++)
                tmpWith[i] = arr[l] + tmpWithout[i];

            result = CombineArrays(tmpWith, tmpWithout);
            return result;
        }

        private static string[] CombineArrays(string[] A, string[] B)
        {
            if (A == null || A.Length == 0)
                return B;

            if (B == null || B.Length == 0)
                return A;

            int total = A.Length + B.Length;

            string[] result = new string[total];
            int i;
            for (i = 0; i < A.Length; i++)
                result[i] = A[i];

            for (int j = 0; j < B.Length; j++)
                result[i + j] = B[j];

            return result;
        }

        public static void Swap(ref int val1, ref int val2)
        {
            int tmp = val1;
            val1 = val2;
            val2 = tmp;
        }
    }
}
