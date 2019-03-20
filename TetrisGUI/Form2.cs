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

        private bool playerOne = true;
        private GameManager gameManager;
        private List<Button> buttons;


        public Form2()
        {
            InitializeComponent();
            //Console.WriteLine(Form1.numCols);
            this.FormClosing += Form2_FormClosing;
            gameManager = new GameManager(numRows, numCols);

            buttons = new List<Button>();
            Button newButton;
            for(int i = 0; i < numCols; i++)
            {
                newButton = AddButton(i);
                buttons.Add(newButton);
                this.Controls.Add(newButton);
                newButton.Click += new EventHandler(this.OnButtonClick);
            }
            switchColor();
        }

        private Button AddButton(int inp)
        {
            int i = inp + 1;
            Button b = new Button();
            b.Name = "Button" + i;
            b.Text = i.ToString();
            b.Width = panel1.Width / numCols - 10;
            b.Height = b.Width / 2;
            b.Left = panel1.Left + 75 * (i-1) + 5;
            b.Top = panel1.Bottom + 10;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.BringToFront();
            return b;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button active = (Button)sender;
            playerOne = !playerOne;
            switchColor();
            int i = Int32.Parse(active.Text);
            int outcome = IOManager.NewMove(i, gameManager, playerOne);
            this.Refresh();
            if (outcome == -1)
            {
                MessageBox.Show("Column full, pick another");
                playerOne = !playerOne;
                switchColor();
            } else if (outcome == 1)
            {
                this.Refresh();
                MessageBox.Show("Player 1 Wins!");
                Application.Exit();
            } else if (outcome == 2)
            {
                MessageBox.Show("Player 2 Wins!");
                Application.Exit();
            }
            this.Refresh();
        }

        public void switchColor()
        {

            for(int i = 0; i < numCols; i++)
            {
                if (!playerOne)
                {
                    buttons[i].BackColor = Color.Red;
                    buttons[i].ForeColor = Color.Black;
                } else
                {
                    buttons[i].BackColor = Color.Black;
                    buttons[i].ForeColor = Color.White;
                }
            }
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

            int[,] gameState = gameManager.ToDraw();

            Graphics g = panel1.CreateGraphics();
            for (int x = 1; x <= numCols + 1; x++)
            {
                for (int y = 1; y <= numRows; y++)
                {
                    Rectangle rect = new Rectangle((x - 1) * colWidth, (y - 1) * colHeight, colWidth, colHeight);
                    if(gameState[(numRows + 1) - y, x] == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Red);
                        g.FillEllipse(brush, rect);
                    } else if(gameState[(numRows + 1) - y,x] == 2)
                    {
                        SolidBrush brush = new SolidBrush(Color.Black);
                        g.FillEllipse(brush, rect);
                    }
                    g.DrawRectangle(Pens.Black, rect);
                }
            }
        }

        //TODO: Implement save/load

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuNewGame_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            newGame.Show();
        }

        private void MenuSaveGame_Click(object sender, EventArgs e)
        {
            saveGame.ShowDialog();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }
    }
}
