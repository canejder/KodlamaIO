namespace GameMarketingProject
{
    public class Game
    {
        private int _id;
        public int Id { get;}
        public string Name { get; set; }
        public float Count { get; set; }
        public float Price { get; set; }

        public Game()
        {
            Id = _id;
            _id += 1;
        }
    }
}