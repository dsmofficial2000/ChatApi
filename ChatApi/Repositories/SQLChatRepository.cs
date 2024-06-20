using ChatApi.Data;
using ChatApi.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace ChatApi.Repositories
{
    public class SQLChatRepository : IchatmessageReoisitory
    {
        private readonly ApplicationDbContext dbcontext;

        public SQLChatRepository(ApplicationDbContext dbContext)
        {
            this.dbcontext = dbContext;
        }
        public async Task<ChatMessage> CreateAsync(ChatMessage chatMessage)
        {
            await dbcontext.AddAsync(chatMessage);
            await dbcontext.SaveChangesAsync();
            return chatMessage;
        }

        public async Task<List<ChatMessage>> GetallAsync()
        {
            return await dbcontext.chatMessages.ToListAsync();
        }
    }
}
