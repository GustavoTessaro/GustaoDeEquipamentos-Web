using GestaoDeEquipamentoWeb.Compartilhado.Arquivos;
using GestaoDeEquipamentoWeb.ModuloEquipamento;

public class RepositorioEquipamentoEmArquivo : RepositorioBase<Equipamento>, InterfaceRepositorio<Equipamento>
{
    public RepositorioEquipamentoEmArquivo(Serializable contexto) : base(contexto) { }

    protected override List<Equipamento> CarregarRegistros()
    {
        return contexto.Equipamentos;
    }
}

