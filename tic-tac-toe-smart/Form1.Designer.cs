namespace tic_tac_toe_smart
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
            this.button1_newgame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2_AImove = new System.Windows.Forms.Button();
            this.gameStatus = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_newgame
            // 
            this.button1_newgame.Location = new System.Drawing.Point(2, 2);
            this.button1_newgame.Margin = new System.Windows.Forms.Padding(2);
            this.button1_newgame.Name = "button1_newgame";
            this.button1_newgame.Size = new System.Drawing.Size(92, 24);
            this.button1_newgame.TabIndex = 0;
            this.button1_newgame.Text = "New game";
            this.button1_newgame.UseVisualStyleBackColor = true;
            this.button1_newgame.Click += new System.EventHandler(this.button_newgame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First turn is always \' \'";
            // 
            // button2_AImove
            // 
            this.button2_AImove.Location = new System.Drawing.Point(2, 67);
            this.button2_AImove.Margin = new System.Windows.Forms.Padding(2);
            this.button2_AImove.Name = "button2_AImove";
            this.button2_AImove.Size = new System.Drawing.Size(92, 24);
            this.button2_AImove.TabIndex = 1;
            this.button2_AImove.Text = "AI First";
            this.button2_AImove.UseVisualStyleBackColor = true;
            this.button2_AImove.Click += new System.EventHandler(this.button2_AImove_Click);
            // 
            // gameStatus
            // 
            this.gameStatus.AutoSize = true;
            this.gameStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gameStatus.Location = new System.Drawing.Point(2, 94);
            this.gameStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(131, 13);
            this.gameStatus.TabIndex = 2;
            this.gameStatus.Text = "Status: Game Not Started!";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(68, 30);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(26, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GameSize:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1_newgame);
            this.panel1.Controls.Add(this.gameStatus);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button2_AImove);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 562);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 123);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 845);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe-Smart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_newgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2_AImove;
        private System.Windows.Forms.Label gameStatus;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

