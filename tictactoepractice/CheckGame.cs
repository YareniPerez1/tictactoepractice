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

        //public void SetRestartGame(RestartGame restartGame)
        //{
        //    this.restartGame = restartGame;
        //}

        public void GameCheck(List<Button> buttons)
        {
          //  if (GameOver) return;


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
                CPUTimer.Stop();
                GameOver = true;
                //DisableAllButtons(buttons);
                winCount.CountPlayerWin();
                winCount.UpdatePlayerWin();
               
             
                MessageBox.Show("Player Wins! Good Job!");
              // CPUTimer.Stop();
                restartGame.ClearGame();
                CPUTimer.Start();
               
               // CPUTimer.Start();
             

               

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

                CPUTimer.Stop();
                GameOver = true;
               // DisableAllButtons(buttons);
                winCount.CountCPUWin();
                winCount.UpdateCPUWin();
              
                MessageBox.Show("CPU Wins! Better luck next time!");
                restartGame.ClearGame();
                CPUTimer.Stop();
              
            }
            else if (IsDraw(buttons))
            {
                CPUTimer.Stop();
                GameOver = true;
                MessageBox.Show("It's a draw!");
                restartGame.ClearGame();
            }


            //if (GameOver)
            //{
            //    restartGame.ClearGame();
            //    GameOver = false; // Reset game over state
            //}
        }


        private bool IsDraw(List<Button> buttons)
        {
            return buttons.All(b => !b.Enabled);
        }


        //private void DisableAllButtons(List<Button> buttons)
        //{
        //    foreach (var button in buttons)
        //    {
        //        button.Enabled = false;
        //    }
        //}

        //public void ResetGameOver()
        //{
        //    GameOver = false;
        //}

        

    }


    }


