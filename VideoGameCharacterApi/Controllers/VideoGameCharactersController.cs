using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Models;
using VideoGameCharacterApi.Services;

namespace VideoGameCharacterApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VideoGameCharactersController(ICharacterService service) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Character>>> GetCharacters()
        => Ok(await service.GetAllCharactersAsync());

    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacterById(int id)
    {
        var character = await service.GetCharacterByIdAsync(id);
        if (character is null)
        {
            return NotFound("Character with the given ID was not found.");
        }
        return Ok(character);
    }
}
