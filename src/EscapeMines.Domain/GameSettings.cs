namespace EscapeMines.Domain
{
    using System.Collections.Generic;

    public class GameSettings
    {
        public Coordinates BoardLimits { get; set; }

        public List<Coordinates> Mines { get; set; }

        public Coordinates ExitPosition { get; set; }

        public Coordinates StartPosition { get; set; }

        public Direction StartDirection { get; set; }

        public List<Moves> Moves { get; set; }
    }
}
