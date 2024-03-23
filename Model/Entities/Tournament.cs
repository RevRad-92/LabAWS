﻿namespace Model.Entities
{
    public class Tournament
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Club> Clubs { get; set; }

        public List<Match> Matches { get; set; }

        private Standing Standing { get; set; }


        public Tournament()
        {
            this.Standing = new Standing();
        }

    }
}
