using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoepractice
{
    public class GameCount
    {

        private int playerWinCount = 0;
        private int cpuWinCount = 0;
        private Label PlayerWinScore;
        private Label CPUWinScore;
        


        public GameCount(Label PlayerWinScore, Label CPUWinScore)
        {
            this.PlayerWinScore = PlayerWinScore;
            this.CPUWinScore = CPUWinScore;
        }

        public void CountPlayerWin()
        {
            playerWinCount++;
            Console.WriteLine($"Player wins incremented to {playerWinCount}");

            UpdatePlayerWin();

        }

        public void UpdatePlayerWin()
        {
            PlayerWinScore.Text = "Player Wins: " + playerWinCount;
            Console.WriteLine($"Player label updated to: {PlayerWinScore.Text}");
        }


        public void CountCPUWin()
        {
            cpuWinCount++;
            Console.WriteLine($"CPU wins incremented to {cpuWinCount}");

            UpdateCPUWin();

        }

        public void UpdateCPUWin()
        {
            CPUWinScore.Text = "CPU Wins: " + cpuWinCount;
            Console.WriteLine($"CPU label updated to: {CPUWinScore.Text}");
        }
    }
}
