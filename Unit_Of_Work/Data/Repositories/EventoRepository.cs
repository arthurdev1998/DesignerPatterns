using Liveeeeeeeee.Data.Context;

namespace Unit_Of_Work.Data.Repositories;

public class EventoRepository : IEventoRepository
{
    private readonly AppDbContext _context;

    public EventoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task IncrementarPessoa(int id)
    {
        var evento = await _context.Eventos.FindAsync(id);

        if (evento == null)
        {
            throw new Exception("Evento não encontrado");
        }

        if (evento.QtdAtual == evento.QtdMax)
        {
            throw new Exception("não é possivel adicionar uma nova pessoa no evento");
        }

        evento.QtdAtual += 1;

        _context.Eventos.Update(evento);

    }
}