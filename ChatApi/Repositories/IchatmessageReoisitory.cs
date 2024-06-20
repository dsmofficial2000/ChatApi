using ChatApi.Model.Domain;

namespace ChatApi.Repositories
{
    public interface IchatmessageReoisitory
    {
        Task<ChatMessage> CreateAsync(ChatMessage chatMessage);
    }
}
