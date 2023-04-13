using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPG.Application.Abstraction.Repository;
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
    }
}
