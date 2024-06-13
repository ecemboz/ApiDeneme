using AutoMapper;
using Project.DtoLayer.Dtos.RoomDto;
using Project.EntityLayer.Concrete;

//dto katmanı ile entity katmanındaki propertyleri eşleştiriyor
namespace Project.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
