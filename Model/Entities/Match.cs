using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Match
    {
        public int Id { get; set; }

        // fecha y hora del partido
        public DateTime DateTime { get; set; }

        // Equipo 1 "local"
        [ForeignKey(nameof(HomeClub))]
        public int IdHomeClub { get; set; }
        private Club HomeClub { get; }

        // Equipo 2 "visitante"
        [ForeignKey(nameof(AwayClub))]
        public int IdAwayClub { get; set; }
        private Club AwayClub { get; }

        // "Score"
        public string Result { get; set; }

        // Lugar del partido
        public Stadium Venue { get; set; }



        // Asociación con clubs
        public Match(Club home, Club away)
        {
            this.HomeClub = home;
            this.AwayClub = away;
        }

        // uso stadium
        public void Use(Stadium stadium)
        {
            // stadium.Host()
        }

    }
}
