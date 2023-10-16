using Cinemava.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cinemava.Models
{
    public class Producer : IEntityBase
    {
        public int Id { get; set; }
        [Display(Name = "Profile Picure")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }  //Lidhja nje me shume
    }
}
