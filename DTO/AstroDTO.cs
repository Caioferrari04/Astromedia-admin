using System.ComponentModel.DataAnnotations;

namespace Astromedia_admin.DTO;

public class AstroDTO 
{
    [Required]
    public string Curiosidades { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 5)]
    public string Nome { get; set; }

    [Url]
    public string Foto { get; set; }
}