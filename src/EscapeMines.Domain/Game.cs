namespace EscapeMines.Domain
{
    public class Game
    {
        private readonly GameSettings settings;
        private readonly Turtle turtle;

        public Game(GameSettings settings)
        {
            this.settings = settings;
            this.turtle = new Turtle(this.settings.StartPosition, this.settings.StartDirection);
        }

        public GameResult Play()
        {
            foreach (var move in this.settings.Moves)
            {
                this.turtle.Move(move);

                if (this.TurtleIsOutsideBoardLimits())
                {
                    return GameResult.Danger;
                }

                if (this.TurtleHitOneMine())
                {
                    return GameResult.MineHit;
                }

                if (this.TurtleReachedExit())
                {
                    return GameResult.Sucess;
                }
            }

            return GameResult.Danger;
        }

        private bool TurtleIsOutsideBoardLimits()
        {
            if (this.turtle.Position.X > this.settings.BoardLimits.X || this.turtle.Position.X < 0)
            {
                return true;
            }

            if (this.turtle.Position.Y > this.settings.BoardLimits.Y || this.turtle.Position.Y < 0)
            {
                return true;
            }

            return false;
        }

        private bool TurtleHitOneMine()
        {
            foreach (var mine in this.settings.Mines)
            {
                if (this.turtle.Position.X == mine.X && this.turtle.Position.Y == mine.Y)
                {
                    return true;
                }
            }

            return false;
        }

        private bool TurtleReachedExit()
        {
            return this.turtle.Position.X == this.settings.ExitPosition.X && this.turtle.Position.Y == this.settings.ExitPosition.Y;
        }
    }
}
