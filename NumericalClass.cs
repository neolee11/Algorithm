using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Algorithms
{
    class NumericalClass
    {
        #region "Control functions"
        //     Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   //     Dim a As Integer = 28
   //     Dim b As Integer = 42


   //     Dim myGCD As Integer = GCD(a, b)
   //     Dim myLCM As Integer = LCM(a, b)

   //     Dim msg As String = "GCD: " & myGCD.ToString() & vbCrLf & "LCM: " & myLCM.ToString() & vbCrLf & _
   //a.ToString() & " * " & b.ToString() & " = " & (a * b).ToString & vbCrLf & _
   //myGCD.ToString() & " * " & myLCM.ToString() & " = " & (myGCD * myLCM).ToString()

   //     MessageBox.Show(msg)
   //     'MessageBox.Show("GCD: " & myGCD.ToString() & vbCrLf & "LCM: " & myLCM.ToString())
   //     'MessageBox.Show(a.ToString() & " * " & b.ToString() & " = " & (a * b).ToString & vbCrLf & _
   //     ' myGCD.ToString() & " * " & myLCM.ToString() & " = " & (myGCD * myLCM).ToString())

   // End Sub

   // Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
   //     Dim upper As Integer = 20
   //     Try
   //         upper = CInt(Me.TextBoxPrimeUpper.Text)
   //     Catch ex As Exception
   //         MessageBox.Show(ex.Message)
   //     End Try

   //     Dim primes() As Integer = FindPrimes(upper)
   //     Dim msg As String = "Primes below " & upper.ToString() & vbCrLf
   //     For i As Integer = 0 To primes.Length - 1
   //         msg &= primes(i).ToString() & " "
   //     Next
   //     MessageBox.Show(msg)
        // End Sub

    // Private Function LCM(ByVal a As Integer, ByVal b As Integer) As Integer
    //    Dim larger As Integer = a
    //    If b > a Then larger = b

    //    Dim primes As Integer() = FindPrimes(larger)
    //    If primes Is Nothing Then Return 0
    //    Dim q As Integer = 1
    //    For i As Integer = 0 To primes.Length - 1
    //        Dim p As Integer = primes(i)
    //        Dim numCurrPrimeInA As Integer = 0
    //        Dim numCurrPrimeInB As Integer = 0
    //        While a Mod p = 0
    //            numCurrPrimeInA = numCurrPrimeInA + 1
    //            a = a / p
    //        End While
    //        While b Mod p = 0
    //            numCurrPrimeInB = numCurrPrimeInB + 1
    //            b = b / p
    //        End While
    //        Dim choose As Integer = numCurrPrimeInA
    //        If numCurrPrimeInB > numCurrPrimeInA Then choose = numCurrPrimeInB
    //        q = q * CInt(Math.Pow(p, choose))
    //    Next
    //    Return q
    //End Function

    //Private Function GCD(ByVal a As Integer, ByVal b As Integer) As Integer
    //    While a <> 0 AndAlso b <> 0
    //        If a > b Then
    //            a = a - b
    //        Else
    //            b = b - a
    //        End If
    //    End While
    //    If a <> 0 Then
    //        Return a
    //    Else
    //        Return b
    //    End If
    //End Function

    //Private Function FindPrimes(ByVal upperLimit As Integer) As Integer()
    //    If upperLimit < 2 Then Return Nothing

    //    Dim allNum As New BitArray(upperLimit + 1, True)
    //    allNum(0) = False
    //    allNum(1) = False

    //    Dim currTester As Integer = 2
    //    While currTester <= upperLimit
    //        While currTester <= upperLimit AndAlso allNum(currTester) = False
    //            'Optimization here
    //            'If currTester * 2 > upperLimit Then
    //            '	currTester = upperLimit + 1
    //            '	Exit While
    //            'End If
    //            currTester = currTester + 1
    //        End While
    //        If currTester > upperLimit Then Exit While
    //        Dim upperMul As Integer = CInt(upperLimit / currTester)
    //        For i As Integer = 2 To upperMul
    //            If i * currTester < allNum.Length Then
    //                allNum(i * currTester) = False
    //            End If
    //        Next
    //        currTester = currTester + 1
    //    End While

    //    Dim numPrimes As Integer = 0
    //    For i As Integer = 2 To upperLimit
    //        If allNum(i) = True Then numPrimes = numPrimes + 1
    //    Next
    //    If numPrimes = 0 Then Return Nothing

    //    Dim results(numPrimes - 1) As Integer
    //    Dim index As Integer = 0
    //    For i As Integer = 2 To upperLimit
    //        If allNum(i) = True Then
    //            results(index) = i
    //            index = index + 1
    //        End If
    //    Next
    //    Return results
    //End Function
        #endregion

        //Largest Common Multiple
        public int LCM(int a, int b)
        {
            int larger = a;
            if (b > a) larger = b;

            int[] primes = FindPrimes(larger);
            if (primes != null) return 0;
            int q = 1;
            for (int i = 0; i < primes.Length; i++)
            {
                int p = primes[i];
                int numCurrPrimeInA = 0;
                int numCurrPrimeInB = 0;
                while (a % p == 0)
                {
                    numCurrPrimeInA++;
                    a = a / p;
                }
                while (b % p == 0)
                {
                    numCurrPrimeInB++;
                    b = b / p;
                }
                int choose = numCurrPrimeInA;
                if (numCurrPrimeInB > numCurrPrimeInA) choose = numCurrPrimeInB;
                q *= (int)Math.Pow(p, choose);
            }
            return q;
        }

        //Greatest Common Divider
        public int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            if (a != 0) return a;
            else return b;
        }

        public int[] FindPrimes(int upperLimit)
        {
            if (upperLimit < 2) return null;

            BitArray allNum = new BitArray(upperLimit + 1, true);

            allNum[0] = false;
            allNum[1] = false;

            int currTester = 2;
            while (currTester <= upperLimit)
            {
                while (currTester <= upperLimit && allNum[currTester] == false)
                {
                    //Optimization here
				    //If currTester * 2 > upperLimit Then
				    //	currTester = upperLimit + 1
				    //	Exit While
				    //End If
                    currTester++;
                }
                if (currTester > upperLimit) break;
                int upperMul = (int)upperLimit / currTester;
                for(int i = 2; i <= upperMul; i++){
                    if(i * currTester < allNum.Length)
                        allNum[i * currTester] = false;
                }
                currTester++;
            }

            int numPrimes = 0;
            for (int i = 2; i <= upperLimit; i++)
                if (allNum[i] == true) numPrimes++;
            if (numPrimes == 0) return null;

            int[] results = new int[numPrimes - 1];
            int index = 0;
            for (int i = 2; i <= upperLimit; i++)
            {
                if (allNum[i] == true)
                {
                    results[index] = i;
                    index++;
                }
            }
            return results;
        }
    }
}
