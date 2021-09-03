using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProvaCandidato.Data.Entidade
{
  [Table("Cidade")]
  public class Cidade
  {
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }

    [Column("nome")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "O campo nome deve ter de 3 a 50 dígitos")]
    [Required]
    public string Nome { get; set; }
  }
}
