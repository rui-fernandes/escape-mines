namespace EscapeMines.Domain
{
    public class Turtle
    {
        public Turtle(Coordinates position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public Coordinates Position { get; }

        public Direction Direction { get; private set; }

        public void Move(Moves move)
        {
            switch (move)
            {
                case Moves.None:
                    break;

                case Moves.R:
                    this.RotateRight();
                    break;

                case Moves.L:
                    this.RotateLeft();
                    break;

                case Moves.M:
                    this.Move();
                    break;
            }
        }

        private void RotateRight()
        {
            switch (this.Direction)
            {
                case Direction.None:
                    break;

                case Direction.North:
                    this.Direction = Direction.East;
                    break;

                case Direction.South:
                    this.Direction = Direction.West;
                    break;

                case Direction.West:
                    this.Direction = Direction.North;
                    break;

                case Direction.East:
                    this.Direction = Direction.South;
                    break;
            }
        }

        private void RotateLeft()
        {
            switch (this.Direction)
            {
                case Direction.None:
                    break;

                case Direction.North:
                    this.Direction = Direction.West;
                    break;

                case Direction.South:
                    this.Direction = Direction.East;
                    break;

                case Direction.West:
                    this.Direction = Direction.South;
                    break;

                case Direction.East:
                    this.Direction = Direction.North;
                    break;
            }
        }

        private void Move()
        {
            switch (this.Direction)
            {
                case Direction.None:
                    break;

                case Direction.North:
                    this.Position.Y++;
                    break;

                case Direction.South:
                    this.Position.Y--;
                    break;

                case Direction.West:
                    this.Position.X--;
                    break;

                case Direction.East:
                    this.Position.X++;
                    break;
            }
        }
    }
}
