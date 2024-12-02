namespace OzoneFitness.Domain;

public class Customer : BaseDomainBooking
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string MembershipStatus { get; set; }

    public ICollection<Feedback> Feedbacks { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}
