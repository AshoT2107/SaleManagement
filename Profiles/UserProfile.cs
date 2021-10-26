using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPage.Dto;
using UserPage.Model;

namespace UserPage.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreatedDto, User>();

            CreateMap<User, UserReadDto>();
        }
    }
}
