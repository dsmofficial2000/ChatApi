using AutoMapper;
using ChatApi.Model.Domain;
using ChatApi.Model.DTO;
using ChatApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChatApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IMapper mapper;
        public IchatmessageReoisitory chatrepository { get; set; }

        public ChatController(IMapper mapper, IchatmessageReoisitory chatmessage)
        {
            this.mapper = mapper;
            this.chatrepository = chatmessage;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddChatRequestDto addChatRequestDto)
        {
            // Map DTO to Domain Model
            var chatDomainModel = mapper.Map<ChatMessage>(addChatRequestDto);

            await chatrepository.CreateAsync(chatDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<ChatDto>(chatDomainModel));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ChatDomain = await chatrepository.GetallAsync();
            return Ok(mapper.Map<List<ChatDto>>(ChatDomain));
        }

    }
}
