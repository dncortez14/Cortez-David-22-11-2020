using Service.Models;
using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cortez_David_22_11_2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : Controller
    {
        private readonly IService _service;
        public PhotosController(IService service)
        {
            _service = service;
        }

        // GET api/<photosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IEnumerable<Photo> photos = _service.GetPhotosByAlbum(id);

            return Ok(photos);
        } 
    }
}
