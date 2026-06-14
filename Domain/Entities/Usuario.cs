namespace Domain.Entities;

public class Usuario
{
    public int Id { get; private set; }
    public string Telefone { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Nome { get; private set; } = string.Empty;
    public string SenhaHash {  get; private set; } = string.Empty;
    public bool Ativo {  get; private set; }

    // Relacionamento
    public IReadOnlyCollection<Atendimento> Atendimentos => _atendimentos.AsReadOnly();
    public IReadOnlyCollection<HistoricoStatusOs> Historicos => _historicos.AsReadOnly();
    private List<Atendimento> _atendimentos = [];
    private List<HistoricoStatusOs> _historicos = [];

    // EF Core
    private Usuario() {}
}