namespace EscapeMines.Infrastructure
{
    using System.Collections.Generic;
    using System.IO;
    using EscapeMines.Application;
    using EscapeMines.Domain;

    public class SettingsFileReader : ISettingsReader
    {
        private readonly string settingsFile;

        public SettingsFileReader(string settingsFile)
        {
            this.settingsFile = settingsFile;
        }

        public GameSettings GetSettings()
        {
            var lines = File.ReadAllLines(this.settingsFile);

            return new GameSettings
            {
                BoardLimits = GetBoardLimits(lines),
                Mines = GetMines(lines),
                ExitPosition = GetExitPosition(lines),
                StartPosition = GetStartPosition(lines),
                StartDirection = GetStartDirection(lines),
                Moves = GetMoves(lines),
            };
        }

        private static Coordinates GetBoardLimits(string[] lines)
        {
            var boardSize = lines[0].Split(' ');
            int.TryParse(boardSize[0], out var boardX);
            int.TryParse(boardSize[1], out var boardY);

            return new Coordinates
            {
                X = boardX,
                Y = boardY,
            };
        }

        private static List<Coordinates> GetMines(string[] lines)
        {
            var minesPositions = lines[1].Split(' ');
            var mines = new List<Coordinates>(minesPositions.Length);

            foreach (var minePosition in minesPositions)
            {
                int.TryParse(minePosition.Split(',')[0], out var mineX);
                int.TryParse(minePosition.Split(',')[1], out var mineY);

                mines.Add(new Coordinates
                {
                    X = mineX,
                    Y = mineY,
                });
            }

            return mines;
        }

        private static Coordinates GetExitPosition(string[] lines)
        {
            var exitPoint = lines[2].Split(' ');
            int.TryParse(exitPoint[0], out var exitX);
            int.TryParse(exitPoint[1], out var exitY);

            return new Coordinates
            {
                X = exitX,
                Y = exitY,
            };
        }

        private static Coordinates GetStartPosition(string[] lines)
        {
            var startPoint = lines[3].Split(' ');
            int.TryParse(startPoint[0], out var startX);
            int.TryParse(startPoint[1], out var startY);

            return new Coordinates
            {
                X = startX,
                Y = startY,
            };
        }

        private static Direction GetStartDirection(string[] lines)
        {
            var startPoint = lines[3].Split(' ');

            switch (startPoint[2])
            {
                case "N":
                    return Direction.North;

                case "S":
                    return Direction.South;

                case "W":
                    return Direction.West;

                case "E":
                    return Direction.East;

                default:
                    return Direction.None;
            }
        }

        private static List<Moves> GetMoves(string[] lines)
        {
            var moves = new List<Moves>();

            for (int i = 4; i < lines.Length; i++)
            {
                foreach (var move in lines[i].Split(' '))
                {
                    switch (move)
                    {
                        case "R":
                            moves.Add(Moves.R);
                            break;

                        case "L":
                            moves.Add(Moves.L);
                            break;

                        case "M":
                            moves.Add(Moves.M);
                            break;
                    }
                }
            }

            return moves;
        }
    }
}
