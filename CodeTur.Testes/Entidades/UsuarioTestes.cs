using CodeTur.Comum.Enum;
using CodeTur.Dominio.Entidades;
using Xunit;

namespace CodeTur.Testes.Entidades
{
    public class UsuarioTestes
    {
        [Fact]
        public void DeveRetornarErroSeUsuarioInvalido()
        {
            var usuario = new Usuario("", "kailaneps@hotmail.com", "", EnTipoUsuario.Admin);
            Assert.True(usuario.Invalid, "Usuário é valido");
        }

        [Fact]
        public void DeveRetornarSucessoSeUsuarioValido()
        {
            var usuario = new Usuario("Kailane Pereira", "kailaneps@hotmail.com", "1234567", EnTipoUsuario.Admin);
            Assert.True(usuario.Valid, "Usuário é Invalido");
        }

        [Fact]
        public void DeveRetornarErroSeTelefoneUsuarioInValido()
        {
            var usuario = new Usuario("Kailane Pereira", "kailaneps@hotmail.com", "1234567", EnTipoUsuario.Admin);
            usuario.AdiconarTelefone("67872");
            Assert.True(usuario.Invalid, "Número do telefone é Válido");
        }

        [Fact]
        public void DeveRetornaSucessoSeTelefoneUsuarioValido()
        {
            var usuario = new Usuario("Kailane Pereira", "kailaneps@hotmail.com", "1234567", EnTipoUsuario.Admin);
            usuario.AdiconarTelefone("11967872456");
            Assert.True(usuario.Valid, "Número do telefone é Inválido");
        }

    }
}
