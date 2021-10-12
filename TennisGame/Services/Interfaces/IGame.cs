using System;
using System.Collections.Generic;
using System.Text;

namespace TennisGame.Services.Interfaces
{
    public interface IGame
    {
        void GameInfo();
        void AssignPointToHome();
        void AssignPointToAway();
        string GetScore();
        bool IsFinished();
    }
}
