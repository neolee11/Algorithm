using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
	public class DPAssemblyLineSchedulingClass
	{
		private int TotalAssemblyLines;
		private int StationsPerLine;
		private int[,] StationTime;
		private int[,] TransferTime;
		private int[] EnterTime;
		private int[] ExitTime;

		private int[,] f;
		private int[,] l;

		private int optF;
		private int optL;

		public DPAssemblyLineSchedulingClass()
		{
		}

		public string DP()
		{
			InitInput();
			FastestWay();
			return OutputResult();
		}

		private void InitInput()
		{
			TotalAssemblyLines = 2;
			StationsPerLine = 6;

			EnterTime = new int[TotalAssemblyLines + 1];
			EnterTime[1] = 2; //Enter Assembly line 1 time cost
			EnterTime[2] = 4; //Enter Assembly line 2 time cost

			ExitTime = new int[TotalAssemblyLines + 1];
			ExitTime[1] = 3; //Exit Assembly line 1 time cost
			ExitTime[2] = 2; //Exit Assembly line 2 time cost

			StationTime = new int[TotalAssemblyLines + 1, StationsPerLine + 1];
			StationTime[1, 1] = 7;
			StationTime[1, 2] = 9;
			StationTime[1, 3] = 3;
			StationTime[1, 4] = 4;
			StationTime[1, 5] = 8;
			StationTime[1, 6] = 4;

			StationTime[2, 1] = 8;
			StationTime[2, 2] = 5;
			StationTime[2, 3] = 6;
			StationTime[2, 4] = 4;
			StationTime[2, 5] = 5;
			StationTime[2, 6] = 7;

			//[1,1] means Transfer Time from station 1,1 to station 2,2. Station only going forward.
			TransferTime = new int[TotalAssemblyLines + 1, StationsPerLine];
			TransferTime[1, 1] = 2;
			TransferTime[1, 2] = 3;
			TransferTime[1, 3] = 1;
			TransferTime[1, 4] = 3;
			TransferTime[1, 5] = 4;

			TransferTime[2, 1] = 2;
			TransferTime[2, 2] = 1;
			TransferTime[2, 3] = 2;
			TransferTime[2, 4] = 2;
			TransferTime[2, 5] = 1;

			f = new int[TotalAssemblyLines + 1, StationsPerLine + 1];
			for (int i = 0; i <= TotalAssemblyLines; i++)
				for (int j = 0; j <= StationsPerLine; j++)
					f[i, j] = 0;

			l = new int[TotalAssemblyLines + 1, StationsPerLine + 1];
			for (int i = 0; i <= TotalAssemblyLines; i++)
				for (int j = 0; j <= StationsPerLine; j++)
					l[i, j] = 0;
		}

		private void FastestWay()
		{
			f[1, 1] = EnterTime[1] + StationTime[1, 1];
			f[2, 1] = EnterTime[2] + StationTime[2, 1];

			for (int j = 2; j <= StationsPerLine; j++)
			{
				if (f[1, j - 1] <= f[2, j - 1] + TransferTime[2, j - 1])
				{
					f[1, j] = f[1, j-1] + StationTime[1, j];
					l[1, j] = 1;
				}
				else
				{
					f[1, j] = f[2, j - 1] + TransferTime[2, j - 1] + StationTime[1, j];
					l[1, j] = 2;
				}

				if (f[2, j - 1] <= f[1, j - 1] + TransferTime[1, j - 1])
				{
					f[2, j] = f[2, j - 1] + StationTime[2, j];
					l[2, j] = 2;
				}
				else
				{
					f[2, j] = f[1, j - 1] + TransferTime[1, j - 1] + StationTime[2, j];
					l[2, j] = 1;
				}
			}

			if (f[1, StationsPerLine] + ExitTime[1] <= f[2, StationsPerLine] + ExitTime[2])
			{
				optF = f[1, StationsPerLine] + ExitTime[1];
				optL = 1;
			}
			else
			{
				optF= f[2, StationsPerLine] + ExitTime[2];
				optL = 2;
			}
		}

		private string OutputResult()
		{
			string msg = "Min Time : " + optF.ToString() + "\n\n";
			msg = msg + PrintStations();
			return msg;
		}

		private string PrintStations()
		{
			string msg = "Path : \n";;

			int i = optL;
			msg = msg + "line " + i.ToString() + ", station " + StationsPerLine.ToString() + "\n";
			for (int j = StationsPerLine; j >= 2; j--)
			{
				i = l[i, j];
				msg = msg + "line " + i.ToString() + ", station " + Convert.ToString(j-1) + "\n";
			}

			return msg;
		}
	}
}
