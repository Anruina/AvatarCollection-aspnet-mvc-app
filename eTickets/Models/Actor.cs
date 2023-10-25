using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

namespace AvatarCollections.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required.")]
        public string? ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Full Name is required.")]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required.")]
        public string? Bio { get; set; }


        //Relationship
        public List<Actor_Collectable>? Actors_Collectables { get; set; }

    }
}
