namespace OzoneFitness.Domain;

public class Schedule : BaseDomainBooking
{
    public int ScheduleID { get; set; }
    public string DayOfWeek { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public int TrainerID { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}
