using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoepractice
{
    public partial class TicTacToeGameBoard : Form
    {

        //public enum Player
        //{ 
        //    X, O

        //}

        //public PlayerSymbol player{ get; } = PlayerSymbol.X;
        //public PlayerSymbol cpu { get; } = PlayerSymbol.O;

        //PlayerSymbol currentPlayer;
        //Random random = new Random();
        //int playerWinCount = 0;
        //int cpuWinCount = 0;


       private List<Button> buttons;
        private CheckGame checkGame;
        private ComputerPlayer cpu;
        private HumanPlayer player;
       // private Timer CPUTimer;
       // PlayerSymbol currentPlayer;


        public TicTacToeGameBoard()
        {
            InitializeComponent();
           
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            player = new HumanPlayer(PlayerSymbol.X);
            cpu = new ComputerPlayer(PlayerSymbol.O, buttons);

            checkGame = new CheckGame(PlayerWinScore, CPUWinScore);
            //CPUTimer = new Timer();
            //CPUTimer.Interval = 1000;
            //CPUTimer.Tick += new EventHandler(CPUmove);


           

            RestartGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {
            //if (buttons.Count > 0)
            //{
            //    int index = random.Next(buttons.Count);
            //    buttons[index].Enabled = false;
            //    currentPlayer = cpu;
            //    buttons[index].Text = currentPlayer.ToString();
            //    buttons[index].BackColor = Color.LavenderBlush;
            //    buttons.RemoveAt(index);
            //    CheckGame();
            //    CPUTimer.Stop();
            //}

            cpu.MakeMove();
            CPUTimer.Stop();
            CheckGame();
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            // currentPlayer = player;
            //button.Text = currentPlayer.ToString();
            button.Text = player.player.ToString();
            button.Enabled = false;
            button.BackColor = Color.DarkSeaGreen;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {


            checkGame.GameCheck(buttons);
            CPUTimer.Stop();
            RestartGame();
            //if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
            //  || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
            //  || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
            //  || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
            //  || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
            //  || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
            //  || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
            //  || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
            // )
            //{
            //    CPUTimer.Stop();
            //    MessageBox.Show("Player Wins! Good Job!");
            //    playerWinCount++;
            //    PlayerWinScore.Text = "Player Wins: " + playerWinCount;
            //    RestartGame();

            //}
            //else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            //  || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            //  || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
            //  || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            //  || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            //  || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            //  || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            //  || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            //{

            //    CPUTimer.Stop();
            //    MessageBox.Show("CPU Wins! Better luck next time!");
            //    cpuWinCount++;
            //    CPUWinScore.Text = "CPU Wins: " + cpuWinCount;
            //    RestartGame();
            //}
           
           

        }

        private void RestartGame()
        {

            //buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            //foreach(Button x in buttons)
            //{
            //    x.Enabled = true;
            //    x.Text = "";
            //    x.BackColor = Color.Black;
            //}

            foreach (var button in buttons)
            {
                button.Text = string.Empty;
                button.Enabled = true;
                button.BackColor = default(Color);
            }
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            CPUTimer.Stop();
        
          
        }

        private void TicTacToeGameBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
