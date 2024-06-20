using AutoMapper;
using ChatApi.Model.Domain;
using ChatApi.Model.DTO;

namespace ChatApi.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //chat Controller
            CreateMap<AddChatRequestDto, ChatMessage>().ReverseMap();
            
            CreateMap<ChatMessage, ChatDto>().ReverseMap();
            CreateMap<UpdateChatRequestDto, ChatMessage>().ReverseMap();
        }
    }
}
