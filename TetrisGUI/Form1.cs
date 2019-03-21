/// <summary>
/// Project Name: TetrisGUI
/// File Name: Form1.cs
/// Written by: Charley Bein and Ben Tipton
/// Date: 2019-03-19
/// Description: Holds logic for the new game/load game dialog
/// </summary>

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace TetrisGUI
{

    public partial class Form1 : Form
    {
        public static int numCols = 7;
        public static int numRows = 6;
        public static SaveGame save = null;

        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// If the user selects new game, open a new game window using either the provided width and height, or the defaults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStart_Click(object sender, EventArgs e)
        {
            if (txtCols.Text != "")
            {
                numCols = Int32.Parse(txtCols.Text);
            }
            if (TxtRows.Text != "")
            {
                numRows = Int32.Parse(TxtRows.Text);
            }
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

        /// <summary>
        /// If the user chooses to load a file, prompt them to select the file, then open a new game board with that save state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtLoad_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                if((stream = openFileDialog1.OpenFile()) != null){
                    SoapFormatter deserializer = new SoapFormatter();
                    save = (SaveGame)deserializer.Deserialize(stream);
                    numCols = save.numCols;
                    numRows = save.numRows;
                    stream.Close();
                    Form2 game = new Form2();
                    game.Show();
                    this.Hide();
                }
            }
        }
    }
}
