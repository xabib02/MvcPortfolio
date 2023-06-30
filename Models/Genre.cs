using System.ComponentModel.DataAnnotations;
public class Genre
{
    public int Id { get; set;}

    [Required]
    [DataType(DataType.Text)]
    public string Name { get; set;}

}