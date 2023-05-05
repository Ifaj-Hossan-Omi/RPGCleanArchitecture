using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Domain.Enum;

namespace RPG.Domain.Entity
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        //One To Many Relationship -> One User can have many Characters
        public User? User { get; set; }
        //One to One Relationship -> One Character (Primary Key) can have one Weapon
        public Weapon? Weapon { get; set; }
        //Many to Many Relationship -> Many Characters can have many Skills
        public List<Skill>? Skills { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
