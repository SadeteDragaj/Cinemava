using System.Collections.Generic;

namespace Cinemava.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actors_Movie> Actor_Movies { get; set; }
    }
}
