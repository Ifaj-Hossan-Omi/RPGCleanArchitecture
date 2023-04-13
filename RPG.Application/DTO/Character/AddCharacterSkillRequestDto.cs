using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Application.DTO.Character
{
    public class AddCharacterSkillRequestDto
    {
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
    }
}
