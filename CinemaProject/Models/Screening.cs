public class Screening
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public decimal TicketPrice { get; set; }

    public int MovieId { get; set; }
    public Movie Movie { get; set; }
}
