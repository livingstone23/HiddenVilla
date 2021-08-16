using AutoMapper;
using DataAccess.Data;
using Models;
using Models.DTO;

namespace Business.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelRoomDTO, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDTO>();

            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();
            
            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();

            CreateMap<RoomOrderDetails, RoomOrderDetailsDTO>().ForMember(x => x.HotelRoomDTO, opt => opt.MapFrom(c => c.HotelRoom));
            CreateMap<RoomOrderDetailsDTO, RoomOrderDetails>();
        }
    }
}
