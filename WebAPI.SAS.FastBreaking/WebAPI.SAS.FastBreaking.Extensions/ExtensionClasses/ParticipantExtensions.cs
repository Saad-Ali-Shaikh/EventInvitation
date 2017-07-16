using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.SAS.Dto.DTOObject;
using WebAPI.SAS.FastBreaking.Models.Models;

namespace WebAPI.SAS.FastBreaking.Extensions.ExtensionClasses
{
    public static class ParticipantExtensions
    {
        public static ParticipantDto TransformtoDto(this ParticipantMdl participantMdl)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ParticipantMdl, ParticipantDto>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<ParticipantMdl, ParticipantDto>(participantMdl);
        }

        public static IEnumerable<ParticipantDto> TransformtoDto(this IEnumerable<ParticipantMdl> participantMdls)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ParticipantMdl, ParticipantDto>();
            });
            IMapper mapper = config.CreateMapper();
            foreach (var participantMdl in participantMdls)
            {
                yield return mapper.Map<ParticipantMdl, ParticipantDto>(participantMdl);
            }
        }
    }
}
