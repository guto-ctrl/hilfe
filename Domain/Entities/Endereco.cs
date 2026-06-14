namespace Domain.Entities;

public class Endereco
{
    public int Id { get; private set; }
    public string ENdereco { get; private set; } = string.Empty;
    public string Nome { get; private set; } = string.Empty;

    // Relacionamento
    public Cliente Cliente { get; private set; } = null!; 

    private Endereco() {}
    // EF Core
}