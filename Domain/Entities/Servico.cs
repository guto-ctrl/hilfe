namespace Domain.Entities;

public class Servico
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public bool Ativo { get; private set; }

    // Relacionamento
    public IReadOnlyCollection<ServicoAtendimento> Atendimentos => _atendimentos.AsReadOnly();
    private List<ServicoAtendimento> _atendimentos = [];

    // EF Core
    private Servico() {}
}