using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using Microsoft.EntityFrameworkCore;
using RPG.Application.Abstraction.Repository;
using RPG.Application.DTO.Character;
using RPG.Domain.Entity;
using RPG.Infrastructure.Data;

namespace RPG.Infrastructure.Repository
{

    public class CharacterRepository : ICharacterRepository
    {
        private readonly DataContext _context;

        public CharacterRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Character>?> GetAllCharacters()
        {
            return await _context.Characters.ToListAsync();
        }
        public async Task<Character?> GetById(int id)
        {
            return await _context.Characters.FindAsync(id);
            // return await _context.Characters.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            await _context.Characters.AddAsync(newCharacter);
            await _context.SaveChangesAsync();
            return await _context.Characters.ToListAsync();
        }

        public async Task<Character> UpdateCharacter(Character updatedCharacter)
        {
            var character =
                await _context.Characters
                    .Include(c => c.User)
                    .FirstOrDefaultAsync(c => c.Id == updatedCharacter.Id);

            character = updatedCharacter;
            await _context.SaveChangesAsync();
            return character;

        }

        public async Task<List<Character>> DeleteCharacter(int id, int userId)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(c => c.Id == id && c.User!.Id == userId);
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return await _context.Characters.ToListAsync();
        }
    }
}
