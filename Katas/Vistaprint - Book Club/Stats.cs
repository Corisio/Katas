namespace Vistaprint.BookClub
{
    public struct Stats
    {
        public int count { get; }
        public int maximumValue { get; }
        public int minimumValue { get; }

        public Stats(int count, int maximumValue = 0, int minimumValue = 0)
        {
            this.count = count;
            this.maximumValue = maximumValue;
            this.minimumValue = minimumValue;
        }

        public readonly static Stats Empty = new Stats(0);
    }
}