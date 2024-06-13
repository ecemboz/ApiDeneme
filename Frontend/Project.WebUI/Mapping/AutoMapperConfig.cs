using AutoMapper;
using Project.EntityLayer.Concrete;
using Project.WebUI.Dtos.AboutDto;
using Project.WebUI.Dtos.BookingDto;
using Project.WebUI.Dtos.LoginDto;
using Project.WebUI.Dtos.RegisterDto;
using Project.WebUI.Dtos.ServiceDto;
using Project.WebUI.Dtos.StaffDto;
using Project.WebUI.Dtos.SubscribeDto;
using Project.WebUI.Dtos.TestimonialDto;

namespace Project.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, AppUser>().ReverseMap();
            CreateMap<UpdateAboutDto, AppUser>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

			CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

        }
    }
}
