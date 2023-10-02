using System.Collections.Generic;

namespace Cinemava.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }  //Lidhja nje me shume
    }
}
