using System.Collections.Generic;
using System;
using Kol2_ko_s22852.Models;

namespace Kol2.Models.DTOs
{
    public class GetAlbum
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public int IdMusicLabel { get; set; }

        public List<GetTrack> Tracks  {get; set; }
    }
}