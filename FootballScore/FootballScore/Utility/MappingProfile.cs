using AutoMapper;
using FootballScore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FootballScore.Commands.Create;
using static FootballScore.Commands.Edit;

namespace FootballScore.Utility
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddGameRequest, Game>()
                .ForMember(dest => dest.CurrentTime, opt => opt.MapFrom(src => src.Time));

            CreateMap<UpdateGameRequest, Game>()
                .ForMember(dest => dest.CurrentTime, opt => opt.MapFrom(src => src.Time));
        }
    }
}
