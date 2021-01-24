namespace EscapeMines.Domain.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TurtleTests
    {
        [TestMethod]
        public void Move_RotateRightFromNorth_DirectionEast()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.North);

            // Act
            turtle.Move(Moves.R);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.East);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateRightFromEast_DirectionSouth()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.East);

            // Act
            turtle.Move(Moves.R);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.South);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateRightFromSouth_DirectionWest()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.South);

            // Act
            turtle.Move(Moves.R);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.West);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateRightFromWest_DirectionNorth()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.West);

            // Act
            turtle.Move(Moves.R);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.North);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateLeftFromNorth_DirectionWest()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.North);

            // Act
            turtle.Move(Moves.L);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.West);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateLeftFromWest_DirectionSouth()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.West);

            // Act
            turtle.Move(Moves.L);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.South);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateLeftFromSouth_DirectionEast()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.South);

            // Act
            turtle.Move(Moves.L);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.East);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_RotateLeftFromEast_DirectionNorth()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.East);

            // Act
            turtle.Move(Moves.L);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.North);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(1);
            turtle.Position.Y.Should().Be(1);
        }

        [TestMethod]
        public void Move_MoveToNorth_YCoordinateIncremented()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.North);

            // Act
            turtle.Move(Moves.M);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.North);
            turtle.Position.Should().NotBeNull();
            turtle.Position.Y.Should().Be(2);
        }

        [TestMethod]
        public void Move_MoveToEast_XCoordinateIncremented()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.East);

            // Act
            turtle.Move(Moves.M);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.East);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(2);
        }

        [TestMethod]
        public void Move_MoveToSouth_YCoordinateDecremented()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.South);

            // Act
            turtle.Move(Moves.M);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.South);
            turtle.Position.Should().NotBeNull();
            turtle.Position.Y.Should().Be(0);
        }

        [TestMethod]
        public void Move_MoveToWest_XCoordinateDecremented()
        {
            // Arrange
            var turtle = new Turtle(
                new Coordinates
                {
                    X = 1,
                    Y = 1,
                },
                Direction.West);

            // Act
            turtle.Move(Moves.M);

            // Assert
            turtle.Should().NotBeNull();
            turtle.Direction.Should().Be(Direction.West);
            turtle.Position.Should().NotBeNull();
            turtle.Position.X.Should().Be(0);
        }
    }
}
