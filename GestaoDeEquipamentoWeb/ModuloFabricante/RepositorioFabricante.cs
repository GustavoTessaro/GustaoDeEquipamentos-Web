using GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Arquivos;

namespace GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante;

public class RepositorioFabricanteEmArquivo : RepositorioBase<Fabricante>, InterfaceRepositorio<Fabricante>
{
    public RepositorioFabricanteEmArquivo(Serializable contexto) : base(contexto) { }

    protected override List<Fabricante> CarregarRegistros()
    {
        return contexto.Fabricantes;
    }
}
