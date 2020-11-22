using Service.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Service;

namespace Cortez_David_22_11_2020.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IService _service;

        public AlbumController(IService service)
        {
            _service = service;
        }

        // GET: Album
        public ActionResult Index()
        {
            var albums = _service.GetAlbums();

            return View(albums);
        }
    }
}
