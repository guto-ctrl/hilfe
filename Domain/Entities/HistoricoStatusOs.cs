using Domain.Enums;

namespace Domain.Entities;

public class HistoricoStatusOs {
    public int Id { get; private set; }
    public DateTime DataAlteracao { get; private set; }
    public StatusOs StatusAnterior { get; private set; }
    public StatusOs StatusAtual { get; private set; }

    // Relacionamentos
    public Usuario Tecnico { get; private set; } = null!;
    public OrdemDeServico OrdemDeServico { get; private set; } = null!;

    // EF Core
    private HistoricoStatusOs() {}
}