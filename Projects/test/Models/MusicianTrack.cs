using System;
namespace kolokwium_s20250.Models
{
	public class MusicianTrack
	{
		public int IdTrack { get; set; }
		public int IdMusician { get; set; }
		public virtual Musician Musician { get; set; }
		public virtual Track Track { get; set; }

	}
}

