using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Arquivos;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento;

public class RepositorioEquipamentoEmArquivo : RepositorioBase<Equipamento>, InterfaceRepositorio<Equipamento>
{
    public RepositorioEquipamentoEmArquivo(Serializable contexto) : base(contexto) { }

    protected override List<Equipamento> CarregarRegistros()
    {
        return contexto.Equipamentos;
    }
}
