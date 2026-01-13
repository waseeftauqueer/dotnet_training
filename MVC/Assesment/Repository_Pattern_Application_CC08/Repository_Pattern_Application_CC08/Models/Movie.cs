using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repository_Pattern_Application_CC08.Models
{
    public class Movie
    {
        [Key]
        public int MId { get; set; }

        [Required(ErrorMessage = "Movie name is required")]
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }

        [Required(ErrorMessage = "Director name is required")]
        [Display(Name = "Director")]
        public string DirectorName { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime DateOfRelease { get; set; }
    }
}