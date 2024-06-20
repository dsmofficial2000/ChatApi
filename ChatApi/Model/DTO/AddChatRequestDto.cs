namespace ChatApi.Model.DTO
{
    public class AddChatRequestDto
    {
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
