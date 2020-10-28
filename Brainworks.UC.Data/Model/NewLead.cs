namespace Brainworks.UC.Data
{
    public class NewLead
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CityId { get; set; }
        public int CustPinId { get; set; }
        public Customer customer { get; set; }
        public Assign assign { get; set; }
    }
}
