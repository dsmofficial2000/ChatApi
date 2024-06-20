namespace ChatApi.Model.DTO
{
    public class UpdateChatRequestDto
    {
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
