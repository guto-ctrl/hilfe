using Domain.Enums;

namespace Domain.Entities;

public class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public TipoCliente Tipo { get; private set; }
    public string Documento { get; private set; } = string.Empty;

    // Relacionamentos
    public IReadOnlyCollection<Telefone> Telefones => _telefones.AsReadOnly();
    public IReadOnlyCollection<Email> Emails => _emails.AsReadOnly();
    public IReadOnlyCollection<Endereco> Enderecos => _enderecos.AsReadOnly();
    public IReadOnlyCollection<OrdemDeServico> OrdensDeServicos => _ordensDeServico.AsReadOnly();
    public IReadOnlyCollection<Contrato> Contratos => _contratos.AsReadOnly();

    private readonly List<Telefone> _telefones = [];
    private readonly List<Email> _emails = [];
    private readonly List<Endereco> _enderecos = [];
    private readonly List<OrdemDeServico> _ordensDeServico = [];
    private readonly List<Contrato> _contratos = [];

    // Ef Core 
    private Cliente() {}
}