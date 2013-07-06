using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class DPLCSClass
    {
        private string mStr1 = "";
        private string mStr2 = "";

        private const int addXY = 0;
        private const int useX = 1;
        private const int useY = 2;

        public DPLCSClass(string str1, string str2){
            mStr1 = str1;
            mStr2 = str2;
        }

        public string Solve(){
            if (mStr1 == "" || mStr2 == "")
            {
                return "";
            }

            string result = "";


            int len1 = mStr1.Length;
            int len2 = mStr2.Length;

            int [,] c = new int[len1 + 1, len2 + 1];
            int [,] track  = new int[len1+1, len2+1];

            for (int i = 0; i <= len1; i++){
                c[i, 0] = 0;
                track[i, 0] = useX;
            }

            for (int j = 0; j <= len2; j++){
                c[0, j]= 0;
                track[0, j] = useY;
            }

            for (int i = 1; i <= len1; i++)
            {
                for (int j = 1; j <= len2; j++)
                {
                    int str1Index = i - 1;
                    int str2Index = j - 1;
                    if (mStr1[str1Index] == mStr2[str2Index])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                        track[i, j] = addXY;
                    }
                    else
                    {
                        if (c[i, j - 1] >= c[i - 1, j])
                        {
                            c[i, j] = c[i, j - 1];
                            track[i, j] = useY;
                        }
                        else //c[i, j-1] >= c[i - 1, j]
                        {
                            c[i, j] = c[i - 1, j];
                            track[i, j] = useX;
                        }
                    }

                }
            }

            result = getLCS(mStr1, mStr2, track);
            return result;
        }

        private string getLCS(string str1, string str2, int[,] track){

            string result = "";
            int i = track.GetLength(0) - 1;
            int j = track.GetLength(1) - 1;
            while(i > 0 && j > 0){
                switch (track[i, j])
                {
                    case addXY:
                        result = str1[i - 1] + result;
                        i--;
                        j--;
                        break;
                    case useX:
                        i--;
                        break;
                    case useY:
                        j--;
                        break;
                }
            }
            return result;
        }
    }
}
