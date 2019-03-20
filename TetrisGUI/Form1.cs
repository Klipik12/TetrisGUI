using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TetrisGUI
{

    public partial class Form1 : Form
    {
        public static int numCols;
        public static int numRows;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            numCols = Int32.Parse(txtCols.Text);
            numRows = Int32.Parse(TxtRows.Text);
            Form2 game = new Form2();
            game.Show();
            this.Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void TxtRows_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading Saved Game...");
            numCols = 7;
            numRows = 6;
            Form2 game = new Form2();
            game.Show();
            Thread.Sleep(500);
            this.Hide();
        }
    }
}
