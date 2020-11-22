using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IService
    {
        IEnumerable<Album> GetAlbums();

        IEnumerable<Photo> GetPhotosByAlbum(int albumId);

        IEnumerable<Comment> GetComments(int postId);
    }
}
