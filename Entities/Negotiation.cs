namespace PriceNegotiationApp.Entities
{
    public class Negotiation
    {
        private const int TotalOffers = 3;

        public int Id { get; set; }
        public int ActualTry { get; set; }
        public decimal ActualPrice { get; set; }
        public bool IsFinished { get; set; } = false;
        public DateTime EndDate { get; set; }
        public Product Products { get; set; }
        public User Client { get; set; }
        public User Employee { get; set; }
        public Offer Offer { get; set; }
    }
}
