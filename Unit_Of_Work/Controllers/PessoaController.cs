using Liveeeeeeeee.Entities;
using Microsoft.AspNetCore.Mvc;
using Unit_Of_Work.Data.Repositories;
using Unit_Of_Work.ViewModels;

namespace Unit_Of_Work.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{
    private readonly IPessoaRepository _pessoaRepository;
    private readonly IEventoRepository _eventoRepository;
    private readonly IUnitOfWork _unitOFWork;


    public PessoaController(
        IPessoaRepository pessoaRepository,
        IEventoRepository eventoRepository,
        IUnitOfWork unitOfWork)
    {
        _pessoaRepository = pessoaRepository;
        _eventoRepository = eventoRepository;
        _unitOFWork = unitOfWork;

    }

    [HttpPost]
    public async Task<ActionResult<PessoaViewModel>> AdicionarPessoa([FromBody] PessoaRequest pessoa)
    {
        var pessoaModel = new Pessoa
        {
            EventoId = pessoa.EventoId,
            Nome = pessoa.Nome
        };

        await _pessoaRepository.AdicionarPessoa(pessoaModel);
        await _eventoRepository.IncrementarPessoa((int)pessoaModel.EventoId);

        await _unitOFWork.Commit();

        return new PessoaViewModel
        {
            Id = pessoaModel.Id,
            Nome = pessoaModel.Nome,
            EventoId = pessoaModel.EventoId
        };
    }
}