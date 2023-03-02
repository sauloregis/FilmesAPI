using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]

    public string Genero { get; set; }
    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    [Range(30, 600, ErrorMessage = "A duração precisa ter entre 30 e 600 minutos.")]

    public int Duracao { get; set; }
}
