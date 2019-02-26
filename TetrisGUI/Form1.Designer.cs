namespace TetrisGUI
{
    partial class Form1
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
            this.BtStart = new System.Windows.Forms.Button();
            this.BtLoad = new System.Windows.Forms.Button();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TxtRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(141, 58);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(500, 82);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Connect Tetris";
            // 
            // BtStart
            // 
            this.BtStart.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStart.Location = new System.Drawing.Point(155, 281);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(179, 107);
            this.BtStart.TabIndex = 1;
            this.BtStart.Text = "New Game";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // BtLoad
            // 
            this.BtLoad.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLoad.Location = new System.Drawing.Point(462, 281);
            this.BtLoad.Name = "BtLoad";
            this.BtLoad.Size = new System.Drawing.Size(179, 107);
            this.BtLoad.TabIndex = 2;
            this.BtLoad.Text = "Load Game";
            this.BtLoad.UseVisualStyleBackColor = true;
            this.BtLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(155, 228);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(54, 26);
            this.txtCols.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // TxtRows
            // 
            this.TxtRows.Location = new System.Drawing.Point(280, 228);
            this.TxtRows.Name = "TxtRows";
            this.TxtRows.Size = new System.Drawing.Size(54, 26);
            this.TxtRows.TabIndex = 4;
            this.TxtRows.TextChanged += new System.EventHandler(this.TxtRows_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rows:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRows);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.BtLoad);
            this.Controls.Add(this.BtStart);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtLoad;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TxtRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

