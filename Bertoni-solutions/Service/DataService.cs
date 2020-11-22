using Flurl;
using Flurl.Http;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class DataService : IService
    {
        private readonly string _url;

        public DataService(string url)
        {
            _url = url;
        }

        public IEnumerable<Album> GetAlbums()
        {
            IEnumerable<Album> albums = _url.AppendPathSegment("albums").GetJsonAsync<IEnumerable<Album>>().Result;

            return albums;
        }

        public IEnumerable<Comment> GetComments(int postId)
        {
            IEnumerable<Comment> comments =
                _url
                .AppendPathSegment("comments")
                .SetQueryParam("postId", postId)
                .GetJsonAsync<IEnumerable<Comment>>().Result;

            return comments;
        }

        public IEnumerable<Photo> GetPhotosByAlbum(int albumId)
        {
            IEnumerable<Photo> photos = 
                _url
                .AppendPathSegment("photos")
                .SetQueryParam("albumId", albumId)
                .GetJsonAsync<IEnumerable<Photo>>().Result;

            return photos;
        }
    }
}
