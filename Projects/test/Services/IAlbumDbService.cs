using System;
using System.Threading.Tasks;

namespace Test.Services
{
	public interface IAlbumDbService
	{
        Task<bool> GetAlbums(int IdAlbum);
		Task<bool> GetAlbums();
		Task<bool> DoesAlbumExists(int IdAlbum);

     
    }
	
}

