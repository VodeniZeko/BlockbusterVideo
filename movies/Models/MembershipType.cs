namespace movies.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationinMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}
