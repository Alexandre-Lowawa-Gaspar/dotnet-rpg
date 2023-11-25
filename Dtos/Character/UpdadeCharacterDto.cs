using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Character
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int HitPoint { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; } 
    }
}