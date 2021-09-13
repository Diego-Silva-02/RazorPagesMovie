# RazorPagesMovie

* In this project I studied Razor Pages on Asp.Net Core

* To clone this repository you will need __Visual Studio 2019__ and __.NET 5.0 SDK__ or later installed on your machine

## Anotações
### Scaffolding 
* Ferramenta responsável por gerar as páginas para operações de __CRUD__ (Create, Read, Update, Delete (Criar, Ler, Atualizar, Deletar))
* O mecanismo de scaffolding cria marcação para cada campo no modelo, exceto a Razor ID.

### Razor
* Pode fazer a transição de HTML para C#.
	* Quando um símbolo é seguido por uma palavra-chave reservada, ele faz a transição para uma marcação específica
	* Para acessar a documentação acesse [Palavras-chave Razor](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/razor?view=aspnetcore-5.0#razor-reserved-keywords)

* O que é a diretiva __@page__
	1. Torna o arquivo uma ação MVC, o que significa que ele pode manipular solicitações.
	2. Deve ser a primeira diretiva Razor em uma página.

* O que é a diretiva __@model__
	1. Especifica o tipo do modelo passado para a Página Razor.
	2. O modelo é usado nos [auxiliares HTML](https://docs.microsoft.com/pt-br/aspnet/mvc/overview/older-versions-1/views/creating-custom-html-helpers-cs#understanding-html-helpers) ```@Html.DisplayNameFor``` e ```@Html.DisplayFor``` na página.

* A página de [layout](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/layout?view=aspnetcore-5.0)
	1. O layout de menu é implementado no arquivo _Layout.cshtml.
	2. Os modelos de layout permitem que o layout do contêiner HTML seja:
		* Especificado em um único lugar.
		* Aplicado a várias páginas no site.
	3. A tag __RenderBody__ é um espaço reservado em que todas as exibições específicas da página são mostradas, encapsuladas na página de layout. 

* No arquivo Create.cshtml:
	1. O elemento ```<form method="post">``` é um [auxiliar de marcas de formulário](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0#the-form-tag-helper). O auxiliar de marcas de formulário inclui automaticamente um [token antifalsificação](https://docs.microsoft.com/pt-br/aspnet/core/security/anti-request-forgery?view=aspnetcore-5.0).

* Banco de dados
	1. O ASP.NET Core de configuração de dados lê a __ConnectionString__ chave. Para o desenvolvimento local, a configuração obtém a cadeia de conexão do __appsettings.json__ do arquivo.
	2. Quando o aplicativo é implantado em um servidor de teste ou de produção, uma variável de ambiente pode ser usada para definir a cadeia de conexão como um servidor de banco de dados de teste ou de produção.
	3. O Visual Studio possui a ferramenta __SQL Server Object Explorer__

* No arquivo Index.cshtml.cs:
	1. ```[BindProperty]``` associa valores de formulário e cadeias de consulta ao mesmo nome da propriedade. 
	2. ```SelectList``` permite que o usuário selecione um item na lista.
		* Exige ```using Microsoft.AspNetCore.Mvc.Rendering;```.

* Difetença entre os atributos ```[DataType]``` e ```[DisplayFormat]```:
	1. ```[DisplayFormat]```: Permite que seja configurada a formatação do tipo de dados (exemplo, data)
	2. ```[DataType]```: transmite a semântica dos dados em vez de como renderizá-los em uma tela. 
		* Vantagens do ```[Datatype]```:
			1. O navegador pode habilitar recursos HTML5, por exemplo, para mostrar um controle de calendário, o símbolo de moeda apropriado à localidade, links de email etc.
			2. Por padrão, o navegador renderiza dados usando o formato correto com base em sua localidade.
			3. Pode permitir que a estrutura ASP.NET Core escolha o modelo de campo correto para renderizar os dados. O ```DisplayFormat``` , se usado por si só, usa o modelo de cadeia de caracteres.

### DRY (Don't Repeat Yourself')
* Razor Pages incentivam o desenvolvimento em que a funcionalidade é especificada uma vez e é refletida em todo o aplicativo. O DRY pode ajudar a:
	1. Reduzir a quantidade de código em um aplicativo.
	2. Fazer com que o código seja menos propenso a erros e mais fácil de ser testado e mantido.

* O suporte de validação fornecido pelas Razor Pages e pelo Entity Framework são um bom exemplo do princípio DRY:
	1. As regras de validação são especificadas declarativamente em um único lugar, na classe de modelo.
	2. As regras são impostas em todos os lugares do aplicativo.

* Ter regras de validação impostas automaticamente por ASP.NET Core ajuda:
	1. Tornar o aplicativo mais robusto.
	2. Reduza as chances de salvar dados inválidos no banco de dados.