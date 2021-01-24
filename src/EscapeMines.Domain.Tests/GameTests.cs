namespace EscapeMines.Domain.Tests
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void Play_OutsideBoard_DangerReturned()
        {
            // Arrange
            var settings = new GameSettings
            {
                BoardLimits = new Coordinates { X = 2, Y = 2 },
                ExitPosition = new Coordinates { X = 2, Y = 2 },
                Mines = new List<Coordinates> { new Coordinates { X = 2, Y = 1 } },
                Moves = new List<Moves> { Moves.M },
                StartPosition = new Coordinates { X = 1, Y = 1 },
                StartDirection = Direction.South,
            };

            var game = new Game(settings);

            // Act
            var result = game.Play();

            // Assert
            result.Should().NotBeNull();
            result.Should().Be(GameResult.Danger);
        }

        [TestMethod]
        public void Play_HitMine_MineHitReturned()
        {
            // Arrange
            var settings = new GameSettings
            {
                BoardLimits = new Coordinates { X = 2, Y = 2 },
                ExitPosition = new Coordinates { X = 2, Y = 2 },
                Mines = new List<Coordinates> { new Coordinates { X = 1, Y = 2 } },
                Moves = new List<Moves> { Moves.M },
                StartPosition = new Coordinates { X = 1, Y = 1 },
                StartDirection = Direction.North,
            };

            var game = new Game(settings);

            // Act
            var result = game.Play();

            // Assert
            result.Should().NotBeNull();
            result.Should().Be(GameResult.MineHit);
        }

        [TestMethod]
        public void Play_ReachExit_SuccessReturned()
        {
            // Arrange
            var settings = new GameSettings
            {
                BoardLimits = new Coordinates { X = 2, Y = 2 },
                ExitPosition = new Coordinates { X = 1, Y = 2 },
                Mines = new List<Coordinates> { new Coordinates { X = 2, Y = 1 } },
                Moves = new List<Moves> { Moves.M },
                StartPosition = new Coordinates { X = 1, Y = 1 },
                StartDirection = Direction.North,
            };

            var game = new Game(settings);

            // Act
            var result = game.Play();

            // Assert
            result.Should().NotBeNull();
            result.Should().Be(GameResult.Sucess);
        }
    }
}
