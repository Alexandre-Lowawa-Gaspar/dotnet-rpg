using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [HttpGet("GetCharacterAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetAllCharacter()
        {
            return Ok(await _characterService.GetAllCharacters());
        }
        [HttpGet("GetCharacterById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetCharacter(int id)
        {

            return Ok(await _characterService.GetCharacterById(id));
        }
        [HttpPost("AddCharacter")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacher(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
        [HttpPut("UpdateCharacter")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacher(UpdateCharacterDto updateCharacter)
        {
            var response = await _characterService.UpdadeCharacter(updateCharacter);
            if(response is null)
            return NotFound(response);
            return Ok(response);
        }
        [HttpDelete("DeleteCharacter/{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> DeleteCharater(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if(response is null)
            return NotFound(response);
            return Ok(response);
        }
    }
}