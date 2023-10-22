using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;
using AvatarCollections.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvatarCollections.Models
{
    public class Collectable
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Category Category { get; set; }


        //relationship
        public List<Actor_Collectable>? Actors_Movies { get; set; }

        //cinema

        public int ShowId { get; set; }
        [ForeignKey("ShowId")]
        public Show? Show { get; set; }

        //Producer

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
    }
}
