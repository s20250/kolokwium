using System;
using System.Collections.Generic;

namespace kolokwium_s20250.Models
{
    public class Album
    {

        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public string PublishDate { get; set; }
        public int IdMusicLabel { get; set; }

        public virtual ICollection<Track> track {get; set;}
        public virtual MusicLabel musicLabel { get; set; }

    }
}
