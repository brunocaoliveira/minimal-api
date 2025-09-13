using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal_api.Dominio.Entidades;

public class Administrador
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default;

    [Required]
    [StringLength(255)]
    public string Email { get; set; } = default!;
    [StringLength(50)]
    [Required]
    public string Senha { get; set; } = default!;
    [StringLength(10)]
    [Required]
    public string Perfil { get; set; } = default;
    }
