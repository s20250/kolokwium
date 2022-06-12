using System;
using System.Collections.Generic;

namespace Test.Models
{
	public class Track
    {
        public int IdTrack { get; set; }
        public string TrackName { get; set; }
        public float Duration { get; set; }
        public int IdMusicAlbum { get; set; }

        public virtual ICollection<MusicianTrack> MusicianTrack { get; set; }
        public virtual Album album { get; set; }
    }
}

