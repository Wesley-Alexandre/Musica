# 🎵 Repositório Musical

Este é um sistema web para gerenciar artistas, músicas e playlists. Criado com ASP.NET Core MVC, Entity Framework Core e banco de dados SQLite.

## 🔧 Tecnologias Utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Razor Views
- Bootstrap (opcional para estilização)

## 📁 Estrutura do Projeto

- `Controllers/` - Controladores responsáveis pelas regras de navegação e lógica.
- `Models/` - Classes de modelo que representam as entidades do banco.
- `Views/` - Páginas da interface (Razor Views).
- `Data/` - Contexto do banco de dados (AppDbContext).
- `Migrations/` - Mapeamento e histórico do banco via EF Core.

## 📌 Funcionalidades

- Cadastro de Artistas (com Nome, Nacionalidade e Gênero)
- Cadastro de Músicas (com Título, Gênero, Duração e vínculo com Artistas e Playlists)
- Criação e gerenciamento de Playlists
- Relacionamento entre entidades com navegação

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/Wesley-Alexandre/Musica.git

   cd Musica

   dotnet restore
   
   dotnet ef database update

   dotnet run

##   ✍️ Autor
## Wesley Alexandre






