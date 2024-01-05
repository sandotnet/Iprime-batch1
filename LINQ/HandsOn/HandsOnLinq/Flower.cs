namespace HandsOnLinq
{
    class Flower
    {
        public Flower(string n, int p)
        {
            Name = n;
            Petals = p;
        }
        public string Name { get; set; }
        public int Petals { get; set; }
    }
}
