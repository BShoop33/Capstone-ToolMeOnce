namespace capstone_toolmeonce.Models
{
    public class MessagesModel
    {
        public int Id { get; set; }

        public int LenderId { get; set; }

        public int ReplyToId { get; set; }

        public string Message { get; set; }
    }
}
