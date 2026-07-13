using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public class CharacterService : ICharacterService
{
    static List<Character> characters = new List<Character> {
        new () { Id = 1, Name = "Mario", Game = "Super Mario Bros.", Role = "Hero" },
        new () { Id = 2, Name = "Link", Game = "The Legend of Zelda", Role = "Hero" },
        new () { Id = 3, Name = "Master Chief", Game = "Halo", Role = "Hero" },
        new () { Id = 4, Name = "Bowser", Game = "Super Mario Bros.", Role = "Villain" }
    };

    public Task<Character> AddCharacterAsync(Character newCharacter)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCharacterAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Character>> GetAllCharactersAsync()
    {
        return await Task.FromResult(characters);
    }

    public async Task<Character?> GetCharacterByIdAsync(int id)
    {
        var selectedCharacter = characters.FirstOrDefault(c => c.Id == id);
        return await Task.FromResult(selectedCharacter);
    }

    public Task<bool> UpdateCharacterAsync(int id, Character updatedCharacter)
    {
        throw new NotImplementedException();
    }
}
