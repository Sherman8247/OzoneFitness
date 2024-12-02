﻿namespace OzoneFitness.Domain;

public class Trainer : BaseDomainBooking
{
    public int TrainerID { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
    public int YearsOfExperience { get; set; }

    public int GymID { get; set; }
    public Gym Gym { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Feedback> Feedbacks { get; set; }
}