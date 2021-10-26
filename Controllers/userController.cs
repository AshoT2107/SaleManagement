
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPage.DataRepository;
using UserPage.Dto;
using UserPage.Model;

namespace UserPage.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class userController:ControllerBase
    {
        private readonly IUserApiRepository _userApiRepository;
        private readonly IMapper _mapper;
        public userController(IUserApiRepository userApiRepository, IMapper mapper)
        { 
            _userApiRepository = userApiRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult>createUser(UserCreatedDto userCreatedDto)
        {
            var model = _mapper.Map<User>(userCreatedDto);
            await _userApiRepository.createuser(model);
            await _userApiRepository.savechangeasync();
            var userReadDto = _mapper.Map<UserReadDto>(model);
            return Created("", model);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>getbyid(int id)
        {
           var user = await _userApiRepository.get(id);
            return Ok(_mapper.Map<UserReadDto>(user));
        }
    }
}
