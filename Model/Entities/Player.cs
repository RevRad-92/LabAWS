using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Player
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Number { get; set; }

        [ForeignKey(nameof(Club))]
        public int IdClub { get; set; }

        public Club Club { get; set; }
    }
}