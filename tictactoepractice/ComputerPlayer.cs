using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoepractice
{
    public class ComputerPlayer: IPlayer
    {
        //public Timer timer;
        //public event EventHandler CPUTimer;
        private List<Button> buttons;
       private  Random random = new Random();
       private PlayerSymbol currentPlayer;
      //  private System.Windows.Forms.Timer CPUTimer;



        public PlayerSymbol player { get; } = PlayerSymbol.O;

        public ComputerPlayer(PlayerSymbol symbol, List<Button> buttons)
        {
            this.currentPlayer = symbol;
            this.buttons = buttons ;
           // this.CPUTimer = CPUTimer;
            //?? throw new Exception 
            // ArgumentNullException(nameof(buttons), "Buttons list cannot be null");
        }
        public void UpdateButtons(List<Button> availableButtons)
        {
            this.buttons = availableButtons;
        }

        public void MakeMove()
        {
            //List<Button> availableButtons = buttons.Where(b => b.Enabled).ToList();

            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                //int index = random.Next(availableButtons.Count);
                //Button selectedButton = availableButtons[index];
                //selectedButton.Enabled = false;
                //selectedButton.Text = player.ToString();
                //selectedButton.BackColor = Color.LavenderBlush;

                // Remove the selected button from the computer player's buttons list
                // buttons.Remove(selectedButton);

               // checkGame.GameCheck(buttons);
                buttons[index].Enabled = false;
                currentPlayer = player;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.LavenderBlush;
                buttons.RemoveAt(index);
                
               

                // CPUTimer.Stop();
            }
        }
    }
}
