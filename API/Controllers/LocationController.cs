using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public LocationController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var regionsDomain = _dbContext.kaniniLocations.ToList();

            var regionDto = new List<locationDto>();
            foreach (var regionDomain in regionsDomain)
            {
                regionDto.Add(new locationDto()
                {
                    kaniniLocationId = regionDomain.kaniniLocationId,
                    Location = regionDomain.Location,
                });
            }
            return Ok(regionDto);
        }

    }
}

