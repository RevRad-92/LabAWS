using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities
{
    public class Standing
    {
        public int Id { get; set; }
        public List<Club> Clubs { get; set; }

        [ForeignKey(nameof(Tournament))]
        public int idTournament { get; set; }

        public Tournament Tournament { get; set; }
    }
}
