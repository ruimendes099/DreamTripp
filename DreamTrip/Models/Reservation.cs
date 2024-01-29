 namespace DreamTrip.Models
{
    public class Reservation
    {
        public string? VanId { get; set; }

        public string? RentalUserId { get; set; }

        public DateTime PickUpDay { get; set; }

        public DateTime DeliverDate { get; set; }

    }

}