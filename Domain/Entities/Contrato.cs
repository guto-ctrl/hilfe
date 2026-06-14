using Domain.Enums;
namespace Domain.Entities;

public class Contrato
{
    public int Id { get; private set; }
    public DateTime DataInicio { get; private set; }
    public DateTime DataFim { get; private set; }
    public StatusContrato Status { get; private set; }
    public string SourceDocumento { get; private set; } = string.Empty;
    public string Observacoes { get; private set;  } = string.Empty;

    // Relacionamento
    public Cliente Cliente { get; private set; } = null!;

    // EF Core
    private Contrato() {}
}