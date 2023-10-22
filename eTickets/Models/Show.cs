using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace AvatarCollections.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }

        [Display(Name= "Show Logo")]
        public string Logo { get; set; }
        [Display(Name = "Show Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }


        //Relationship
        public List<Collectable> Collectables { get; set; }
    }
}
