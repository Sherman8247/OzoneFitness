namespace OzoneFitness.Domain;

public class Trainer : BaseDomainBooking
{
    public int TrainerId { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public int YearsOfExperience { get; set; }

    public int GymId { get; set; }
    public byte[]? Image { get; set; }

}