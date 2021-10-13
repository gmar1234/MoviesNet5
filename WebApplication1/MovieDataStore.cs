using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MovieDataStore
    {
        public List<MovieDto> Movies { get; set; };
        public MovieDataStore()
        {
            Movies = new List<MovieDto>()
            {
                new MovieDto()
                {
                    Id= 1,
                    Name="Hola",
                    Description="Como estas"
                },
                 new MovieDto()
                {
                    Id= 2,
                    Name="Gian",
                    Description="bien"
                },
                  new MovieDto()
                {
                    Id= 3,
                    Name="Marco",
                    Description="Bien o mal"
                }
            };
        }
    }
}
