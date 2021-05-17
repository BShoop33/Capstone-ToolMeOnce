namespace capstone_toolmeonce.Models
{
    public class ToolsModel
    {
        public int Id { get; set; }

        public int LenderId { get; set; }

        public string LenderEmail { get; set; }

        public int BorrowerId { get; set; }

        public string BorrowerEmail { get; set; }

        public string ToolPicture { get; set; }

        public int ToolAvailable { get; set; }

        public string ToolName { get; set; }

        public string ToolDescription { get; set; }

        public string ToolSpecifications { get; set; }

        public string ToolAccessories { get; set; }
    }
}
