using System.ComponentModel.DataAnnotations;

public class User
{

    public long Id { get; set; }
    [Required]


    //Add required if working
    [MaxLength(50)]
    public string Username { get; set; }
    
    //Add required if working
    [MaxLength(50)]
    public string Password { get; set; }
}