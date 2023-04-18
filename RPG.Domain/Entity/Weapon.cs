using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Domain.Entity
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        // One to One Relationship -> One Character (Primary Key) can have one Weapon
        public Character? Character { get; set; }
        // Declaration of Foreign Key in One to One relationship
        public int CharacterId { get; set; }
    }
}
