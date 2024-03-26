namespace movies.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? isSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}
