using System.ComponentModel.DataAnnotations;

namespace Liveeeeeeeee.Entities;

public class Evento
{
    [Key]
    public long Id { get; set; }


    [StringLength(100)]
    public string? Nome { get; set; }


    public int QtdMax { get; set; }
    
    public int QtdAtual { get; set; }

    // Ef Relations
    public IEnumerable<Pessoa>? Pessoas { get; set; }
}