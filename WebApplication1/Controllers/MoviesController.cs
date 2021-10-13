using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        //[HttpGet("api/movies")]
        public JsonResult GetMovies()
        {
            return new JsonResult(
                new List<object>(){
                    new {Id = 1, Name="Matrix"},
                    new {Id = 2, Name="Gian Marco"},
                }
            );
        }
    }
}
