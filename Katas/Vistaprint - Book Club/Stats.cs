namespace Vistaprint.BookClub
{
    public struct Stats
    {
        public int count { get; }
        public int maximumValue { get; }
        public int minimumValue { get; }
        public double averageValue { get; set; }

        public Stats(int count, int maximumValue = 0, int minimumValue = 0, double averageValue = 0)
        {
            this.count = count;
            this.maximumValue = maximumValue;
            this.minimumValue = minimumValue;
            this.averageValue = averageValue;
        }

        public readonly static Stats Empty = new Stats(0);
    }
}