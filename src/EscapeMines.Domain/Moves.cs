namespace EscapeMines.Domain
{
    /// <summary>
    /// Describes the available moves of this game.
    /// </summary>
    public enum Moves
    {
        /// <summary>
        /// No move.
        /// </summary>
        None = 0,

        /// <summary>
        /// Rotate 90 degrees to the right.
        /// </summary>
        R = 1,

        /// <summary>
        /// Rotate 90 degrees to the left.
        /// </summary>
        L = 2,

        /// <summary>
        /// Move.
        /// </summary>
        M = 3,
    }
}
