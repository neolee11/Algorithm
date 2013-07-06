using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class PyramidInterviewForm : Form
    {
        public PyramidInterviewForm()
        {
            InitializeComponent();
        }

        private void buttonDistinct_Click(object sender, EventArgs e)
        {
            int[] A = { 2, 1, 1, 2, 3, 1 , -1};
            FindDistinct solver = new FindDistinct();
            int answer = solver.distinct(A);
            MessageBox.Show("Number of distinct values: " + answer.ToString());

        }

        private void buttonNesting_Click(object sender, EventArgs e)
        {
            string S = "(()(())())";
            ProperlyNestedString solver = new ProperlyNestedString();
            int answer = solver.nesting(S);
            string ansStr = answer == 1 ? "Properly Nested" : "NOT Properly Nested";
            MessageBox.Show(ansStr);
        }

        private void buttonMagPole_Click(object sender, EventArgs e)
        {
            int[] A = { 4, 2, 2, 3, 1, 4, 7, 8, 6, 9};
            MagnitudePole solver = new MagnitudePole();
            int answer = solver.magnitubePole(A);
            MessageBox.Show("Magnitube Pole Index: " + answer.ToString());
        }

        private void buttonCycleLen_Click(object sender, EventArgs e)
        {
            int[] A = { 2, 3, 1, 1, 3 };
            //int[] A = { 4, 0, 0, 0, 6, 1, 7, 2 };
            CycleLengthSolution solver = new CycleLengthSolution();
            int answer = solver.cycle_length(A);
            MessageBox.Show("Cycle Length: " + answer.ToString());
        }
    }
}