namespace Domain.Entities;

public class ServicoAtendimento
{
    // Relacionamento
    public Servico Servico { get; private set; } = null!;
    public Atendimento Atendimento { get; private set; } = null!;

    private ServicoAtendimento() {}

    public ServicoAtendimento(Servico servico, Atendimento atendimento)
    {
        Servico = servico;
        Atendimento = atendimento;
    }
}