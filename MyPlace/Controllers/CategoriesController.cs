using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPlace.data;
using MyPlace.resources;

namespace MyPlace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly MyPlaceDbContext _context;

        public CategoriesController(IMapper mapper, MyPlaceDbContext context)
        {
            _mapper = mapper;
            _context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetArticles()
        {
            var categories = await _context.Categories.ToListAsync();

            return _mapper.Map<List<CategoryResource>>(categories);
        }
    }
}