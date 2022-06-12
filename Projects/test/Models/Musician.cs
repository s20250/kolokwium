using System;
using System.Collections.Generic;

namespace kolokwium_s20250.Models
{
    public class Musician
{
    public int IdMusicina { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nickname { get; set; }

    public virtual ICollection<MusicianTrack> MusicianTrack { get; set; }
}
}


