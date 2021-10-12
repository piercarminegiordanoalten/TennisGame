using System;
using System.Collections.Generic;
using System.Text;
using TennisGame.Services.Interfaces;
using static TennisGame.Configuration.Enumerator;

namespace TennisGame.Services
{
    class Tennis : IGame
    {
        private int HomeScore { get; set; }

        private int AwayScore { get; set; }


        public void GameInfo()
        {
            Console.WriteLine("Tennis Game!\n");
            Console.WriteLine("Game Rules");
            Console.WriteLine("- A game is won by the first player to have won at least four points in total and at least two points more than the opponent.");
            Console.WriteLine("- The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as 'Love', 'Fifteen', 'Thirty', and 'Forty' respectively.");
            Console.WriteLine("- If at least three points have been scored by each player, and the scores are equal, the score is 'Deuce'.");
            Console.WriteLine("- If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is 'Advantage' for the player in the lead.\n\n");
        }
        
        public void AssignPointToHome()
        {
            HomeScore++;
        }

        public void AssignPointToAway()
        {
            AwayScore++;
        }


        public string GetScore()
        {
            if (HomeScore <= 3 && AwayScore <= 3)
            {
                return (enTennisScore)HomeScore + " - " + (enTennisScore)AwayScore;
            }
            else
            {
                var differenza = Math.Abs(HomeScore - AwayScore);

                return differenza switch
                {
                    0 => "Deuce",
                    1 => "Advantage for " + (HomeScore > AwayScore ? "Home player" : "Away player"),
                    _ => "The winner is " + (HomeScore > AwayScore ? " home player" : "away player"),
                };
            }
        }

        public bool IsFinished()
        {
            if ((HomeScore >= 4 || AwayScore >= 4) && Math.Abs(HomeScore - AwayScore) > 1)
                return true;
            return false;
        }
    }
}
