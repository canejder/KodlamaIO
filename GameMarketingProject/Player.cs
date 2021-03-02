using System;
using GameMarketingProject.Business;

namespace GameMarketingProject
{
    public class Player : IManagable
    {
        private static int _id = 0;
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string CitizenshipNumber { get; set; }

        public Player()
        {
            Id = _id;
            _id += 1;
        }
    }
}