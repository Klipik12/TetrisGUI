using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGUI
{
    public partial class Form2 : Form
    {
        public int numCols = Form1.numCols;
        public int numRows = Form1.numRows;
        public void switchColor()
        {
            if (BtCol1.BackColor == Color.Red)
            {
                BtCol1.BackColor = Color.Blue;
                BtCol2.BackColor = Color.Blue;
                BtCol3.BackColor = Color.Blue;
                BtCol4.BackColor = Color.Blue;
                BtCol5.BackColor = Color.Blue;
                BtCol6.BackColor = Color.Blue;
                BtCol7.BackColor = Color.Blue;
            }
            else
            {
                BtCol1.BackColor = Color.Red;
                BtCol2.BackColor = Color.Red;
                BtCol3.BackColor = Color.Red;
                BtCol4.BackColor = Color.Red;
                BtCol5.BackColor = Color.Red;
                BtCol6.BackColor = Color.Red;
                BtCol7.BackColor = Color.Red;

            }
        }
        public Form2()
        {
            InitializeComponent();
            //Console.WriteLine(Form1.numCols);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //tableLayoutPanel1.BackColor = Color.Aqua;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw The Board
            int colWidth = (int)(panel1.Width / numCols);
            int colHeight = (int)(panel1.Height / numRows);
            Graphics g = panel1.CreateGraphics();
            for (int x = 0; x <= numCols; x++)
            {
                for (int y = 0; y < numRows; y++)
                {
                    g.DrawRectangle(Pens.Black, x * colWidth, y * colHeight, colWidth, colHeight);
                }
            }
        }

        private void BtCol1_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtCol2_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtCol3_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtCol4_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtCol5_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtCol6_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtCol7_Click(object sender, EventArgs e)
        {
            switchColor();
        }

        private void BtQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSaveQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saving...");
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
