using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoepractice
{
    public class CheckGame
    {
        int playerWinCount = 0;
        int  cpuWinCount = 0;
        private Label PlayerWinScore;
        private Label CPUWinScore;
        

        public CheckGame(Label PlayerWinScore, Label CPUWinScore)
        {
            this.PlayerWinScore = PlayerWinScore;
            this.CPUWinScore = CPUWinScore;
        }

        public void GameCheck(List<Button> buttons)
        {



            if ((buttons[0].Text == "X" && buttons[1].Text == "X" && buttons[2].Text == "X"
                      || buttons[3].Text == "X" && buttons[4].Text == "X" && buttons[5].Text == "X"
                      || buttons[6].Text == "X" && buttons[7].Text == "X" && buttons[8].Text == "X"
                      || buttons[0].Text == "X" && buttons[3].Text == "X" && buttons[6].Text == "X"
                      || buttons[1].Text == "X" && buttons[4].Text == "X" && buttons[7].Text == "X"
                      || buttons[2].Text == "X" && buttons[5].Text == "X" && buttons[8].Text == "X"
                      || buttons[0].Text == "X" && buttons[4].Text == "X" && buttons[8].Text == "X"
                      || buttons[2].Text == "X" && buttons[4].Text == "X" && buttons[6].Text == "X"
                     ))
            {
                // CPUTimer.Stop();
                MessageBox.Show("Player Wins! Good Job!");
                playerWinCount++;
                PlayerWinScore.Text = "Player Wins: " + playerWinCount;
                // RestartGame();

            }
            else if (buttons[0].Text == "O" && buttons[1].Text == "O" && buttons[2].Text == "O"
              || buttons[3].Text == "O" && buttons[4].Text == "O" && buttons[5].Text == "O"
              || buttons[6].Text == "O" && buttons[7].Text == "O" && buttons[8].Text == "O"
              || buttons[0].Text == "O" && buttons[3].Text == "O" && buttons[6].Text == "O"
              || buttons[1].Text == "O" && buttons[4].Text == "O" && buttons[7].Text == "O"
              || buttons[2].Text == "O" && buttons[5].Text == "O" && buttons[8].Text == "O"
              || buttons[0].Text == "O" && buttons[4].Text == "O" && buttons[8].Text == "O"
              || buttons[2].Text == "O" && buttons[4].Text == "O" && buttons[6].Text == "O")
            {

                // CPUTimer.Stop();
                MessageBox.Show("CPU Wins! Better luck next time!");
                cpuWinCount++;
                CPUWinScore.Text = "CPU Wins: " + cpuWinCount;
                // RestartGame();
            }


        }


}


}

