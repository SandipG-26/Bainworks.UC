 using AutoMapper;
using Brainworks.UC.Data;
using Brainworks.UC.ViewModel;

namespace Brainworks.UC.Services
{
    public class UCProfile : Profile
    {
        public UCProfile()
        {
            CreateMap<Service, ServiceViewModel>();
            Mapper.CreateMap<ServiceViewModel, Service>();
        }

    }
}
