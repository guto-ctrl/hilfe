namespace Domain.Entities;

public class Servico
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public bool Ativo { get; private set; }

    // Relacionamento
    public ServicoAtendimento ServicoAtendimento { get; private set; } = null!;

    private Servico() {}
    // EF Core
}