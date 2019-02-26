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
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtQuit = new System.Windows.Forms.Button();
            this.BtSaveQuit = new System.Windows.Forms.Button();
            this.BtCol1 = new System.Windows.Forms.Button();
            this.BtCol2 = new System.Windows.Forms.Button();
            this.BtCol3 = new System.Windows.Forms.Button();
            this.BtCol4 = new System.Windows.Forms.Button();
            this.BtCol5 = new System.Windows.Forms.Button();
            this.BtCol6 = new System.Windows.Forms.Button();
            this.BtCol7 = new System.Windows.Forms.Button();
            this.saveGame = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 447);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtQuit
            // 
            this.BtQuit.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtQuit.Location = new System.Drawing.Point(147, 708);
            this.BtQuit.Name = "BtQuit";
            this.BtQuit.Size = new System.Drawing.Size(179, 64);
            this.BtQuit.TabIndex = 3;
            this.BtQuit.Text = "Quit";
            this.BtQuit.UseVisualStyleBackColor = true;
            this.BtQuit.Click += new System.EventHandler(this.BtQuit_Click);
            // 
            // BtSaveQuit
            // 
            this.BtSaveQuit.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSaveQuit.Location = new System.Drawing.Point(592, 708);
            this.BtSaveQuit.Name = "BtSaveQuit";
            this.BtSaveQuit.Size = new System.Drawing.Size(225, 64);
            this.BtSaveQuit.TabIndex = 4;
            this.BtSaveQuit.Text = "Save + Quit";
            this.BtSaveQuit.UseVisualStyleBackColor = true;
            this.BtSaveQuit.Click += new System.EventHandler(this.BtSaveQuit_Click);
            // 
            // BtCol1
            // 
            this.BtCol1.BackColor = System.Drawing.Color.Red;
            this.BtCol1.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol1.Location = new System.Drawing.Point(147, 633);
            this.BtCol1.Name = "BtCol1";
            this.BtCol1.Size = new System.Drawing.Size(62, 52);
            this.BtCol1.TabIndex = 5;
            this.BtCol1.Text = "1";
            this.BtCol1.UseVisualStyleBackColor = false;
            this.BtCol1.Click += new System.EventHandler(this.BtCol1_Click);
            // 
            // BtCol2
            // 
            this.BtCol2.BackColor = System.Drawing.Color.Red;
            this.BtCol2.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol2.Location = new System.Drawing.Point(254, 633);
            this.BtCol2.Name = "BtCol2";
            this.BtCol2.Size = new System.Drawing.Size(62, 52);
            this.BtCol2.TabIndex = 6;
            this.BtCol2.Text = "2";
            this.BtCol2.UseVisualStyleBackColor = false;
            this.BtCol2.Click += new System.EventHandler(this.BtCol2_Click);
            // 
            // BtCol3
            // 
            this.BtCol3.BackColor = System.Drawing.Color.Red;
            this.BtCol3.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol3.Location = new System.Drawing.Point(352, 633);
            this.BtCol3.Name = "BtCol3";
            this.BtCol3.Size = new System.Drawing.Size(62, 52);
            this.BtCol3.TabIndex = 7;
            this.BtCol3.Text = "3";
            this.BtCol3.UseVisualStyleBackColor = false;
            this.BtCol3.Click += new System.EventHandler(this.BtCol3_Click);
            // 
            // BtCol4
            // 
            this.BtCol4.BackColor = System.Drawing.Color.Red;
            this.BtCol4.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol4.Location = new System.Drawing.Point(453, 633);
            this.BtCol4.Name = "BtCol4";
            this.BtCol4.Size = new System.Drawing.Size(62, 52);
            this.BtCol4.TabIndex = 8;
            this.BtCol4.Text = "4";
            this.BtCol4.UseVisualStyleBackColor = false;
            this.BtCol4.Click += new System.EventHandler(this.BtCol4_Click);
            // 
            // BtCol5
            // 
            this.BtCol5.BackColor = System.Drawing.Color.Red;
            this.BtCol5.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol5.Location = new System.Drawing.Point(552, 633);
            this.BtCol5.Name = "BtCol5";
            this.BtCol5.Size = new System.Drawing.Size(62, 52);
            this.BtCol5.TabIndex = 9;
            this.BtCol5.Text = "5";
            this.BtCol5.UseVisualStyleBackColor = false;
            this.BtCol5.Click += new System.EventHandler(this.BtCol5_Click);
            // 
            // BtCol6
            // 
            this.BtCol6.BackColor = System.Drawing.Color.Red;
            this.BtCol6.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol6.Location = new System.Drawing.Point(650, 633);
            this.BtCol6.Name = "BtCol6";
            this.BtCol6.Size = new System.Drawing.Size(62, 52);
            this.BtCol6.TabIndex = 10;
            this.BtCol6.Text = "6";
            this.BtCol6.UseVisualStyleBackColor = false;
            this.BtCol6.Click += new System.EventHandler(this.BtCol6_Click);
            // 
            // BtCol7
            // 
            this.BtCol7.BackColor = System.Drawing.Color.Red;
            this.BtCol7.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCol7.Location = new System.Drawing.Point(755, 633);
            this.BtCol7.Name = "BtCol7";
            this.BtCol7.Size = new System.Drawing.Size(62, 52);
            this.BtCol7.TabIndex = 11;
            this.BtCol7.Text = "7";
            this.BtCol7.UseVisualStyleBackColor = false;
            this.BtCol7.Click += new System.EventHandler(this.BtCol7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1002, 784);
            this.Controls.Add(this.BtCol7);
            this.Controls.Add(this.BtCol6);
            this.Controls.Add(this.BtCol5);
            this.Controls.Add(this.BtCol4);
            this.Controls.Add(this.BtCol3);
            this.Controls.Add(this.BtCol2);
            this.Controls.Add(this.BtCol1);
            this.Controls.Add(this.BtSaveQuit);
            this.Controls.Add(this.BtQuit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtQuit;
        private System.Windows.Forms.Button BtSaveQuit;
        private System.Windows.Forms.Button BtCol1;
        private System.Windows.Forms.Button BtCol2;
        private System.Windows.Forms.Button BtCol3;
        private System.Windows.Forms.Button BtCol4;
        private System.Windows.Forms.Button BtCol5;
        private System.Windows.Forms.Button BtCol6;
        private System.Windows.Forms.Button BtCol7;
        private System.Windows.Forms.SaveFileDialog saveGame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}