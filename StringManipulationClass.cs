using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
	public class StringManipulationClass
	{
		public static char[] ReverseString(char[] src)
		{
			char[] result = CopyString(src);
			if(result == null)
				return null;

			int i = 0;
			int j = result.Length - 1;
			while(i <= j){
				char tmp = result[i];
				result[i++] = result[j];
				result[j--] = tmp;
			}

			return result;
		}

		public static string PrintCharArray(char[] src)
		{
			string msg = "";
			for (int i = 0; i < src.GetLength(0); i++){
				msg = msg + src[i];
			}

			//MessageBox.Show(msg);
			return msg;
		}

		public static char[] CopyString(char[] src)
		{
			if (src == null)
			{
				MessageBox.Show("Unable to copy string. Source array is null");
				return null;
			}

			char[] des = new char[src.GetLength(0)];
			for (int i = 0; i < src.GetLength(0); i++)
				des[i] = src[i];
			return des;
		}

		public static char[] RandomGenerateString(int length)
		{
			char[] newArray = new char[length];

			Random a = new Random();
			int asciiStart = 97; //97: lower case letters starts  65: upper case letters starts
			for (int i = 0; i < length; i++)
			{
				int n = a.Next(26);
				char c = (char)(asciiStart + n);
				newArray[i] = c;
			}

			return newArray;
		}

		public static int StrToInt(string str)
		{
			int maxLen = 10;
			if (str == null || str.Length == 0)
			{
				return int.MinValue;
			}

			if(str.Length > maxLen){
				MessageBox.Show("String is too large to be represented as integer");
				return int.MinValue;
			}

			int result = 0;

			//Handle negative part
			int stopIndex = 0;
			bool neg = false;
			if (str[stopIndex] == '-')
			{
				neg = true;
				stopIndex = 1;
			}

			//Handle fraction part
			int startIndex = str.Length - 1;
			for (int j = 0; j < str.Length; j++)
			{
				if (str[j] == '.')
				{
					if (j == 0)
						return 0;
					startIndex = j - 1;
					break;
				}
			}

			int factor = 1;
			int i = startIndex;
			while (i >= stopIndex)
			{
				int curr = str[i] - '0';
				if (curr < 0 || curr > 9)
				{
					MessageBox.Show("Wrong char: " + str[i]);
					return int.MinValue;
				}

				result += curr * factor;
				factor *= 10;
				i--;
			}

			if (neg)
				result *= -1;
			return result;
		}

		public static string IntToStr(int aInt)
		{
			bool neg = false;
			if (aInt < 0)
			{
				aInt = -aInt;
				neg = true;
			}
			char[] str = new char[11];
			int tail = -1;
			do
			{
				int curr = aInt % 10;
				char tmp = (char)('0' + curr);
				tail++;
				str[tail] = tmp;

			} while ((aInt /= 10) > 0);

			if (neg)
				str[++tail] = '-';

			string result = "";
			for (int i = tail; i >= 0; i--)
			{
				result += str[i].ToString();
			}

			//for (int i = 0, j = tail; i <= j; i++, j--)
			//{
			//    char tmp = str[i];
			//    str[i] = str[j];
			//    str[j] = str[i];
			//}

			
			return result;
		}

	}
}
