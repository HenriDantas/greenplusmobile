using Microsoft.AspNetCore.Components;

namespace Greenplus.Components.Pages
{

    public partial class Login : ComponentBase
    {
        private string usuario;
        private string senha;

        private void OnButtonClick()
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                Console.WriteLine("Usuário e senha não podem estar vazios.");
                // lógica
            } else
            {
            
                Console.WriteLine($"Usuário: {usuario}, Senha: {senha}");
            }
        }
    }
}


