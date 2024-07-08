using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2022.Models;

[Table("Categorias")]
    public class Categoria
    {
    [Key]
    public int CategoriaId { get; set; }
    [StringLength(100, ErrorMessage = "O tamanho máximo de caracteres é {1}")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [Display(Name = "Nome")]
    public string CategoriaNome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo de caracteres é {1}")]
        [Required(ErrorMessage = "Informe a descriçao da categoria")]
        [Display(Name = "Descricao")]
    public string Descricao { get; set; }
    
    }

