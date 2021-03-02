using GameMarketingProject.Business;

namespace GameMarketingProject
{
    public class Campaign : IManagable
    {
        private static int _id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public float Modifier { get; set; }

        public Campaign()
        {
            Id = _id;
            _id += 1;
        }
    }
}