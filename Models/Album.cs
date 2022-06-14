using System;
using System.Collections.Generic;
using Kol2_ko_s22852.Models;

namespace Kol2.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public int IdMusicLabel { get; set; }
        public virtual MusicLabel MusicLabel{ get; set; }
        public virtual IEnumerable<Track> Tracks { get; set; }
    }
}