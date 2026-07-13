using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Services;

public interface ICharacterService
{
    Task<List<Character>> GetAllCharactersAsync();
    Task<Character?> GetCharacterByIdAsync(int id);
    Task<Character> AddCharacterAsync(Character newCharacter);
    Task<bool> UpdateCharacterAsync(int id, Character updatedCharacter);
    Task<bool> DeleteCharacterAsync(int id);
}
