using System.ComponentModel.DataAnnotations;

namespace ApiProduto.Models;

public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "Digite o Nome do Produto")]
    [StringLength(100, ErrorMessage = "Nome não pode ter mais que 100 caracteres")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Digite o Preço")]
    [Range(1, 999.99)]
    public double Preco { get; set; }

    [Required(ErrorMessage = "Digite a Descrição do Produto")]
    [StringLength(200, ErrorMessage = "A descrição é de no maximo 200 caracteres")]
    public string? Descricao { get; set; }
    public DateTime DataCadastro { get; set; }
}
