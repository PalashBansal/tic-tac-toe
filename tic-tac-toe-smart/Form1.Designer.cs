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
            this.SuspendLayout();
            // 
            // button1_newgame
            // 
            this.button1_newgame.Location = new System.Drawing.Point(268, 99);
            this.button1_newgame.Name = "button1_newgame";
            this.button1_newgame.Size = new System.Drawing.Size(122, 56);
            this.button1_newgame.TabIndex = 0;
            this.button1_newgame.Text = "New game";
            this.button1_newgame.UseVisualStyleBackColor = true;
            this.button1_newgame.Click += new System.EventHandler(this.button_newgame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First turn is always \' \'";
            // 
            // button2_AImove
            // 
            this.button2_AImove.Location = new System.Drawing.Point(31, 633);
            this.button2_AImove.Name = "button2_AImove";
            this.button2_AImove.Size = new System.Drawing.Size(107, 29);
            this.button2_AImove.TabIndex = 1;
            this.button2_AImove.Text = "AI First";
            this.button2_AImove.UseVisualStyleBackColor = true;
            this.button2_AImove.Click += new System.EventHandler(this.button2_AImove_Click);
            // 
            // gameStatus
            // 
            this.gameStatus.AutoSize = true;
            this.gameStatus.Location = new System.Drawing.Point(217, 724);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(173, 17);
            this.gameStatus.TabIndex = 2;
            this.gameStatus.Text = "Status: Game Not Started!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.button2_AImove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_newgame);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe-Smart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_newgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2_AImove;
        private System.Windows.Forms.Label gameStatus;
    }
}

