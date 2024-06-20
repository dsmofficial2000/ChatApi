using ChatApi.Model.Domain;

namespace ChatApi.Repositories
{
    public interface IchatmessageReoisitory
    {
        Task<ChatMessage> CreateAsync(ChatMessage chatMessage);
        Task<List<ChatMessage>> GetallAsync();
        //Task<ChatMessage?> GetByIdAsync(Guid id);
        //Task<ChatMessage?> UpdateAsync(Guid id, ChatMessage walk);
        //Task<ChatMessage?> DeleteAsync(Guid id);
    }
}
