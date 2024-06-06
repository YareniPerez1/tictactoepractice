//using System.Windows.Forms;
using tictactoepractice;
using Moq;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace TicTacToeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Player_Win()
        {
            var playerWinScore = new Label();
            var cpuWinScore = new Label();
            var winCount = new GameCount(playerWinScore, cpuWinScore);
            var timer = new System.Windows.Forms.Timer();

            var buttons = new List<Button>
        {
            new Button { Text = "X" },
            new Button { Text = "X" },
            new Button { Text = "X" },
            new Button { Text = "" },
            new Button { Text = "" },
            new Button { Text = "" },
            new Button { Text = "" },
            new Button { Text = "" },
            new Button { Text = "" }
        };

            var checkGame = new CheckGame(winCount, null, timer);
            var restartGame = new RestartGame(buttons, checkGame);
            checkGame.SetRestartGame(restartGame);

            // Act
            checkGame.GameCheck(buttons);

            //Assert
            Assert.IsTrue(checkGame.GameOver);
        }
    }
}

//int playerWinCount = 0;
//int cpuWinCount = 0;
//Label PlayerWinScore;
//Label CPUWinScore;
//var winCount = new GameCount(PlayerWinScore, CPUWinScore);
//var restartGame = new RestartGame();
//var timer = new System.Windows.Forms.Timer();

//var checkGame = new CheckGame(winCount, restartGame, timer);

//List<Button> buttons = new List<Button>
//        {
//            new Button { Text = "X" },
//            new Button { Text = "X" },
//            new Button { Text = "X" },
//            new Button { Text = "" },
//            new Button { Text = "" },
//            new Button { Text = "" },
//            new Button { Text = "" },
//            new Button { Text = "" },
//            new Button { Text = "" }
//        };

//// Act
//checkGame.GameCheck(buttons);

//// Assert
//Assert.IsTrue(checkGame.GameOver);