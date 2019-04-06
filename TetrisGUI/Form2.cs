/// <summary>
/// Project Name: TetrisGUI
/// File Name: Form2.cs
/// Written by: Charley Bein and Ben Tipton
/// Description: Holds logic for the gameplay GUI
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace TetrisGUI
{
    public partial class Form2 : Form
    {
        
        public int numCols = Form1.numCols;
        public int numRows = Form1.numRows;

        private bool playerOne = true;
        private GameManager gameManager;
        private List<Button> buttons = null;
        private Stream stream = null;
        //Holds the turn timer current value
        private int countDownTime = 60;
        //Maximum value for resetting turn timer
        private int turnTime = 60;
        private int totalGameTime = 0;


        /// <summary>
        /// Constructor initializes the components, attaches controls, and then populates the GUI
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
            this.KeyDown += Form2_KeyDown;
            popLoad(Form1.save);
            TurnTimer.Tick += new EventHandler(TurnTimer_Tick);
            PlayTime.Tick += new EventHandler(PlayTime_Tick);
            lblCountDownTimer.Text = ":" + (countDownTime/2).ToString();

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        /// <summary>
        /// Controls keyboard shortcuts for the menu options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.Q)
            {
                if (SaveGame())
                    Application.Exit();
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveGame();
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                LoadGame();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                Form1 newGame = new Form1();
                newGame.Show();
            }
        }

        /// <summary>
        /// Populates the GUI with the gameboard and buttons
        /// </summary>
        /// <param name="save">Saved Game</param>
        private void popLoad(SaveGame save)
        {
            gameManager = new GameManager(numRows, numCols);
            // If a saved game was loaded, populate the GUI with that information
            if (save != null)
            {
                // If there are already buttons populated, delete them to be replaced
                // Should only occur when loading from an already opened board
                if (buttons != null)
                {
                    foreach (Button b in buttons)
                    {
                        b.Click -= new EventHandler(this.OnButtonClick);
                        b.Dispose();
                    }
                    buttons.Clear();
                }
                // Set the active player to reflect the saved game
                playerOne = save.playerOne;
                LinkedListNode<Token[]> row = gameManager.rowlist.First;
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        row.Value[j].SetColor(save.gameBoard[i, j]);
                        if (row.Value[j].GetColor() > 0)
                        {
                            row.Value[j].SetPos(row, j);
                        }
                    }
                    row = row.Next;
                }
                this.Refresh();
            }
            // Generate the appropriate number of buttons for the columns, and place them along the bottom
            buttons = new List<Button>();
            Button newButton;
            for (int i = 0; i < numCols; i++)
            {
                newButton = AddButton(i);
                buttons.Add(newButton);
                this.Controls.Add(newButton);
                newButton.Click += new EventHandler(this.OnButtonClick);
            }
            switchColor();
        }

        /// <summary>
        /// Generates a new button to be added to the GUI
        /// </summary>
        /// <param name="inp">Column number represented by the button</param>
        /// <returns>Newly generated button</returns>
        private Button AddButton(int inp)
        {
            int i = inp + 1;
            Button b = new Button();
            b.Name = "Button" + i;
            b.Text = i.ToString();
            b.Width = panel1.Width / numCols - 10;
            b.Height = b.Width / 2;
            b.Left = panel1.Left + b.Width * (i-1) + 5;
            b.Top = panel1.Bottom + 10;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.BringToFront();
            return b;
        }

        /// <summary>
        /// Handles button clicking, as well as displaying the winning player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClick(object sender, EventArgs e)
        {
            // When a button is clicked, the column number and active player are passed to the GameManager via the IOManager
            Button active = (Button)sender;
            playerOne = !playerOne;
            switchColor();
            int i = Int32.Parse(active.Text);
            int outcome = IOManager.NewMove(i, gameManager, playerOne);
            this.Refresh();
            // Depending on the outcome passed back, display that the column is full or that player 1 or 2 won
            TurnTimer.Stop();
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
            TurnTimer.Start();
            countDownTime = turnTime;
            lblCountDownTimer.Text = ":" + (countDownTime / 2).ToString();
            this.Refresh();
        }

        /// <summary>
        /// Set the background colors of the buttons to correspond to the active player
        /// </summary>
        public void switchColor()
        {

            for(int i = 0; i < numCols; i++)
            {
                if (!playerOne)
                {
                    buttons[i].BackColor = Color.Red;
                    buttons[i].ForeColor = Color.Black;
                    lblCountDownTitle.ForeColor = Color.Red;
                } else
                {
                    buttons[i].BackColor = Color.Black;
                    buttons[i].ForeColor = Color.White;
                    lblCountDownTitle.ForeColor = Color.Black;

                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Draw the game board and any placed tokens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Draw The Board
            int colWidth = (int)(panel1.Width / numCols);
            int colHeight = (int)(panel1.Height / numRows);

            int[,] gameState = gameManager.ToDraw();

            Graphics g = panel1.CreateGraphics();
            for (int x = 1; x <= numCols; x++)
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        /// <summary>
        /// When the "Quit" menu option is picked, exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// When the "Save & Quit" menu option is picked, open the save prompt, then quit the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveGame())
            Application.Exit();
        }

        /// <summary>
        /// When the "New Game" menu option is picked, open the new game window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuNewGame_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            newGame.Show();
        }

        /// <summary>
        /// When the "Save Game" menu option is picked, open the save prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSaveGame_Click(object sender, EventArgs e)
        {
            SaveGame();
        }

        /// <summary>
        /// Open the save dialog, and serialize and save the game in the location and file specified
        /// </summary>
        /// <returns>Whether the game was successfully saved or not (could be failed or manually canceled)</returns>
        private bool SaveGame()
        {
            if (saveGame.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveGame.OpenFile()) != null)
                {
                    SoapFormatter serializer = new SoapFormatter();
                    SaveGame save = new SaveGame
                    {
                        playerOne = playerOne,
                        gameBoard = gameManager.ToDraw(),
                        numRows = numRows,
                        numCols = numCols
                    };
                    serializer.Serialize(stream, save);
                    stream.Close();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Load the game from a file, and pass its contents to be populated
        /// </summary>
        private void LoadGame()
        {
            SaveGame save;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog1.OpenFile()) != null)
                {
                    SoapFormatter deserializer = new SoapFormatter();
                    save = (SaveGame)deserializer.Deserialize(stream);
                    numCols = save.numCols;
                    numRows = save.numRows;
                    stream.Close();
                    popLoad(save);
                    this.Refresh();
                }
            }
        }

        /// <summary>
        /// Handles properly closing the game when closed through windows features (ie the close button, alt+F4, and shutdown)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When the "Load Game" menu option is picked, open the load game dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGame();
        }


        /// <summary>
        /// Every tick of TurnTimer (set to 1000 ms), check if the timer has expired, and if so, switch turns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnTimer_Tick(object sender, EventArgs e)
        {
            TurnTimer.Stop();
            if (countDownTime<=0)
            {
                playerOne = !playerOne;
                countDownTime = turnTime;
                switchColor();
            }
            else
            {
                countDownTime--;
            }
            // For reasons that we could not discern, countDownTime decreases by 2 every tick, so we set the max to double the intended time and half the value when displaying it
            lblCountDownTimer.Text = ":"+(countDownTime/2).ToString();
            TurnTimer.Start();
        }

        private void lblTotalTime_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays the number of seconds elapsed during the current play session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayTime_Tick(object sender, EventArgs e)
        {
            totalGameTime++;
            // For the same reason as the turn timer, the value must be halved before displaying to give an accurate number
            TotalTimeDisplay.Text = (totalGameTime/2).ToString() + " Seconds";
        }
    }
}
