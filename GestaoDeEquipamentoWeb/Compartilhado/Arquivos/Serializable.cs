using System.Text.Json;
using System.Text.Json.Serialization;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloEquipamento;
using GestaoDeEquipamentosWeb.ConsoleApp.ModuloFabricante;

namespace GestaoDeEquipamentosWeb.ConsoleApp.Compartilhado.Arquivos;

public sealed class Serializable
{
    public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    public List<Fabricante> Fabricantes { get; set; } = new List<Fabricante>();
    public List<Chamado> Chamados { get; set; } = new List<Chamado>();

    private readonly string caminhoArquivo;

    public Serializable()
    {
        string caminhoAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        string caminhoDiretorio = Path.Combine(caminhoAppData, "GestaoDeEquipamentosWeb");

        Directory.CreateDirectory(caminhoDiretorio);

        caminhoArquivo = Path.Combine(caminhoDiretorio, "dados.json");
    }

    public void Salvar()
    {
        JsonSerializerOptions opcoesJson = new JsonSerializerOptions();
        opcoesJson.WriteIndented = true;
        opcoesJson.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        opcoesJson.ReferenceHandler = ReferenceHandler.Preserve;

        string jsonString = JsonSerializer.Serialize(this, opcoesJson);

        File.WriteAllText(caminhoArquivo, jsonString);
    }

    public void Carregar()
    {
        if (!File.Exists(caminhoArquivo))
            return;

        string jsonString = File.ReadAllText(caminhoArquivo);

        JsonSerializerOptions opcoesJson = new JsonSerializerOptions();
        opcoesJson.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        opcoesJson.ReferenceHandler = ReferenceHandler.Preserve;

        Serializable? contextoSalvo = JsonSerializer.Deserialize<Serializable>(jsonString, opcoesJson);

        if (contextoSalvo == null)
            return;

        this.Equipamentos = contextoSalvo.Equipamentos;
        this.Fabricantes = contextoSalvo.Fabricantes;
        this.Chamados = contextoSalvo.Chamados;
    }
}
