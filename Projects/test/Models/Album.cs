using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class Album
    {

        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public string PublishDate { get; set; }
        public int IdMusicLabel { get; set; }

        public virtual ICollection<Track> track { get; set; }
        public virtual MusicLabel musicLabel { get; set; }

        //public virtual ICollection<Track> track { get; set; }
        //public virtual MusicLabel musicLabel { get; set; }

    }
}
