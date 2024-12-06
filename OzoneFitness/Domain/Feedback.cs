namespace OzoneFitness.Domain;

public class Feedback : BaseDomainBooking
{
    public int FeedbackId { get; set; }
    public int Rating { get; set; }
    public string Comments { get; set; }
    public DateTime DateOfSubmission { get; set; }

    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}