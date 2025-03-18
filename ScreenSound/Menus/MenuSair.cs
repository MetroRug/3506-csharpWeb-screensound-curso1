using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(ArtistasDAL artistaDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
