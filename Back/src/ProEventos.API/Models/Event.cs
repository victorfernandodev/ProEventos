namespace ProEventos.API.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public int AmountPeople { get; set; }
        public string Lot { get; set; }
        public string ImageUrl { get; set; }
    }
}