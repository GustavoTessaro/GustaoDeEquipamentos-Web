using GestaoDeEquipamentoWeb.Compartilhado.Arquivos;

namespace GestaoDeEquipamentoWeb.ModuloFabricante;

public class RepositorioFabricanteEmArquivo : RepositorioBase<Fabricante>, InterfaceRepositorio<Fabricante>
{
    public RepositorioFabricanteEmArquivo(Serializable contexto) : base(contexto) { }

    protected override List<Fabricante> CarregarRegistros()
    {
        return contexto.Fabricantes;
    }
}

