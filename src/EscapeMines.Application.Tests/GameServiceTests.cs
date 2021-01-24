namespace EscapeMines.Application.Tests
{
    using System;
    using System.Collections.Generic;
    using EscapeMines.Application.Services;
    using EscapeMines.Domain;
    using FluentAssertions;
    using Microsoft.Extensions.Logging;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class GameServiceTests
    {
        private Mock<ISettingsReader> settingsReaderMock;
        private Mock<ILogger<GameService>> loggerMock;
        private GameService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.settingsReaderMock = new Mock<ISettingsReader>();
            this.loggerMock = new Mock<ILogger<GameService>>();

            this.service = new GameService(
                this.settingsReaderMock.Object,
                this.loggerMock.Object);
        }

        [TestMethod]
        public void NewGame_ValidSetup_NoErrorReturned()
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

            this.settingsReaderMock
                .Setup(s => s.GetSettings())
                .Returns(settings);

            // Act
            Action act = () => this.service.NewGame();

            // Assert
            act.Should().NotThrow();
            this.settingsReaderMock.VerifyAll();
        }

        [TestMethod]
        public void Play_ValidMove_NoErrorReturned()
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

            this.settingsReaderMock
                .Setup(s => s.GetSettings())
                .Returns(settings);

            this.service.NewGame();

            // Act
            Action act = () => this.service.Play();

            // Assert
            act.Should().NotThrow();
            this.settingsReaderMock.VerifyAll();
            this.loggerMock.VerifyAll();
        }
    }
}
