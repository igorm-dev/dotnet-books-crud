namespace ApiLivros.Models;

public class Livro
{
	public string Id { get; set; }
	public string Titulo { get; set; }
	public string Autor { get; set; }
	public int AnoPublicacao { get; set; }

	// public Livro(int Id, string Titulo, string Autor, int AnoPublicacao)
	// {
	// 	this.Id = Id;
	// 	this.Titulo = Titulo;
	// 	this.Autor = Autor;
	// 	this.AnoPublicacao = AnoPublicacao;
	// }
}
