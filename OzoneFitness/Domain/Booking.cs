namespace OzoneFitness.Domain;

public class Booking: BaseDomainBooking
{
    public int BookingID { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; } // If Time is a string, ensure validation
    public int Duration { get; set; }
    public int CustomerID { get; set; }
    public int ScheduleID { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}
