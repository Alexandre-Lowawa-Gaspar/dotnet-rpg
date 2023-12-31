using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Skill;

namespace dotnet_rpg.Dtos.Character
{
    public class GetCharacterDto
    {
       public int Id { get; set; }
        public string Name { get; set; } = "Alex";
        public int HitPoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto? Weapon { get; set; }
        public List<GetSkillDto>? Skills { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; } 
    }
}