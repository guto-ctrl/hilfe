namespace Domain.Entities;

public class Endereco
{
    public int Id { get; private set; }
    public string Logradouro { get; private set; } = string.Empty;
    public string Nome { get; private set; } = string.Empty;

    // Relacionamento
    public Cliente Cliente { get; private set; } = null!; 

    // EF Core
    private Endereco() {}
}