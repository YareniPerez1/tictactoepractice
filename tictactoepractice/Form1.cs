using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoepractice
{
    public partial class TicTacToeGameBoard : Form
    {

       


       private List<Button> buttons;
        private CheckGame checkGame;
        private ComputerPlayer cpu;
        private HumanPlayer player;
        private GameCount winCount;
        private RestartGame restartGame;
     
      


        public TicTacToeGameBoard()
        {
            InitializeComponent();
           
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            player = new HumanPlayer(PlayerSymbol.X);
            cpu = new ComputerPlayer(PlayerSymbol.O, buttons);
            winCount = new GameCount(PlayerWinScore, CPUWinScore);
             restartGame = new RestartGame(buttons);
            checkGame = new CheckGame(winCount, restartGame, CPUTimer);
            //restartGame = new RestartGame(buttons);
            //checkGame.SetRestartGame(restartGame);
            //checkGame.SetRestartGame(restartGame);
            // winCount = new GameCount(PlayerWinScore, CPUWinScore);




            //  checkGame = new CheckGame(winCount, restartGame, CPUTimer);

            //  CPUTimer.Interval = 1000; // CPU move interval in milliseconds
            // CPUTimer.Tick += CPUmove;


            foreach (var button in buttons)
            {
                button.Click += PlayerClickButton;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {

           // CPUTimer.Stop();
            cpu.MakeMove();
            CPUTimer.Stop();

            Console.WriteLine("CPU move made");
            Console.WriteLine("Button states after CPU move:");
            foreach (var btn in buttons)
            {
                Console.WriteLine($"{btn.Name}: {btn.Text}, Enabled: {btn.Enabled}");
            }
          //  CheckGame();
            checkGame.GameCheck(buttons);
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            if (checkGame.GameOver) return;
            var button = (Button)sender;
            if (!button.Enabled) return;
            // List<Button> availableButtons = buttons.Where(b => b.Enabled).ToList();

            button.Text = player.player.ToString();
            button.Enabled = false;
            button.BackColor = Color.DarkSeaGreen;


            Console.WriteLine("Player clicked: " + button.Name);
            Console.WriteLine("Button states after player click:");
            Console.WriteLine("Button color after player click: " + button.BackColor);
            foreach (var btn in buttons)
            {
                Console.WriteLine($"{btn.Name}: {btn.Text}, Enabled: {btn.Enabled}");
            }

            CheckGame();
            //List<Button> availableButtons = buttons.Where(b => b.Enabled).ToList();
            //cpu.UpdateButtons(availableButtons);
           


                List<Button> availableButtons = buttons.Where(b => b.Enabled).ToList();
                cpu.UpdateButtons(availableButtons);
                CPUTimer.Start();
            
            
        }

        private void RestartGame(object sender, EventArgs e)
        {
            Console.WriteLine("Restarting game...");
            checkGame.GameOver = false;
            restartGame.ClearGame();
          
        }

        private void CheckGame()
        {
            Console.WriteLine("Checking game...");

            checkGame.GameCheck(buttons);
           // CPUTimer.Stop();
           // RestartGame();

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

    

        private void TicTacToeGameBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
