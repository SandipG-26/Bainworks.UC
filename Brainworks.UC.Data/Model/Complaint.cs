namespace Brainworks.UC.Data
{
    public class Complaint
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public int StatusId { get; set; }
        public Customer customer { get; set; }
        public Assign assign { get; set; }
    }
}
