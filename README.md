# Digital Innovation One - Prática .NET

## Criando uma APP de cadastro em memória

[Slides](dio-dotnet-poo-lab-2.pdf)

## Contato

Eliézer Zarpelão

Linkedin:  [br.linkedin.com/in/eliezerzarpelao](http://br.linkedin.com/in/eliezerzarpelao)

WebSite:  [eliezerzarpelao.eti.br](https://eliezerzarpelao.eti.br)

Instagram:  [instagram.com/eliezerzarpelao](https://instagram.com/eliezerzarpelao)

YouTube:  [youtube.com/channel/UC47RD-s-U6fpKTY0soIUn6g](https://www.youtube.com/channel/UC47RD-s-U6fpKTY0soIUn6g/featured?view_as=subscriber)

Twitter:  [@eliezerzarpelao](https://twitter.com/eliezerzarpelao)

Github:  [github.com/elizarp](https://github.com/elizarp)

##

Edição

Paulo Alcantara:

SQL:

CREATE DATABASE SeriesDB

CREATE TABLE [dbo].[Serie]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Genero] INT NULL, 
    [Titulo] VARCHAR(100) NULL, 
    [Descricao] VARCHAR(100) NULL, 
    [Ano] INT NULL, 
    [Excluido] BIT NULL
)

