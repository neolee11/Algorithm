using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithms
{
	public class DPTaskAssignmentsClass
	{
		private int n; //Total tasks
		private int m;
		private int mn;

		private int[] a; //machine A
		private int[] b; //machine B
		private bool[,,] p;
		private int opt = 0;

		public string TaskAssignments(string input)
		{
			TaskAssignmentsInit(input);
			return dyna();
		}

		private void TaskAssignmentsInit(string input)
		{
			StringReader sr = new StringReader(input);
			
			n = Convert.ToInt32(sr.ReadLine());
			m = 0;

			string[] aInputs = sr.ReadLine().Split(new char[]{' '});
			a = new int[n];
			for (int i = 0; i < n; i++)
			{
				a[i] = Convert.ToInt32(aInputs[i]);
				if (a[i] > m)
					m = a[i];
			}

			string[] bInputs = sr.ReadLine().Split(new char[] { ' ' });
			b = new int[n];
			for (int i = 0; i < n; i++)
			{
				b[i] = Convert.ToInt32(bInputs[i]);
				if (b[i] > m)
					m = b[i];
			}

			mn = m * n;
			p = new bool[mn+1, mn+1, n+1];
		}

		private string dyna()
		{
			int i, j, k;

			for(i = 0; i <= mn; i++)
				for (j = 0; j <= mn; j++)
				{
					p[i,j,0] = true;
					for (k = 1; k <= n; k++)
						p[i, j, k] = false;
				}

			for(k = 1; k <= n; k++)
				for(i = 0; i <= mn; i++)
					for (j = 0; j <= mn; j++)
					{
						if (i - a[k - 1] >= 0) p[i,j,k] = p[i - a[k - 1], j, k - 1];
						if (j - b[k - 1] >= 0) p[i,j,k] = (p[i,j,k] || p[i, j-b[k-1], k-1]);
					}

			for(i =0, opt = mn; i <= mn; i++)
				for (j = 0; j <= mn; j++)
					if (p[i, j, n])
					{
						int tmp = (i > j) ? i : j;
						if (tmp < opt) opt = tmp;
					}

			return opt.ToString() ;
		}
	}
}
