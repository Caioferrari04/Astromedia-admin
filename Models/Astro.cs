namespace Astromedia_admin.Models;
public class Astro
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Curiosidades { get; set; }
    public string Foto { get; set; }

    public Astro() { }
    public Astro(int id, string nome, string curiosidades, string foto) 
    { 
        Id = id;
        Nome = nome;
        Curiosidades = curiosidades;
        Foto = foto; 
    }
    public Astro(string nome, string curiosidades, string foto) 
    { 
        Nome = nome;
        Curiosidades = curiosidades;
        Foto = foto; 
    }
}