using System;
using Xunit;
using Tic_Toc_Toe.Classes;
using Tic_Toc_Toe;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        static Player p1 = new Player
        {
            Name = "Yahia",
            Marker = "X",
            IsTurn = true
        };

        static Player p2 = new Player
        {
            Name = "Issa",
            Marker = "O",
            IsTurn = false
        };

        Game newGame = new Game(p1, p2);

        [Fact]
        public void TestWinningBoard1()
        {
            //arrange

            string[,] winBoard1 = new string[,]
            {
                {"1", "X", "3"},
                {"4", "X", "6"},
                {"7", "X", "9"},
            };

            newGame.Board.GameBoard = winBoard1;

            //assert
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        [Fact]
        public void TestWinningBoard2()
        {
            //arrange

            string[,] winBoard2 = new string[,]
            {
                {"O", "O", "O"},
                {"4", "X", "6"},
                {"7", "X", "9"},
            };

            newGame.Board.GameBoard = winBoard2;

            //assert
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        [Fact]
        public void TestWinningBoard3()
        {
            //arrange

            string[,] winBoard3 = new string[,]
            {
                {"X", "X", "O"},
                {"4", "O", "6"},
                {"O", "X", "9"},
            };

            newGame.Board.GameBoard = winBoard3;

            //assert
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }

        [Fact]
        public void TestForFirstPlayerTurn()
        {
            Assert.True(p1.IsTurn);
        }

        [Fact]
        public void TestForPlayerSwitch()
        {
            newGame.SwitchPlayer();
            Assert.True(p2.IsTurn);
        }

        [Fact]
        public void TestForRow()
        {
            //We want 1 = 0 for Row position
            Position testPosition = new Position(0, 0);


            Assert.Equal(testPosition.Row, Player.PositionForNumber(1).Row);
        }

        [Fact]
        public void TestForColumn()
        {
            //We want 2 = 1 for Column position
            Position testPosition = new Position(0, 1);


            Assert.Equal(testPosition.Column, Player.PositionForNumber(2).Column);
        }

        [Fact]
        public void TestFailingBoard1()
        {
            //assert
            Assert.False(newGame.CheckForWinner(newGame.Board));
        }

    }
}
