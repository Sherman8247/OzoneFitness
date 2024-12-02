namespace OzoneFitness.Domain;

public class Schedule : BaseDomainBooking
{
    public int ScheduleID { get; set; }
    public string DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    public int TrainerID { get; set; }
    public Trainer Trainer { get; set; }
    public ICollection<Booking> Bookings { get; set; }
}
