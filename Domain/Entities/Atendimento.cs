namespace Domain.Entities;

public class Atendimento
{
    public int Id { get; private set; }
    public DateTime Data { get; private set; } = DateTime.Now;
    public int Duracao { get; private set; }
    public string Observacoes { get; private set; } = string.Empty;

    // Relacionamentos
    public IReadOnlyCollection<OrdemDeServico> OrdensDeServicos => _ordensDeServico.AsReadOnly();
    public IReadOnlyCollection<Tecnico> Tecnicos => _tecnicos.AsReadOnly(); 

    public List<OrdemDeServico> _ordensDeServico = [];
    public List<Tecnico> _tecnicos = []; 

    private Atendimento() {}

    // EF Core
}