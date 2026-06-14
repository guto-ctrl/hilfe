namespace Domain.Entities;

public class Atendimento
{
    public int Id { get; private set; }
    public DateTime Data { get; private set; }
    public TimeSpan Duracao { get; private set; }
    public string Observacoes { get; private set; } = string.Empty;

    // Relacionamentos
    public OrdemDeServico OrdemDeServico { get; private set; } = null!;
    public Usuario Tecnico { get; private set; } = null!;

    public IReadOnlyCollection<ServicoAtendimento> Servicos => _servicos.AsReadOnly();
    private readonly List<ServicoAtendimento> _servicos = [];

    // EF Core
    private Atendimento() {}
}