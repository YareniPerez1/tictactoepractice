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
            checkGame = new CheckGame(winCount, restartGame, CPUTimer);
            restartGame = new RestartGame(buttons, checkGame);
            checkGame.SetRestartGame(restartGame);
            


            //foreach (var button in buttons)
            //{
            //    button.Click += PlayerClickButton;
            //}




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {

          
            cpu.MakeMove();
            CPUTimer.Stop();

         
            checkGame.CheckOWin(buttons);
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            if (checkGame.GameOver) return;
            var button = (Button)sender;
            if (!button.Enabled) return;
           
            button.Text = player.player.ToString();
            
            button.Enabled = false;
            button.BackColor = Color.LightGray;
        
            List<Button> availableButtons = buttons.Where(b => b.Enabled).ToList();
            cpu.UpdateButtons(availableButtons);
            CPUTimer.Start();
            CheckGame();

        }

        private void RestartGame(object sender, EventArgs e)
        {
           
            checkGame.GameOver = false;
            restartGame.ClearGame();
          
        }

        private void CheckGame()
        {
            // Console.WriteLine("Checking game...");

            // checkGame.GameCheck(buttons);
            checkGame.CheckXWin(buttons);
           

        }

    

        private void TicTacToeGameBoard_Load(object sender, EventArgs e)
        {

        }

        private void CPUWinScore_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }
    }
}
