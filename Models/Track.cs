using System;
using System.Collections.Generic;
using Kol2.Models;

namespace Kol2_ko_s22852.Models
{
    public class Track
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; } 
        public virtual IEnumerable<Musician_Tracks> Musician_Tracks { get; set; }

        public int? IdMusicAlbum { get; set; }

        public virtual Album Album { get; set; }
    }
}