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


       public RestartGame(List<Button> buttons
           , CheckGame checkGame)
        {
            this.buttons = buttons;
            this.checkGame = checkGame;
          
           
        }

        public void ClearGame()
        {


            if (checkGame.GameOver == true)
            {
                checkGame.GameOver = false;
            }

            foreach (var button in buttons)
            { 
                button.Text = string.Empty;
                button.Enabled = true;
                button.BackColor = Color.Black;
              

               
            }
           



        }

    }
}
