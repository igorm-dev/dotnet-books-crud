using ApiLivros.Models;

namespace ApiLivros.Routes;

public static class ROTA_GET 
{
	public static void MapGetRoutes (this WebApplication app) 
	{
		// Nesse campo deve conter o "banco" de dados com os livros da API
		List<Livro> livros =
		[
			new() { Id="70096fbe-9547-47c5-a49e-d185e216a0ef", Autor="J.K. Rowling", Titulo="Harry Potter e a Pedra Filosofal", AnoPublicacao=2001 },
			new() { Id="1454086c-dd5d-41a2-acb2-8ff8f99fdcda", Autor="J.K. Rowling", Titulo="Harry Potter e a Câmara Secreta", AnoPublicacao=2002 },
			new() { Id="aab3d86a-ef11-424b-9f96-40cc3af226a8", Autor="J.K. Rowling", Titulo="Harry Potter e o Prisioneiro de Azkaban", AnoPublicacao=2004 },
			new() { Id="217ac283-0272-44ab-9bd1-0d50ae2fc323", Autor="J.K. Rowling", Titulo="Harry Potter e o Cálice de Fogo", AnoPublicacao=2005 },
			new() { Id="d5e8041d-920f-45e9-b8fb-b1deb82c6e5e", Autor="J.K. Rowling", Titulo="Harry Potter e a Ordem da Fênix", AnoPublicacao=2007 },
			new() { Id="6cc25209-05a5-4081-8f0a-a9d3739236fd", Autor="J.K. Rowling", Titulo="Harry Potter e o Enigma do Príncipe", AnoPublicacao=2009 },
			new() { Id="e8481210-c060-4c68-9b91-527d8d12aed7", Autor="J.K. Rowling", Titulo="Harry Potter e as Relíquias da Morte - Parte 1", AnoPublicacao=2010 },
			new() { Id="f1a07926-d767-4c5d-bf04-080f163c3fd0", Autor="J.K. Rowling", Titulo="Harry Potter e as Relíquias da Morte - Parte 2", AnoPublicacao=2011 },
		];

		// Rota Get RAIZ
		app.MapGet("/", () => "API Livros - Versão 1.0");

		// Rota Get - Listar todos os livros
		app.MapGet("/livros", () => 
		{
			return livros;
		});

		app.MapGet("/livro/{id}", (string id) => {
			var livro = livros.FirstOrDefault((livro) => livro.Id == id);

			return livro != null ? Results.Ok(livro) : Results.NotFound("Livro não encontrado");
		});
	}
}
