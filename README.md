# RazorPagesMovie

* In this project I studied Razor Pages on Asp.Net Core

* To clone this repository you will need __Visual Studio 2019__ and __.NET 5.0 SDK__ or later installed on your machine

## Anota��es
### Scaffolding 
* Ferramenta respons�vel por gerar as p�ginas para opera��es de __CRUD__ (Create, Read, Update, Delete (Criar, Ler, Atualizar, Deletar))
* O mecanismo de scaffolding cria marca��o para cada campo no modelo, exceto a Razor ID.

### Razor
* Pode fazer a transi��o de HTML para C#.
	* Quando um s�mbolo � seguido por uma palavra-chave reservada, ele faz a transi��o para uma marca��o espec�fica
	* Para acessar a documenta��o acesse [Palavras-chave Razor](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/razor?view=aspnetcore-5.0#razor-reserved-keywords)

* O que � a diretiva __@page__
	1. Torna o arquivo uma a��o MVC, o que significa que ele pode manipular solicita��es.
	2. Deve ser a primeira diretiva Razor em uma p�gina.

* O que � a diretiva __@model__
	1. Especifica o tipo do modelo passado para a P�gina Razor.
	2. O modelo � usado nos [auxiliares HTML](https://docs.microsoft.com/pt-br/aspnet/mvc/overview/older-versions-1/views/creating-custom-html-helpers-cs#understanding-html-helpers) ```@Html.DisplayNameFor``` e ```@Html.DisplayFor``` na p�gina.

* A p�gina de [layout](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/layout?view=aspnetcore-5.0)
	1. O layout de menu � implementado no arquivo _Layout.cshtml.
	2. Os modelos de layout permitem que o layout do cont�iner HTML seja:
		* Especificado em um �nico lugar.
		* Aplicado a v�rias p�ginas no site.
	3. A tag __RenderBody__ � um espa�o reservado em que todas as exibi��es espec�ficas da p�gina s�o mostradas, encapsuladas na p�gina de layout. 

* No arquivo Create.cshtml:
	1. O elemento ```<form method="post">``` � um [auxiliar de marcas de formul�rio](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0#the-form-tag-helper). O auxiliar de marcas de formul�rio inclui automaticamente um [token antifalsifica��o](https://docs.microsoft.com/pt-br/aspnet/core/security/anti-request-forgery?view=aspnetcore-5.0).

* Banco de dados
	1. O ASP.NET Core de configura��o de dados l� a __ConnectionString__ chave. Para o desenvolvimento local, a configura��o obt�m a cadeia de conex�o do __appsettings.json__ do arquivo.
	2. Quando o aplicativo � implantado em um servidor de teste ou de produ��o, uma vari�vel de ambiente pode ser usada para definir a cadeia de conex�o como um servidor de banco de dados de teste ou de produ��o.
	3. O Visual Studio possui a ferramenta __SQL Server Object Explorer__

* No arquivo Index.cshtml.cs:
	1. ```[BindProperty]``` associa valores de formul�rio e cadeias de consulta ao mesmo nome da propriedade. 
	2. ```SelectList``` permite que o usu�rio selecione um item na lista.
		* Exige ```using Microsoft.AspNetCore.Mvc.Rendering;```.

* Difeten�a entre os atributos ```[DataType]``` e ```[DisplayFormat]```:
	1. ```[DisplayFormat]```: Permite que seja configurada a formata��o do tipo de dados (exemplo, data)
	2. ```[DataType]```: transmite a sem�ntica dos dados em vez de como renderiz�-los em uma tela. 
		* Vantagens do ```[Datatype]```:
			1. O navegador pode habilitar recursos HTML5, por exemplo, para mostrar um controle de calend�rio, o s�mbolo de moeda apropriado � localidade, links de email etc.
			2. Por padr�o, o navegador renderiza dados usando o formato correto com base em sua localidade.
			3. Pode permitir que a estrutura ASP.NET Core escolha o modelo de campo correto para renderizar os dados. O ```DisplayFormat``` , se usado por si s�, usa o modelo de cadeia de caracteres.

### DRY (Don't Repeat Yourself')
* Razor Pages incentivam o desenvolvimento em que a funcionalidade � especificada uma vez e � refletida em todo o aplicativo. O DRY pode ajudar a:
	1. Reduzir a quantidade de c�digo em um aplicativo.
	2. Fazer com que o c�digo seja menos propenso a erros e mais f�cil de ser testado e mantido.

* O suporte de valida��o fornecido pelas Razor Pages e pelo Entity Framework s�o um bom exemplo do princ�pio DRY:
	1. As regras de valida��o s�o especificadas declarativamente em um �nico lugar, na classe de modelo.
	2. As regras s�o impostas em todos os lugares do aplicativo.

* Ter regras de valida��o impostas automaticamente por ASP.NET Core ajuda:
	1. Tornar o aplicativo mais robusto.
	2. Reduza as chances de salvar dados inv�lidos no banco de dados.