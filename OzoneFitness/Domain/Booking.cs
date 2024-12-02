namespace OzoneFitness.Domain;

public class Booking: BaseDomainBooking
{
    public int BookingID { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }
    public int Duration { get; set; }

    public int CustomerID { get; set; }
    public Customer Customer { get; set; }

    public int ScheduleID { get; set; }
    public Schedule Schedule { get; set; }
}
