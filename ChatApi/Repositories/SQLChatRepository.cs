using ChatApi.Data;
using ChatApi.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace ChatApi.Repositories
{
    public class SQLChatRepository : IchatmessageReoisitory
    {
        private readonly ApplicationDbContext _dbcontext;

        public SQLChatRepository(ApplicationDbContext dbContext)
        {
            this._dbcontext = dbContext;
        }
        public async Task<ChatMessage> CreateAsync(ChatMessage chatMessage)
        {
            await _dbcontext.AddAsync(chatMessage);
            await _dbcontext.SaveChangesAsync();
            return chatMessage;
        }
    }
}
