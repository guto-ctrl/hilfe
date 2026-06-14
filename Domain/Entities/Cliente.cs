using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Cliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    // public TipoCliente Tipo { get; private set; } // precisa do enum
    public string Documento { get; private set; } = string.Empty;

    // Relacionamentos
    public IReadOnlyCollection<Telefone> Telefones => _telefones.AsReadOnly();
    public IReadOnlyCollection<Email> Emails => _emails.AsReadOnly();
    public IReadOnlyCollection<Endereco> Enderecos => _enderecos.AsReadOnly();
    public IReadOnlyCollection<OrdemDeServico> OrdensDeServicos => _ordensDeServico.AsReadOnly();
    public IReadOnlyCollection<Contrato> Contratos => _contratos.AsReadOnly();

    public readonly List<Telefone> _telefones = [];
    public readonly List<Email> _emails = [];
    public readonly List<Endereco> _enderecos = [];
    public readonly List<OrdemDeServico> _ordensDeServico = [];
    public readonly List<Contrato> _contratos = [];

    private Cliente() {}
    // Ef Core 
}