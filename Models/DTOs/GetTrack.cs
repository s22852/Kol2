namespace Kol2.Models.DTOs
{
    public class GetTrack
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; } 
        public int? IdMusicAlbum { get; set; }
    }
}