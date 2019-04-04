namespace TetrisGUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveGame = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQuitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCountDownTitle = new System.Windows.Forms.Label();
            this.lblCountDownTimer = new System.Windows.Forms.Label();
            this.PlayTime = new System.Windows.Forms.Timer(this.components);
            this.TotalTimeDisplay = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(310, 91);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(335, 54);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Connect Tetris";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(147, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 448);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saveGame
            // 
            this.saveGame.DefaultExt = "xml";
            this.saveGame.Filter = "XML files|*.xml|All files|*.*";
            this.saveGame.RestoreDirectory = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML File |*.xml|Any File |*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1002, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewGame,
            this.MenuSaveGame,
            this.loadGameToolStripMenuItem,
            this.saveQuitToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuNewGame
            // 
            this.MenuNewGame.Name = "MenuNewGame";
            this.MenuNewGame.ShortcutKeyDisplayString = "Ctrl + N";
            this.MenuNewGame.Size = new System.Drawing.Size(322, 30);
            this.MenuNewGame.Text = "&New Game";
            this.MenuNewGame.Click += new System.EventHandler(this.MenuNewGame_Click);
            // 
            // MenuSaveGame
            // 
            this.MenuSaveGame.Name = "MenuSaveGame";
            this.MenuSaveGame.ShortcutKeyDisplayString = "Ctrl + S";
            this.MenuSaveGame.Size = new System.Drawing.Size(322, 30);
            this.MenuSaveGame.Text = "&Save Game";
            this.MenuSaveGame.Click += new System.EventHandler(this.MenuSaveGame_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.loadGameToolStripMenuItem.Text = "L&oad Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // saveQuitToolStripMenuItem
            // 
            this.saveQuitToolStripMenuItem.Name = "saveQuitToolStripMenuItem";
            this.saveQuitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + Q";
            this.saveQuitToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.saveQuitToolStripMenuItem.Text = "Sa&ve + Quit";
            this.saveQuitToolStripMenuItem.Click += new System.EventHandler(this.saveQuitToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Q";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(322, 30);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // TurnTimer
            // 
            this.TurnTimer.Enabled = true;
            this.TurnTimer.Interval = 1000;
            this.TurnTimer.Tick += new System.EventHandler(this.TurnTimer_Tick);
            // 
            // lblCountDownTitle
            // 
            this.lblCountDownTitle.AutoSize = true;
            this.lblCountDownTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDownTitle.Location = new System.Drawing.Point(676, 131);
            this.lblCountDownTitle.Name = "lblCountDownTitle";
            this.lblCountDownTitle.Size = new System.Drawing.Size(141, 29);
            this.lblCountDownTitle.TabIndex = 13;
            this.lblCountDownTitle.Text = "Turn Time:";
            // 
            // lblCountDownTimer
            // 
            this.lblCountDownTimer.AutoSize = true;
            this.lblCountDownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDownTimer.Location = new System.Drawing.Point(823, 131);
            this.lblCountDownTimer.Name = "lblCountDownTimer";
            this.lblCountDownTimer.Size = new System.Drawing.Size(48, 29);
            this.lblCountDownTimer.TabIndex = 14;
            this.lblCountDownTimer.Text = ":30";
            // 
            // PlayTime
            // 
            this.PlayTime.Enabled = true;
            this.PlayTime.Interval = 1000;
            this.PlayTime.Tick += new System.EventHandler(this.PlayTime_Tick);
            // 
            // TotalTimeDisplay
            // 
            this.TotalTimeDisplay.AutoSize = true;
            this.TotalTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTimeDisplay.Location = new System.Drawing.Point(94, 131);
            this.TotalTimeDisplay.Name = "TotalTimeDisplay";
            this.TotalTimeDisplay.Size = new System.Drawing.Size(136, 29);
            this.TotalTimeDisplay.TabIndex = 16;
            this.TotalTimeDisplay.Text = "0 Seconds";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(50, 65);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(216, 29);
            this.lblTotalTime.TabIndex = 15;
            this.lblTotalTime.Text = "Total Game Time";
            this.lblTotalTime.Click += new System.EventHandler(this.lblTotalTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "(This Session):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1002, 784);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTimeDisplay);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblCountDownTimer);
            this.Controls.Add(this.lblCountDownTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveGame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveGame;
        private System.Windows.Forms.ToolStripMenuItem saveQuitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.Timer TurnTimer;
        private System.Windows.Forms.Label lblCountDownTitle;
        private System.Windows.Forms.Label lblCountDownTimer;
        private System.Windows.Forms.Timer PlayTime;
        private System.Windows.Forms.Label TotalTimeDisplay;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label1;
    }
}