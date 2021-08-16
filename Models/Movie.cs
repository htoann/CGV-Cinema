using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
  public class Movie
  {

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
  }
}