using Desafio05_Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/usuarios", () =>
{
    return BancoDeDados.Usuarios;
});

app.MapGet("usuarios/{id}", (int id) =>
{
    return BancoDeDados.Usuarios.Find(u => u.Id == id);
});


app.Run();