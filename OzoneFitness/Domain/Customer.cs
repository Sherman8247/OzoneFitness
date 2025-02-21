﻿namespace OzoneFitness.Domain;

public class Customer : BaseDomainBooking
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string MembershipStatus { get; set; }
    public byte[]? Image { get; set; }

}