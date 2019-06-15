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
    public class ArticlesController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly MyPlaceDbContext _context;

        public ArticlesController(IMapper mapper, MyPlaceDbContext context)
        {
            _mapper = mapper;
            _context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<ArticleResource>> GetArticles()
        {
            var articles = await _context.Articles.Include(c => c.Category).ToListAsync();

            return _mapper.Map<List<ArticleResource>>(articles);
        }
    }
}