using System;
using System.Collections.Generic;

namespace TennisGame_20210108
{
    public class TennisGame
    {
        // 46 min
        private int _player1Score;
        private int _player2Score;

        private readonly string _player2Name;
        private readonly string _player1Name;


        private readonly Dictionary<int, string> _dict = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

        public TennisGame(string player1Name, string player2Name)
        {
            this._player1Name = player1Name;
            this._player2Name = player2Name;
        }


        public string Score()
        {
            return IsSameScore()
                ? IsSameScoreAndIsDeuce() ? ResultDeuce() : ResultSameScore()
                : IsReadyForWin()
                    ? ResultAdvOrWin()
                    : ResultNormalScore();
        }

        private string ResultAdvOrWin()
        {
            return $"{AdvPlayer()} {(IsAdv()? "Adv":"Win")}";
        }

        private string ResultNormalScore()
        {
            return $"{_dict[_player1Score]} {_dict[_player2Score]}";
        }

        private bool IsAdv()
        {
            return Math.Abs(_player1Score - _player2Score) == 1;
        }

        private bool IsReadyForWin()
        {
            return _player1Score > 3 || _player2Score > 3;
        }

        private string ResultSameScore()
        {
            return $"{_dict[_player1Score]} All";
        }

        private static string ResultDeuce()
        {
            return "Deuce";
        }

        private bool IsSameScoreAndIsDeuce()
        {
            return IsSameScore() && _player1Score >= 3;
        }

        private string AdvPlayer()
        {
            return _player1Score > _player2Score ? _player1Name : _player2Name;
        }

        private bool IsSameScore()
        {
            return _player1Score == _player2Score;
        }

        public void SetPlayer1Score(int score)
        {
            this._player1Score = score;
        }

        public void SetPlayer2Score(int score)
        {
            this._player2Score = score;
        }
    }
}