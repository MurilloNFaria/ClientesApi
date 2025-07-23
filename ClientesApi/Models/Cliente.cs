using System.ComponentModel.DataAnnotations;

namespace ClientesApi.Models;

public class Cliente
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome obrigatório")]
    [MaxLength(50, ErrorMessage = "O nome não deve exceder 50 caracteres")]
    public string Nome { get; set; }

    [MaxLength(50, ErrorMessage = "O nome social não deve exceder 50 caracteres")]
    public string NomeSocial { get; set; }

    [Required(ErrorMessage = "A data de nascimento é obrigatória")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF inválido")]
    [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números")]
    public string CPF { get; set; }

    [Required(ErrorMessage = "O endereço é obrigatório")]
    [MaxLength(200, ErrorMessage = "O endereço não deve exceder 200 caracteres")]
    public string Endereco { get; set; }

}
