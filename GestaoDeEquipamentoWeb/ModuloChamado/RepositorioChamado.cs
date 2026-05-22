using GestaoDeEquipamentoWeb.Compartilhado.Arquivos;

public class RepositorioChamadoEmArquivo : RepositorioBase<Chamado>, InterfaceRepositorio<Chamado>
{
    public RepositorioChamadoEmArquivo(Serializable contexto) : base(contexto) { }

    protected override List<Chamado> CarregarRegistros()
    {
        return contexto.Chamados;
    }
}

