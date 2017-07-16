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
    public static class EventExtension
    {
        public static EventDto TransformtoDto(this EventMdl eventMdl)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EventMdl, EventDto>();
            });

            IMapper mapper = config.CreateMapper();
            return mapper.Map<EventMdl, EventDto>(eventMdl);
        }

        public static IEnumerable<EventDto> TransformtoDto(this IEnumerable<EventMdl> eventMdls)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EventMdl, EventDto>();
            });
            IMapper mapper = config.CreateMapper();
            foreach (var eventMdl in eventMdls)
            {
                yield return mapper.Map<EventMdl, EventDto>(eventMdl);
            }
        }
    }
}
