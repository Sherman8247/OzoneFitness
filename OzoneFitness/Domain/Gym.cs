namespace OzoneFitness.Domain;

public class Gym : BaseDomainBooking
{
    public int GymId { get; set; }
    public string Address { get; set; }
    public string OperatingHours { get; set; }
    public int Capacity { get; set; }

    //public ICollection<Trainer> Trainers { get; set; }
    //public ICollection<Customer> Customers { get; set; }
}