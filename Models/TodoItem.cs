using System.ComponentModel.DataAnnotations;

public class TodoItem
{

    public long Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public bool IsComplete { get; set; }
}