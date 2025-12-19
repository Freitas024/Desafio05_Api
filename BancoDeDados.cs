namespace Desafio05_Api;

public static class BancoDeDados
{
    // static = Essa lista pertence à CLASSE, não a uma instância.
    // É o jeito mais fácil de simular um DB em memória persistente.
    public static List<Usuario> Usuarios { get; } = new List<Usuario>
    {
        new Usuario(1, "Vinicius", "Dev Front-end"),
        new Usuario(2, "Chat GPT", "Assistente"),
        new Usuario(3, "Bill Gates", "Dono da Microsoft")
    };
}