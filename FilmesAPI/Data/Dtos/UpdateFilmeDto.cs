using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "Titulo do Filme é Obrigatorio")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O genero do filme é Obrigatorio")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração necessita ser entre 70 a 600 min")]
    public int Duracao { get; set; }
}
