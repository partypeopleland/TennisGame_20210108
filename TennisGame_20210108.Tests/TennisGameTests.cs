using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_20210108.Tests
{
    [TestClass]
    public class TennisGameTests
    {
        readonly TennisGame _tennisGame = new TennisGame("Player1", "Player2");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.SetPlayer1Score(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            _tennisGame.SetPlayer1Score(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.SetPlayer1Score(3);
            ScoreShouldBe("Forty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SetPlayer2Score(1);
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennisGame.SetPlayer2Score(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Forty()
        {
            _tennisGame.SetPlayer2Score(3);
            ScoreShouldBe("Love Forty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennisGame.SetPlayer1Score(1);
            _tennisGame.SetPlayer2Score(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            _tennisGame.SetPlayer1Score(2);
            _tennisGame.SetPlayer2Score(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            _tennisGame.SetPlayer1Score(3);
            _tennisGame.SetPlayer2Score(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_When_4_4()
        {
            _tennisGame.SetPlayer1Score(4);
            _tennisGame.SetPlayer2Score(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Player1_Adv()
        {
            _tennisGame.SetPlayer1Score(4);
            _tennisGame.SetPlayer2Score(3);
            ScoreShouldBe("Player1 Adv");
        }
        
        [TestMethod]
        public void Player2_Adv()
        {
            _tennisGame.SetPlayer1Score(3);
            _tennisGame.SetPlayer2Score(4);
            ScoreShouldBe("Player2 Adv");
        }
        
        [TestMethod]
        public void Player1_Win()
        {
            _tennisGame.SetPlayer1Score(5);
            _tennisGame.SetPlayer2Score(3);
            ScoreShouldBe("Player1 Win");
        }
                                                                                                                          

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}