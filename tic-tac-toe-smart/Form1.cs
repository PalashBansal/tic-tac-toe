using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tic_tac_toe_smart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        public class CustomButton : Button
        {
            const int buttonsize=80;
            public const int Width = buttonsize;
            public const int Height = buttonsize;

            public CustomButton()
            {
                BackColor = Color.FromArgb(200, 200, 200);
                ForeColor = Color.Black;
                Font = new Font(Font.FontFamily, 40);
                FlatStyle = FlatStyle.Flat;
                Size = new Size(Width, Height);
                UseVisualStyleBackColor = false;
            }
        }

        const int GRIDSIZE = 3;
        //const int GRIDSIZE2D = GRIDSIZE * GRIDSIZE;
        CustomButton[,] gridButton = new CustomButton[GRIDSIZE, GRIDSIZE];
        int[,] gridnum = new int[GRIDSIZE, GRIDSIZE]; // 'X' is 1 and 'O' is 2
        enum turns {X, O};
        turns lastTurn = turns.O;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "First turn is always" + (lastTurn.Equals(turns.O)? "'X'" : "'O'");
            System.Windows.Forms.ToolTip buttonAImovetip = new System.Windows.Forms.ToolTip();
            buttonAImovetip.SetToolTip(button2_AImove, "Make AI play first");
            int buttonBasePosH = this.ClientSize.Height / 2 - CustomButton.Height * 2;
            int buttonBasePosW = this.ClientSize.Width / 2 - CustomButton.Width * 2;
            for (int x = 0; x < GRIDSIZE; ++x)
                for (int y = 0; y < GRIDSIZE; ++y)
                {
                    gridnum[x, y] = 0;
                    gridButton[x, y] = new CustomButton()
                    {
                        Name = String.Format("customButton{0}{1}", x, y),
                        TabIndex = 100 + GRIDSIZE * x + y,
                        Location = new Point(buttonBasePosW + CustomButton.Width * x,
                                                 buttonBasePosH + CustomButton.Height * y)
                    };
                    gridButton[x, y].Click  += new EventHandler(gridButton_Click);
                    Controls.Add(gridButton[x, y]);
                }
                    
        }

        private void button_newgame(object sender, EventArgs e)
        {
            for (int x = 0; x < GRIDSIZE; ++x)
                for (int y = 0; y < GRIDSIZE; ++y)
                {
                    gridButton[x, y].ResetText();
                    gridnum[x, y] = 0;
                }
            button2_AImove.Enabled = true;
            alertUser(GameStatus.GameNotStarted);
        }

        private void gridButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int gridX = button.Name[12]-48;
            int gridY = button.Name[13]-48;
            if (lastTurn == turns.X)
            {
                button.Text = "O";
                lastTurn = turns.O;
                gridnum[gridX, gridY] = 2;
            }
            else
            {
                button.Text = "X";
                lastTurn = turns.X;
                gridnum[gridX, gridY] = 1;
            }
            button2_AImove.Enabled = false;
            checkWhoWon();
        }

        enum GameStatus { User, AI, Draw, NoOne, GameNotStarted};

        private void checkWhoWon()
        {
            GameStatus whoWon = GameStatus.GameNotStarted;
            ///who won check here
            /// all has value and sum=3 means X win; sum=6 means O win, otherwise no win. All occupied but no sum=3/6 means draw
            
            alertUser(whoWon);
        }
       

        private void alertUser(GameStatus whoWon)
        {
            switch(whoWon)
            {
                case GameStatus.GameNotStarted:
                    gameStatus.Text = "Status: Game Not Started!";
                    break;
                case GameStatus.NoOne:
                    gameStatus.Text = "Status: Game in Progress!";
                    break;
                case GameStatus.Draw:
                    gameStatus.Text = "Status : Match Draw!";
                    break;
                case GameStatus.User:
                    gameStatus.Text = "Status : You Won!";
                    break;
                case GameStatus.AI:
                    gameStatus.Text = "Status : AI Won!";
                    break;
            }
        }

        private void button2_AImove_Click(object sender, EventArgs e)
        {
            bool notFirstMove = false;
            button2_AImove.Enabled = false;
            for (int x = 0; x < GRIDSIZE; ++x)
            {
                for (int y = 0; y < GRIDSIZE; ++y)
                {
                    if (gridnum[x, y] != 0)
                    {
                        notFirstMove = true;
                        break;
                    }
                }
                if (notFirstMove)
                    break;
            }
            if(!notFirstMove)
            {
                AImove();
            }
            checkWhoWon();
        }

        private void AImove()
        {
            ///move by AI code here
            ///refer https://puzzling.stackexchange.com/questions/30/what-is-the-optimal-first-move-in-tic-tac-toe
            ///if first move- go in corner
            ///if 2nd move, then if first move is corner, go for centre, otherwise...
        }
    }
}
