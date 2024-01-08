namespace IME.StockMarket.API.Models
{
    public class Asset
    {
        public string Category { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public float DotValue { get; set; }
        public float StandardLot { get; set; }
        public string Memo { get; set; }
    }
}
