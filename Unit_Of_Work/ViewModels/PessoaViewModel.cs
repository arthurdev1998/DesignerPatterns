using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Unit_Of_Work.ViewModels
{
    public class PessoaViewModel
    {

        public long Id { get; set; }

        [MaxLength(100)]
        public string? Nome { get; set; }

        [Range(1, long.MaxValue)]
        public long EventoId { get; set; }
    }
}