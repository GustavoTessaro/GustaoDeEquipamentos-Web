# 🖥️ Gestão de Equipamentos Web

Sistema web desenvolvido em **ASP.NET Core MVC** para gerenciamento de fabricantes, equipamentos e chamados técnicos.

O projeto permite realizar operações de cadastro, edição, exclusão e listagem de registros, utilizando persistência de dados em arquivos JSON.

---

# 🚀 Tecnologias Utilizadas

- 💻 C#
- 🌐 ASP.NET Core MVC
- 🧩 Razor Views
- 🎨 HTML5
- 🎨 CSS3
- 📦 JSON
- ⚙️ .NET

---

# 🎯 Objetivo do Projeto

O objetivo do sistema é permitir o controle de:

- 🏭 Fabricantes
- 🖥️ Equipamentos
- 📞 Chamados Técnicos

A aplicação foi desenvolvida utilizando o padrão MVC (Model-View-Controller), separando responsabilidades entre:

- Controllers
- Models
- Views
- Repositórios
- Persistência de dados

---

# ✅ Funcionalidades

## 🏭 Fabricantes

- Cadastro de fabricantes
- Edição de fabricantes
- Exclusão de fabricantes
- Listagem de fabricantes

## 🖥️ Equipamentos

- Cadastro de equipamentos
- Associação de equipamentos com fabricantes
- Edição de equipamentos
- Exclusão de equipamentos
- Listagem de equipamentos

## 📞 Chamados

- Cadastro de chamados técnicos
- Associação de chamados com equipamentos
- Controle de tempo decorrido do chamado
- Edição de chamados
- Exclusão de chamados
- Listagem de chamados

---

# 🏗️ Arquitetura do Projeto

O sistema foi organizado utilizando o padrão MVC.

## 📂 Estrutura de Pastas

```text
GestaoDeEquipamentoWeb
│
├── Compartilhado
│   ├── Arquivos
│   │   ├── RepositorioBase.cs
│   │   └── Serializable.cs
│   │
│   ├── EntidadeBase.cs
│   └── InterfaceRepositorio.cs
│
├── Controllers
│   ├── HomeController.cs
│   ├── FabricanteController.cs
│   ├── EquipamentoController.cs
│   └── ChamadoController.cs
│
├── Models
│   ├── FabricanteViewModels.cs
│   ├── EquipamentoViewModels.cs
│   └── ChamadoViewModels.cs
│
├── ModuloFabricante
│   ├── Fabricante.cs
│   └── RepositorioFabricante.cs
│
├── ModuloEquipamento
│   ├── Equipamento.cs
│   └── RepositorioEquipamento.cs
│
├── ModuloChamado
│   ├── Chamado.cs
│   └── RepositorioChamado.cs
│
├── Views
│   ├── Chamado
│   │   ├── Cadastrar.cshtml
│   │   ├── Editar.cshtml
│   │   ├── Excluir.cshtml
│   │   └── Listar.cshtml
│   │
│   ├── Equipamento
│   │   ├── Cadastrar.cshtml
│   │   ├── Editar.cshtml
│   │   ├── Excluir.cshtml
│   │   └── Listar.cshtml
│   │
│   ├── Fabricante
│   │   ├── Cadastrar.cshtml
│   │   ├── Editar.cshtml
│   │   ├── Excluir.cshtml
│   │   └── Listar.cshtml
│   │
│   ├── Home
│   │   └── Index.cshtml
│   │
│   ├── Shared
│   │   └── _Layout.cshtml
│   │
│   └── _ViewImports.cshtml
│
├── wwwroot
│   └── css
│       └── styles.css
│
└── Program.cs
```

---

# 🧱 Padrão Repository

O projeto utiliza um repositório genérico para centralizar operações CRUD.

## 📌 InterfaceRepositorio

Define operações básicas:

- Cadastrar
- Editar
- Excluir
- SelecionarPorId
- SelecionarTodos

## 📌 RepositorioBase

Classe abstrata responsável pela implementação genérica das operações CRUD.

Cada módulo possui seu próprio repositório especializado:

- RepositorioFabricanteEmArquivo
- RepositorioEquipamentoEmArquivo
- RepositorioChamadoEmArquivo

---

# 💾 Persistência de Dados

O sistema utiliza persistência em arquivos JSON.

## 📄 Classe Serializable

Responsável por:

- Salvar dados em arquivo
- Carregar dados do arquivo
- Serializar objetos
- Desserializar objetos

Os dados são armazenados automaticamente no diretório:

```text
LocalApplicationData/GestaoDeEquipamentoWeb/dados.json
```

---

# 🧩 Entidades do Sistema

## 🏭 Fabricante

Representa os fabricantes dos equipamentos.

### Propriedades

- Nome
- Email
- Telefone

---

## 🖥️ Equipamento

Representa os equipamentos cadastrados.

### Propriedades

- Nome
- Preço de Aquisição
- Data de Fabricação
- Fabricante

---

## 📞 Chamado

Representa chamados técnicos.

### Propriedades

- Título
- Descrição
- Equipamento
- Data de Abertura
- Tempo Decorrido
- Status

---

# 📋 ViewModels

Os ViewModels são utilizados para separar os dados da interface dos modelos de domínio.

O sistema possui ViewModels específicos para:

- Cadastro
- Edição
- Exclusão
- Listagem

---

# ✔️ Validações

O sistema utiliza:

- DataAnnotations
- Validações personalizadas
- ModelState

Exemplos:

- Campos obrigatórios
- Tamanho mínimo e máximo
- Validação de email
- Valores positivos
- Datas válidas

---

# 🎨 Interface Web

A interface foi construída utilizando:

- Razor Views
- HTML5
- CSS3

## ✨ Características da Interface

- Layout responsivo
- Navegação superior
- Formulários estilizados
- Tabelas organizadas
- Feedback visual para validações
- Design moderno com gradientes

---

# 🧭 Layout Principal

O arquivo `_Layout.cshtml` define:

- Navbar principal
- Estrutura base das páginas
- Importação do CSS
- Fonte personalizada Google Sans

---

# 🎮 Controllers

## 🏭 FabricanteController

Responsável pelo CRUD de fabricantes.

## 🖥️ EquipamentoController

Responsável pelo CRUD de equipamentos.

## 📞 ChamadoController

Responsável pelo CRUD de chamados.

## 🏠 HomeController

Responsável pela página inicial.

---

# ▶️ Execução do Projeto

## 📌 Pré-requisitos

- .NET SDK instalado
- Visual Studio ou VS Code

---

## 📥 Clonar o Repositório

```bash
git clone URL_DO_REPOSITORIO
```

---

## ▶️ Executar o Projeto

```bash
dotnet run
```

---

# 🔮 Melhorias Futuras

Possíveis melhorias para o sistema:

- Banco de dados SQL Server
- Entity Framework Core
- Sistema de autenticação
- Controle de usuários
- Dashboard
- Filtros e pesquisas
- Responsividade mobile
- API REST
- Testes automatizados

---

# 📚 Conceitos Aplicados

- Programação Orientada a Objetos
- MVC
- Repository Pattern
- Serialização JSON
- Razor Views
- CRUD
- Validações
- Persistência de Dados
