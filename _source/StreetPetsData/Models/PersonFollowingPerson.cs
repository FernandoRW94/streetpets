using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetPetsData.Models
{
    public class PersonFollowingPerson
    {
        [Key]
        public int Id { get; set; }

        public int FollowerId { get; set; }

        [ForeignKey("FollowerId")]
        public Person Follower { get; set; }

        public int FollowedId { get; set; }

        [ForeignKey("FollowedId")]
        public Person Followed { get; set; }
    }
}
