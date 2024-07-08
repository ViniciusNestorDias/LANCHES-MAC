using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2022.Models;

[Table("Lanches")]
public class Lanche
{

    [Key]
    public int LancheId { get; set; }
    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Nome do lanche")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "Deve conter o {0} de caracteres. Deve ter no maximo{1}caracteres")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Descriçao do lanche")]
    [MinLength(20, ErrorMessage = "Descriçao deve ter no mínimo{1}caracteres")]
    [MaxLength(200, ErrorMessage = "Descriçao deve ter no máximo{1}caracteres")]
    public string DescricaoCurta { get; set; }
    [Required(ErrorMessage = "O nome do lanche deve ser informado")]
    [Display(Name = "Descriçao do lanche")]
    [MinLength(20, ErrorMessage = "Descriçao deve ter no mínimo{1}caracteres")]
    [MaxLength(200, ErrorMessage = "Descriçao deve ter no máximo{1}caracteres")]
    public string DescricaoDetalhada { get; set; }
    [Required(ErrorMessage = "Informe o valor do lanche")]
    [Display(Name = "Preco")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1, 999.99, ErrorMessage = "O preço deve ser maior que 1 real e menor que 999,99 reais")]
    public decimal Preco { get; set; }
    [Display(Name = "Caminho da imagem")]
    [StringLength(200, ErrorMessage = "Deve se ter no máximo {1} caracteres")]
    public string ImagemUrl { get; set; }
    [Display(Name = "Caminho da imagem em miniatura")]
    [StringLength(200, ErrorMessage = "Deve se ter no máximo {1} caracteres")]
    public string ImagemThumbnailUrl { get; set; }
    [Display(Name = "Preferido")]
    public bool IsLanchePreferido { get; set; }
    [Display(Name = "Estoque")]
    public bool EmEstoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }


}

