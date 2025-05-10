public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string PosterUrl { get; set; }
    public int ReleaseYear { get; set; }
    public double Rating { get; set; }
    public string TrailerUrl { get; set; }

    public ICollection<MovieGenre> MovieGenres { get; set; }
    public ICollection<MovieActor> MovieActors { get; set; }
    public ICollection<Screening> Screenings { get; set; }
}
