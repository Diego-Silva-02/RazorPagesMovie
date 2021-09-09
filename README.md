# RazorPagesMovie

* In this project I studied Razor Pages on Asp.Net Core

* To clone this repository you will need visual studio 2019 and .NET 5.0 SDK or later installed on your machine

## Anota��es
### Scaffolding 
* Ferramenta respons�vel por gerar as p�ginas para opera��es de CRUD (Create, Read, Update, Delete (Criar, Ler, Atualizar, Deletar))
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
	1. O elemento <form method="post"> � um [auxiliar de marcas de formul�rio](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0#the-form-tag-helper). O auxiliar de marcas de formul�rio inclui automaticamente um [token antifalsifica��o](https://docs.microsoft.com/pt-br/aspnet/core/security/anti-request-forgery?view=aspnetcore-5.0).
