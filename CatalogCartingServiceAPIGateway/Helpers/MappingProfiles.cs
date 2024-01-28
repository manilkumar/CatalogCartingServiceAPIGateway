namespace CatalogCartingServiceAPIGateway.Helpers
{
    using AutoMapper;
    using CatalogCartingServiceAPIGateway.Models.DbModels;
    using CatalogCartingServiceAPIGateway.Models.InputModels;

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<LoginInputModel, User>().ReverseMap();
            CreateMap<RegisterInputModel, User>().ReverseMap();
            CreateMap<EventInputModel, Event>().ReverseMap();
            CreateMap<UserEventInputModel, UserEvent>().ReverseMap();
        }
    }
}
