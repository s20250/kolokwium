using System;
using System.Collections.Generic;

namespace kolokwium_s20250.Models
{
	public class MusicLabel
	{
		public int IdMusicLabel { get; set; }
		public string Name { get; set; }


		public virtual ICollection<Album> album { get; set;}
	}
}


