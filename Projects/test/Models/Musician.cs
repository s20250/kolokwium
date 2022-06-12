using System;
using System.Collections.Generic;

namespace Test.Models
{
    public class Musician
{
    public int IdMusicina { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nickname { get; set; }

        public virtual ICollection<MusicianTrack> musicianTrak { get; set; }

}
}


