using System;
using System.Collections.Generic;

namespace Test.Models
{
	public class MusicLabel
	{
		public int IdMusicLabel { get; set; }
		public string Name { get; set; }


		public virtual ICollection<Album> album { get; set;}
	}
}


