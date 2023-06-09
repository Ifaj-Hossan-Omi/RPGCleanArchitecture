﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Domain.Entity
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        // Many to Many Relationship -> Many Characters can have many Skills
        public List<Character>? Characters { get; set; }
    }
}
