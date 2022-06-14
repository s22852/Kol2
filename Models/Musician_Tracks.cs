namespace Kol2_ko_s22852.Models
{
    public class Musician_Tracks
    {
        public int IdMusician { get; set; }
        public int IdTrack { get; set; }
        public virtual Musician Musician { get; set; }
        public virtual Track Track { get; set; }
    }
}