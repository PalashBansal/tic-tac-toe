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
            const int buttonsize = 80;
            public new const int Width = buttonsize;
            public new const int Height = buttonsize;

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

        const int MAXGRIDSIZE = 9;
        int GRIDSIZE = 3;
        //const int GRIDSIZE2D = GRIDSIZE * GRIDSIZE;
        CustomButton[,] gridButton = new CustomButton[MAXGRIDSIZE, MAXGRIDSIZE];
        int[,] gridnum = new int[MAXGRIDSIZE, MAXGRIDSIZE]; // 'X' is 1 and 'O' is 2
        enum turns { X, O };
        const turns gameStartsWith = turns.O;// opposite of game starting actually with
        turns lastTurn = gameStartsWith;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "First turn is always" + (lastTurn.Equals(turns.O) ? "'X'" : "'O'");
            System.Windows.Forms.ToolTip buttonAImovetip = new System.Windows.Forms.ToolTip();
            buttonAImovetip.SetToolTip(button2_AImove, "Make AI play first");
            makeButtonGrid();
            showGrid();
        }

        private void makeButtonGrid()
        {
            for (int x = 0; x< MAXGRIDSIZE; ++x)
                for (int y = 0; y< MAXGRIDSIZE; ++y)
                {
                    gridnum[x, y] = 0;
                    gridButton[x, y] = new CustomButton()
                    {
                        Name = String.Format("customButton{0}{1}", x, y),
                        TabIndex = 100 + MAXGRIDSIZE * x + y
                    };
                    gridButton[x, y].Click  += new EventHandler(gridButton_Click);
                    gridButton[x, y].Hide();
                    Controls.Add(gridButton[x, y]);
                }
        }

        private void showGrid()
        {
            // initial location
            int buttonBasePosH = CustomButton.Height / 2;
            int buttonBasePosW = (int)(CustomButton.Width * 2.5);
            // location based on grid size
            buttonBasePosH += (9-GRIDSIZE)* CustomButton.Height/2;
            showBoundaryIndexes();
            for (int x = 0; x < MAXGRIDSIZE; ++x)
                for (int y = 0; y < MAXGRIDSIZE; ++y)
                {
                    gridButton[x, y].Hide();
                }
            for (int x = 0; x < GRIDSIZE; ++x)
                for (int y = 0; y < GRIDSIZE; ++y)
                {
                    gridButton[x, y].Show();
                    gridButton[x, y].Location = new Point(buttonBasePosW + CustomButton.Width * x,
                                                 buttonBasePosH + CustomButton.Height * y);
                }
        }

        private void showBoundaryIndexes() //to be implemented
        {
            ///also show A-I and 1-9 on grid boundary rows and columns
        }

        private void button_newgame(object sender, EventArgs e)
        {
            newgame();
        }

        private void newgame()
        {
            for (int x = 0; x < GRIDSIZE; ++x)
                for (int y = 0; y < GRIDSIZE; ++y)
                {
                    gridButton[x, y].ResetText();
                    gridnum[x, y] = 0;
                }
            button2_AImove.Enabled = true;
            lastTurn = gameStartsWith;
            alertUser(GameStatus.GameNotStarted);
        }

        private void gridButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int gridX = button.Name[12]-48;
            int gridY = button.Name[13]-48;
            if (gridnum[gridX, gridY] == 0)
            {
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
        }

        enum GameStatus { User, AI, Draw, NoOne, GameNotStarted};

        private void checkWhoWon() //to be implemented
        {
            GameStatus whoWon = GameStatus.GameNotStarted;
            ///who won check here
            /// all has value and sum=3 means X win; sum=6 means O win, otherwise no win. All occupied but no sum=3/6 means draw
            /// user should get 'game draw' message asap, if no possible next moves can give any one win scenario. for eg-
            /*
                gridnum indexes->
                00 10 20
                01 11 21
                02 12 22
                
                O.x
                xoo
                O.x
                none of x or o can win. as 'o' can't put 'o' in both the empty places left too. so immediately put status as 'game draw'
                and make grid disable for user input, until user presses new game button.
            */
            int x = 0, y = 0;
            for(x = 0; x < GRIDSIZE; ++x)
            {
                for (y = 1; y < GRIDSIZE; ++y)
                {
                    if (gridnum[x, 0]==0 || gridnum[x, 0] != gridnum[x, y])
                        break;
                }
                if (y == GRIDSIZE)
                {
                    //whoWon = gridnum[x, 0]==1?gameStatus.;
                    break;
                }
            }
            ///
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

        private void AImove() //to be implemented
        {
            ///move by AI code here
            ///refer https://puzzling.stackexchange.com/questions/30/what-is-the-optimal-first-move-in-tic-tac-toe
            ///if first move- go in corner
            ///if 2nd move, then if first move is corner, go for centre, otherwise...
        }
        

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GRIDSIZE = (int)numericUpDown1.Value;
            showGrid();
            newgame();
        }
    }
}
