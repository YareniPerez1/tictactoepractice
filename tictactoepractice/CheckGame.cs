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
        
        private GameCount winCount;
        private RestartGame restartGame;
        private Timer CPUTimer;
       
        public bool GameOver { get; set; } = false;


        public CheckGame(GameCount winCount, RestartGame restartGame, Timer CPUTimer)
        {

            this.winCount = winCount;
            this.restartGame = restartGame;
            this.CPUTimer = CPUTimer;
       
        }

        public void SetRestartGame(RestartGame restartGame)
        {
            this.restartGame = restartGame;
        }

        public void CheckXWin(List<Button> buttons)
        {
            var winningCombinations = new List<(int, int, int)>
    {
        (0, 1, 2), // First row
        (3, 4, 5), // Second row
        (6, 7, 8), // Third row
        (0, 3, 6), // First column
        (1, 4, 7), // Second column
        (2, 5, 8), // Third column
        (0, 4, 8), // Diagonal from top-left to bottom-right
        (2, 4, 6)  // Diagonal from top-right to bottom-left
    };

            if (HasWinningCombination(buttons, winningCombinations, "X"))
            {
                HandlePlayerWin();
            }

             if (IsDraw(buttons))
            {
                

                HandleDraw();
            }



        
        }

        private bool HasWinningCombination(List<Button> buttons, List<(int, int, int)> combinations, string playerSymbol)
        {
            foreach (var (a, b, c) in combinations)
            {
                if (buttons[a].Text == playerSymbol && buttons[b].Text == playerSymbol && buttons[c].Text == playerSymbol)
                {
                    return true;
                }
            }
            return false;
        }
        public void CheckOWin(List<Button> buttons)
        {
            var winningCombinations = new List<(int, int, int)>
    {
        (0, 1, 2), // First row
        (3, 4, 5), // Second row
        (6, 7, 8), // Third row
        (0, 3, 6), // First column
        (1, 4, 7), // Second column
        (2, 5, 8), // Third column
        (0, 4, 8), // Diagonal from top-left to bottom-right
        (2, 4, 6)  // Diagonal from top-right to bottom-left
    };

            if (HasWinningCombination(buttons, winningCombinations, "O"))
            {
                HandleCPUWin();
            }

            if (IsDraw(buttons))
            {
              
                HandleDraw();
            }


        }
          

           
        

        

        private bool IsDraw(List<Button> buttons)
        {
            return buttons.All(b => !b.Enabled);
        }




        private void HandlePlayerWin()
        {
            CPUTimer.Stop();
            GameOver = true;
            winCount.CountPlayerWin();
            winCount.UpdatePlayerWin();
            MessageBox.Show("Player Wins! Good Job!");
            restartGame.ClearGame();
        }

        private void HandleCPUWin()
        {
            CPUTimer.Stop();
            GameOver = true;
            winCount.CountCPUWin();
            winCount.UpdateCPUWin();
            MessageBox.Show("CPU Wins! Better luck next time!");
            restartGame.ClearGame();
        }

        private void HandleDraw()
        {
            CPUTimer.Stop();
            GameOver = true;
           // winCount.CountPlayerWin();
           // winCount.UpdatePlayerWin();
            MessageBox.Show("It's a draw");
            restartGame.ClearGame();
        }

        public void ResetGameOver()
        {
            GameOver = false;
        }



    }


    }



//if ((buttons[0].Text == "X" && buttons[1].Text == "X" && buttons[2].Text == "X"
//          || buttons[3].Text == "X" && buttons[4].Text == "X" && buttons[5].Text == "X"
//          || buttons[6].Text == "X" && buttons[7].Text == "X" && buttons[8].Text == "X"
//          || buttons[0].Text == "X" && buttons[3].Text == "X" && buttons[6].Text == "X"
//          || buttons[1].Text == "X" && buttons[4].Text == "X" && buttons[7].Text == "X"
//          || buttons[2].Text == "X" && buttons[5].Text == "X" && buttons[8].Text == "X"
//          || buttons[0].Text == "X" && buttons[4].Text == "X" && buttons[8].Text == "X"
//          || buttons[2].Text == "X" && buttons[4].Text == "X" && buttons[6].Text == "X"
//         ))



//{
//    CPUTimer.Stop();
//   GameOver = true;
//    //DisableAllButtons(buttons);
//    winCount.CountPlayerWin();
//    winCount.UpdatePlayerWin();


//    MessageBox.Show("Player Wins! Good Job!");

//   restartGame.ClearGame();


//}
//  if (buttons[0].Text == "O" && buttons[1].Text == "O" && buttons[2].Text == "O"
//   || buttons[3].Text == "O" && buttons[4].Text == "O" && buttons[5].Text == "O"
//   || buttons[6].Text == "O" && buttons[7].Text == "O" && buttons[8].Text == "O"
//   || buttons[0].Text == "O" && buttons[3].Text == "O" && buttons[6].Text == "O"
//   || buttons[1].Text == "O" && buttons[4].Text == "O" && buttons[7].Text == "O"
//   || buttons[2].Text == "O" && buttons[5].Text == "O" && buttons[8].Text == "O"
//   || buttons[0].Text == "O" && buttons[4].Text == "O" && buttons[8].Text == "O"
//   || buttons[2].Text == "O" && buttons[4].Text == "O" && buttons[6].Text == "O")
// {

// CPUTimer.Stop();
// GameOver = true;
//// DisableAllButtons(buttons);
// winCount.CountCPUWin();
// winCount.UpdateCPUWin();

// MessageBox.Show("CPU Wins! Better luck next time!");
// restartGame.ClearGame();
// CPUTimer.Stop();