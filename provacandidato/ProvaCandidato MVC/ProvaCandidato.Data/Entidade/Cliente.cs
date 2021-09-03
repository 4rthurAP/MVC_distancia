using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaCandidato.Data.Entidade
{
  [Table("Cliente")]
  public class Cliente
  {
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }

    [StringLength(10, MinimumLength = 3, ErrorMessage = "O campo nome deve ter de 3 a 50 dígitos")]
    [Required]
    [Column("nome")]
    public string Nome { get; set; }

    [Column("data_nascimento")]
    public DateTime? DataNascimento { get; set; }

    [Column("codigo_cidade")]
    [Display(Name = "Cidade")]
    public int CidadeId { get; set; }

    public bool Ativo { get; set; }

    [ForeignKey("CidadeId")]
    public virtual Cidade Cidade { get; set; }

  }
}