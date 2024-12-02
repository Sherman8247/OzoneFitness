namespace OzoneFitness.Domain;

public class Feedback : BaseDomainBooking
{
    public int FeedbackID { get; set; }
    public int Rating { get; set; }
    public string Comments { get; set; }
    public DateTime DateOfSubmission { get; set; }

    public int TrainerID { get; set; }
    public Trainer Trainer { get; set; }

    public int CustomerID { get; set; }
    public Customer Customer { get; set; }
}
