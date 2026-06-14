using Domain.Enums;
namespace Domain.Entities;

public class OrdemDeServico
{
    public int Id { get; private set; }
    public DateTime DataAbertura { get; private set; }
    public string Descricao { get; private set; } = string.Empty;
    public StatusOs StatusOs { get; private set; } // Precisa do Enum
    public StatusFinanceiro StatusFinanceiro { get; private set; } // Precisa do Enum

    // Relacionamentos
    public Cliente Cliente { get; private set; } = null!;

    public IReadOnlyCollection<Atendimento> Atendimentos => _atendimentos.AsReadOnly();
    public IReadOnlyCollection<HistoricoStatusOs> Historico => _historico.AsReadOnly();

    private readonly List<Atendimento> _atendimentos = [];
    private readonly List<HistoricoStatusOs> _historico = [];
    
    // EF Core
    private OrdemDeServico() {}
}