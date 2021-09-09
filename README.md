# RazorPagesMovie

* In this project I studied Razor Pages on Asp.Net Core

* To clone this repository you will need visual studio 2019 and .NET 5.0 SDK or later installed on your machine

## Anotações
### Scaffolding 
* Ferramenta responsável por gerar as páginas para operações de CRUD (Create, Read, Update, Delete (Criar, Ler, Atualizar, Deletar))
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
	1. O elemento <form method="post"> é um [auxiliar de marcas de formulário](https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0#the-form-tag-helper). O auxiliar de marcas de formulário inclui automaticamente um [token antifalsificação](https://docs.microsoft.com/pt-br/aspnet/core/security/anti-request-forgery?view=aspnetcore-5.0).
