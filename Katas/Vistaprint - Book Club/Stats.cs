namespace Vistaprint.BookClub
{
    public struct Stats
    {
        public int count { get; set; }

        public readonly static Stats Empty = new Stats()
        {
            count = 0
        };
    }
}