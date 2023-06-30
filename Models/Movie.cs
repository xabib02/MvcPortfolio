using System.ComponentModel.DataAnnotations;
public class Movie
{
    public int Id { get; set;}

    [Required]
    [DataType(DataType.Text)]
    public string Name { get; set;}
    public int Year { get; set;}
    public string Country { get; set;}

}