using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.Dtos.Skill;
using Weapon=dotnet_rpg.Models.Weapon;
namespace dotnet_rpg
{
    public class AutoMapperProfile:Profile
    {
     public AutoMapperProfile()
     {
        CreateMap<Character,GetCharacterDto>();
        CreateMap<AddCharacterDto,Character>();
        CreateMap<UpdateCharacterDto,Character>();
        CreateMap<Weapon,GetWeaponDto>();
        CreateMap<Skill,GetSkillDto>();

     }   
    }
}