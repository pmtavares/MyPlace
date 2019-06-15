using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPlace.data;
using MyPlace.models;
using MyPlace.resources;

namespace MyPlace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MyPlaceDbContext _context;

        private readonly IMapper _mapper;

        public UsersController(MyPlaceDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<UsersResource>> GetUsers()
        {
            var users= await _context.Users.Include(u=> u.Articles).ToListAsync();

            return _mapper.Map<List<UsersResource>>(users);
        }
    }
}