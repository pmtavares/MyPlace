using AutoMapper;
using MyPlace.models;
using MyPlace.resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.data
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UsersResource>();

            CreateMap<UsersResource, User>();

            CreateMap<Article, ArticleResource>();

            CreateMap<Category, CategoryResource>();
        }
    }
}
