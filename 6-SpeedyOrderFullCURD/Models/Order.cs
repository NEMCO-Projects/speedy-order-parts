namespace SpeedyOrderPages.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public string OrderItem { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
