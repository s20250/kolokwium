using System;
using System.Threading.Tasks;

namespace kolokwium_s20250.Services
{
	public interface IAlbumDbService
	{
			
		Task<bool> GetAlbums(int IdAlbum);
		Task<bool> GetAlbums();
		}
	
}

