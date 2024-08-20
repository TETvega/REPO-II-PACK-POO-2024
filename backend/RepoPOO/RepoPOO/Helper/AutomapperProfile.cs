using AutoMapper;

namespace RepoPOO.Helper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            //MapsForProducts();
            //MapsForEvents();
        }

        private void MapsForEvents()
        {
            //CreateMap<EventCreateDto, EventEntity>()
            //    .ForMember(dest => dest.EventDetails, opt => opt.Ignore());// esta ignorando por que cuando lo crea se guarda solamente los detalles primeros y despues se le anexa

            //CreateMap<EventEditDto, EventEntity>()
            //    .ForMember(dest => dest.EventDetails, opt => opt.Ignore());

            //CreateMap<EventEntity, EventDto>()
            //    .ForMember(dest => dest.EventDetails, opt => opt.MapFrom(src => src.EventDetails));


            //// para poder ver los detalles no se si los podia poner aqui pero los meti
            //CreateMap<DetailEntity, DetailDto>()
            //    .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
            //    .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.TotalPrice));
            ////.ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

        }

       
    }
}
