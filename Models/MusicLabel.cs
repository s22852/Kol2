using System.Collections.Generic;

namespace Kol2.Models
{
    public class MusicLabel
    {
        public int IdMusicLabel { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Album>  Albums { get; set; }
    }
}