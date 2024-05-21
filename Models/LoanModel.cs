namespace BookShareMVC.Models
{
    public class LoanModel
    {
        public int Id { get; set; }
        public string Recipient { get; set; } = string.Empty;
        public string Supplier { get; set; } = string.Empty;
        public string BookLoan { get; set; } = string.Empty;
        public DateTime LastDateUpdate { get; set; } = DateTime.Now;
    }
}
