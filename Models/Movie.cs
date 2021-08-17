using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Cinema.Models
{
  public class Movie
  {

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameVie { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }
  }
}