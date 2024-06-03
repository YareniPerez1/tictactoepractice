using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoepractice
{
    public class RestartGame
    {
        List<Button> buttons;
        private CheckGame checkGame;


       public RestartGame(List<Button> buttons)
        {
            this.buttons = buttons;
          
           
        }

        public void ClearGame()
        {
            
               //checkGame.ResetGameOver();
            


            foreach (var button in buttons)
            {
                button.Text = string.Empty;
                button.Enabled = true;
                button.BackColor = default(Color);

                //checkGame.GameOver = false;
            }
            //checkGame.ResetGameOver();

            //if (checkGame != null)
            //{
            //    checkGame.ResetGameOver();
            //}



        }

    }
}
