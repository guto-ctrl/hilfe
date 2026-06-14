namespace Domain.Entities;

public class Telefone
{
    public int Id { get; private set; }
    public string Numero { get; private set; } = string.Empty;
    public string Nome { get; private set; } = string.Empty;

    // Relacionamento
    public Cliente Cliente { get; private set; } = null!;

    private Telefone() {}
    // EF Core 
}