using Service.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Service;

namespace Cortez_David_22_11_2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IService _service;
        public CommentsController(IService service)
        {
            _service = service;
        }

        // GET api/<CommentsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IEnumerable<Comment> comments = _service.GetComments(id);
            return Ok(comments);
        }
    }
}
