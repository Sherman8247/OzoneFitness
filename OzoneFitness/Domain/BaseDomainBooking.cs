namespace OzoneFitness.Domain
{
    public abstract class BaseDomainBooking
    {
        public int ID { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated  { get; set; }
        public string? CreatedBy  { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
