# Manual Dotnet
Repositório com o objetivo de servir como guia de referência para o .NET e a linguagem C#.
O .NET é um ambiente de programação que suporta a execução de programas nas linguagens C#, F# e Visual Basic. Assemelha-se ao Java, que roda em cima de um ambiente de execução (Java VM) com o objetivo de garantir segurança de hardware (ambiente gerenciado) e gestão de recursos aos programas executados.   
O ambiente também tem como objetivo permitir a interoperabilidade entre as linguagens suportadas e fornecer uma biblioteca ampla de ferramentas.   
Não é possível executar código C# fora do ambiente .NET!    

[Link da documentação oficial](https://learn.microsoft.com/en-us/dotnet/csharp/)  
[API's do .NET](https://learn.microsoft.com/pt-br/dotnet/api/)

## Comandos de criação de projeto, de build e de execução
* Criar aplicação de console:
`dotnet new console`
    * Para criar a pasta com o nome do projeto (se já não foi feito):
    `dotnet new console -n meuProjeto`
* Criar API Web:
`dotnet new webapi minhaApi`
    * Ou criando a pasta do projeto:
    `dotnet new webapi -n minhaApi`
     
* Rodar:
`dotnet run nome_arquivo.cs` ou apenas `dotnet run`
* Rodar em modo de release:
`dotnet run -c Release`
    
* Compilar arquivos .cs do projeto (cria pastas obj e bin/Debug):
`dotnet build`
* Compilar projeto para release:
`dotnet build -c Release`

* Adicionar pacotes (API's) que não estão inclusas na SDK:
`dotnet add package nomeDoPacote`

[Link para o guia dos comandos dotnet](https://learn.microsoft.com/en-us/dotnet/core/tools/)
    
Observação 1: O arquivo 'nomeDoProjeto.csproj' é aquele que define os metadados do projeto, dentre eles o framework de execução. A máquina onde o código é executado precisa conter esse framework.

Observação 2: Na pasta 'bin' estão os arquivos executáveis ('IL' = pré-binário) e na pasta 'obj' estão os arquivos executáveis ('IL' = pré-binário) intermediários (arquivos de execução que serão aproveitados caso não haja alteração).

## Ambiente de execução de desenvolvimento x produção
O SDK do .NET é usado para desenvolvimento. Com esse pacote, tem-se acesso a comandos específicos para desenvolvedores como por exemplo o comando dotnet build.

Para apenas execução do lado do cliente e em produção, usa-se 'runtimes' mais leves e enxutas, como:
1. ASP .NET Core Runtime
2. .NET Desktop Runtime
3. .NET Runtime
Nesses arquivos estão contidas as CLR's, que são as máquinas virtuais do .NET para fazer a compilação real dos programas, bem como o gerenciamento de memória.