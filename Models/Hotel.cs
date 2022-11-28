using System.ComponentModel.DataAnnotations;

namespace Lab_10.Models;

public class Hotel
{
    public int id { get; set; }
    [Required(ErrorMessage = "Please enter a name")]
    public String? name { get; set; }
    [Required(ErrorMessage = "Please enter rooms")]
    public int rooms { get; set; }
    public String? description { get; set; }
    [Required(ErrorMessage = "Please enter a location")]
    public String? location { get; set; }
    [Required(ErrorMessage = "Please enter a phone")]
    public String? phone { get; set; }
    [Required(ErrorMessage = "Please enter a rating")]
    public int rating { get; set; }
    [Required(ErrorMessage = "Please enter an imgURL")]
    public String? imgURL { get; set; }

}