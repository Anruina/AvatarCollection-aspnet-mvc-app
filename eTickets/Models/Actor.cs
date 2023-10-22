﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
