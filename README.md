# Image Resizer v 2.0

Projeto de uma API para redimensionamento de imagem utilizando a biblioteca [Magick.NET](https://www.nuget.org/packages/Magick.NET-Q16-AnyCPU/), esse projeto pode ser útil em sistema ondem se faz necessário otimizar e diminuir tamanho de imagens e servicos de terceiros possuem limite de quantidade máximas de imagens dia.

## Inicio
Para uma cópia do projeto em execução na sua máquina local para fins de desenvolvimento e teste.

```
git clone https://github.com/httpmurilo/imageResizer.git
```
Consulte implantação para obter notas sobre como implantar o projeto em um sistema ativo.

## Pré - requisitos
Se faz necessário a instalação do [.NET sdk](https://dotnet.microsoft.com/download) na maquina que executará o projeto.

## Deploy
Necessário executar a API - por padrão ela ficará ativa na porta 5000 e 5001 para HTTPS. 
```
dotnet run
```

## Desenvolvimento com
* [ASP.NET Core 3.1](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-3.1) - Framework utilizada.

## Simulaçao
Informar um dos arquivos da pasta Images por parâmetro na url.


## Licença
Projeto disponibilizado sem restrições. 

## Contribuições
Submeta um  pull request ou a abertura de um issue.