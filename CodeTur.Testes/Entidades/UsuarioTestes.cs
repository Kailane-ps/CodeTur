using CodeTur.Comum.Enum;
using CodeTur.Dominio.Entidades;

namespace CodeTur.Testes.Entidades
{
    public class UsuarioTestes
    {
        public void Usuario()
        {
            var usuario = new Usuario("Kailane Pereira", "kailaneps@hotmail.com", "123456", EnTipoUsuario.Admin );
            
        }
    }
}
