using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Club
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Player> Players { get; set; }


    }
}
