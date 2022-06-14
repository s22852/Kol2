using System.Collections.Generic;

namespace Kol2_ko_s22852.Models
{
    public class Musician
    {
        public int IdMusician { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public virtual IEnumerable<Musician_Tracks>  Musician_Tracks { get; set; }
    }
}