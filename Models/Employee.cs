using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    [Required(ErrorMessage = "ID is required.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    [RegularExpression(@"^(Male|Female)$", ErrorMessage = "Gender must be either 'Male' or 'Female'.")]
    public string? Gender { get; set; }

    [Required(ErrorMessage = "Position is required.")]
    [StringLength(50, ErrorMessage = "Position cannot exceed 50 characters.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Position can only contain letters and spaces.")]
    public string? Position { get; set; }
}
